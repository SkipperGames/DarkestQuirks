using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DarkestQuirks
{
    public partial class Form1 : Form
    {
        private JsonQuirkData quirk_data =
            new JsonQuirkData();

        private JsonBuffData buff_data =
            new JsonBuffData();

        private List<Quirk> quirks;

        XDocument descriptions;
        XDocument dialogue;

        bool initialized = false;

        public Form1()
        {
            InitializeComponent();

            if (!(this.Enabled = 
                initialized = 
                InitializeData()))
            {
                return;
            }

            SortQuirks(this, null);

            lbx_quirklist.SelectedIndexChanged += lbx_quirklist_SelectedIndexChanged;
            lbx_quirklist.SelectedIndex = 0;

            ch_sortalphabetic.CheckedChanged += SortQuirks;
            ch_sortpositive.CheckedChanged += SortQuirks;

            cbx_curiotags.SelectedIndexChanged += cbx_curiotags_SelectedIndexChanged;
            cbx_curiotags.SelectedIndex = 0;

            tbx_quirkid.KeyPress += (sender, e) =>
            {
                if (chb_editmode.Checked)
                {
                    e.Handled = char.IsPunctuation(e.KeyChar) |
                        char.IsNumber(e.KeyChar) |
                        char.IsDigit(e.KeyChar);
                }
            };

            tbx_class.MouseDown += (sender, e) =>
            {
                if (chb_editmode.Checked)
                {
                    tbx_class.Text = tbx_class.Text == "mental" ? "physical" : "mental";
                }
            };

            lbx_buffs.DragEnter += OnDragEnter;
            lbx_buffs.DragDrop += lbx_buffs_DragDrop;
            lbx_buffs.MouseDown += lbx_buffs_MouseDown;
            lbx_buffroster.MouseDown += lbx_buffroster_MouseDown;

            lbx_incompatible.DragEnter += OnDragEnter;
            lbx_incompatible.DragDrop += lbx_incompatible_DragDrop;
            lbx_incompatible.MouseDown += lbx_incompatible_MouseDown;
            lbx_quirklist.MouseDown += lbx_quirklist_MouseDown;

            ch_positive.CheckedChanged += mainCheckBoxesChecked;
            ch_disease.CheckedChanged += mainCheckBoxesChecked;
            ch_keeploot.CheckedChanged += mainCheckBoxesChecked;

            int max_length =
                quirks.OrderByDescending(x => x.id.Length).First().id.Length;
            tbx_quirkid.MaxLength = max_length;
            
            rtb_description.KeyPress += (sender, e) => { e.Handled = ch_showdesc.Checked; };

            ch_showdesc.CheckedChanged += (sender, e) =>
            {
                if (chb_editmode.Checked)
                {
                    rtb_description.Text = ch_showdesc.Checked ? "" : rtb_description.Text;
                }
            };

            tc_properties.SelectedIndexChanged += (sender, e) =>
            {
                lb_quirkid.Parent =
                    tbx_quirkid.Parent =
                    lb_class.Parent =
                    tbx_class.Parent =
                    tc_properties.SelectedTab;
            };
        }

        private bool InitializeData()
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(
                    Application.StartupPath + "/shared/quirk/quirk_library.json"))
                {
                    quirk_data = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonQuirkData>(sr.ReadToEnd());
                    quirks = quirk_data.quirks.ToList();
                    sr.Close();
                }

                using (System.IO.FileStream fs = System.IO.File.OpenRead(
                    Application.StartupPath + "/curios/curio_type_library.csv"))
                using (Microsoft.VisualBasic.FileIO.TextFieldParser parser =
                    new Microsoft.VisualBasic.FileIO.TextFieldParser(fs))
                {
                    List<string> curiotypes = new List<string>();
                    int i = 0;

                    parser.Delimiters = new[] { "," };
                    while (!parser.EndOfData)
                    {
                        if (parser.ReadFields()[1] != "")
                        {
                            for (i = 0; i < 7; i++)
                            {
                                if (!parser.EndOfData)
                                {
                                    parser.ReadLine();
                                }
                                else break;
                            }

                            curiotypes.Add(parser.ReadFields()[2]);
                        }
                    }

                    cbx_curiotags.Items.Add("(none)");
                    cbx_curiotags.Items.AddRange(
                        curiotypes.Select(a => a).Distinct().OrderBy(b => b).ToArray());

                    parser.Close();
                }

                using (System.IO.StreamReader sr = new System.IO.StreamReader(
                    Application.StartupPath + "/shared/buffs/buff_library.json"))
                {
                    buff_data = Newtonsoft.Json.JsonConvert.DeserializeObject<JsonBuffData>(sr.ReadToEnd());

                    lbx_buffroster.Items.AddRange(
                        buff_data.buffs.Select(
                            a => a.id)
                            .Distinct()
                            .OrderBy(b => b)
                            .ToArray());

                    sr.Close();
                }

                descriptions = XDocument.Load(
                    Application.StartupPath + "/localization/quirks.string_table.xml");

                dialogue = XDocument.Load(
                    Application.StartupPath + "/localization/dialogue.string_table.xml");

                return true;
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Move this application to your game's installation folder\nor varify your game cache.", "Error");

                //System.Diagnostics.Debug.WriteLine(ex);
            }

            return false;
        }

        static void js_Error(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs e)
        {
            MessageBox.Show("Data invalid. Varify your game cache.\nDetails:\n\n" + e.CurrentObject.ToString(), "Data Error");
        }

        private void SaveData(object sender, EventArgs e)
        {
            try
            {
                if (!System.IO.Directory.Exists(
                    Application.StartupPath + "/_DarkestQuirksBackup/"))
                {
                    System.IO.Directory.CreateDirectory(
                        Application.StartupPath + "/_DarkestQuirksBackup/");
                }

                if (!System.IO.File.Exists(
                    Application.StartupPath + "/_DarkestQuirksBackup/quirk_library.json"))
                {
                    System.IO.File.Move(Application.StartupPath + "/shared/quirk/quirk_library.json",
                        Application.StartupPath + "/_DarkestQuirksBackup/quirk_library.json");
                }
                else goto BACKUPS_EXIST;

                if (!System.IO.File.Exists(
                    Application.StartupPath + "/_DarkestQuirksBackup/quirks.string_table.xml"))
                {
                    System.IO.File.Move(Application.StartupPath + "/localization/quirks.string_table.xml",
                        Application.StartupPath + "/_DarkestQuirksBackup/quirks.string_table.xml");
                }
                else goto BACKUPS_EXIST;

                if (!System.IO.File.Exists(
                    Application.StartupPath + "/_DarkestQuirksBackup/dialogue.string_table.xml"))
                {
                    System.IO.File.Move(Application.StartupPath + "/localization/dialogue.string_table.xml",
                        Application.StartupPath + "/_DarkestQuirksBackup/dialogue.string_table.xml");
                }

                BACKUPS_EXIST:

                using (System.IO.FileStream fs = System.IO.File.OpenWrite(
                    Application.StartupPath + "/shared/quirk/quirk_library.json"))
                using (System.IO.StreamWriter sw = 
                    new System.IO.StreamWriter(fs))
                using (Newtonsoft.Json.JsonWriter jw =
                    new Newtonsoft.Json.JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;

                    Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();

                    quirk_data.quirks = quirks.ToArray();

                    js.Serialize(jw, quirk_data);

                    jw.Close();
                }

                descriptions.Save(
                    Application.StartupPath + "/localization/quirks.string_table.xml");

                dialogue.Save(
                    Application.StartupPath + "/localization/dialogue.string_table.xml");

                MessageBox.Show("Modifications saved");
            }
            catch //(Exception ex)
            {
                //System.Diagnostics.Debug.WriteLine(ex);
            }
        }
        
        private void lbx_quirklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chb_editmode.Checked)
            {
                return;
            }

            tbx_quirkid.Text =
                descriptions.XPathSelectElement(
                ".//entry[@id = \"" +
                "str_quirk_name_" + quirks[lbx_quirklist.SelectedIndex].id + "\"]").Value;

            tbx_class.Text = quirks[lbx_quirklist.SelectedIndex].classification;

            ch_showdesc.Checked = quirks[lbx_quirklist.SelectedIndex].show_explicit_description;
            ch_positive.Checked = quirks[lbx_quirklist.SelectedIndex].is_positive;
            ch_disease.Checked = quirks[lbx_quirklist.SelectedIndex].is_disease;
            ch_keeploot.Checked = quirks[lbx_quirklist.SelectedIndex].keep_loot;

            lbx_incompatible.Items.Clear();
            lbx_incompatible.Items.AddRange(
                quirks[lbx_quirklist.SelectedIndex].incompatible_quirks);

            cbx_curiotags.SelectedItem =
                quirks[lbx_quirklist.SelectedIndex].curio_tag == "" ?
                "(none)" : quirks[lbx_quirklist.SelectedIndex].curio_tag;

            tbx_curiochance.Text = quirks[lbx_quirklist.SelectedIndex].curio_tag_chance.ToString();

            if (tbx_curiochance.Text.Length == 1)
            {
                tbx_curiochance.Text += ".0";
            }

            lbx_buffs.Items.Clear();
            lbx_buffs.Items.AddRange(
                quirks[lbx_quirklist.SelectedIndex].buffs);

            var desc = descriptions.XPathSelectElement(
                ".//entry[@id = \"" +
                "str_quirk_description_" + 
                quirks[lbx_quirklist.SelectedIndex].id + 
                "\"]");

            rtb_description.Text = desc != null ? desc.Value : "";

            rtb_curiodialog1.Text =
                rtb_curiodialog2.Text =
                rtb_curiodialog3.Text = "";

            var quotes = dialogue.XPathSelectElements(
                ".//entry[@id = \"" +
                "trigger_curio_quirk_" + 
                quirks[lbx_quirklist.SelectedIndex].id + 
                "\"]").ToArray();

            for (int i = 0; i < quotes.Count(); i++)
            {
                switch (i)
                {
                    case 0: rtb_curiodialog1.Text = quotes[i].Value; break;
                    case 1: rtb_curiodialog2.Text = quotes[i].Value; break;
                    case 2: rtb_curiodialog3.Text = quotes[i].Value; break;
                    default: break;
                }
            }
        }

        private void SortQuirks(object sender, EventArgs e)
        {
            if (!(ch_sortpositive.Checked | ch_sortalphabetic.Checked))
            {
                return;
            }

            lbx_quirklist.Items.Clear();

            if (ch_sortpositive.Checked)
            {
                Quirk[] positive = quirks.Where(q => q.is_positive == true).ToArray();
                Quirk[] negative = quirks.Where(q => q.is_positive == false).ToArray();

                quirks.Clear();

                if (ch_sortalphabetic.Checked)
                {
                    positive = positive.OrderBy(q => q.id).ToArray();
                    negative = negative.OrderBy(q => q.id).ToArray();
                }

                quirks.AddRange(positive);
                quirks.AddRange(negative);
            }
            else if (ch_sortalphabetic.Checked)
            {
                quirks = quirks.OrderBy(a => a.id).ToList();
            }

            lbx_quirklist.Items.AddRange(quirks.Select(a => a.id).ToArray());
            lbx_quirklist.SelectedItem = tbx_quirkid.Text.ToLower().Replace(" ", "");
        }

        private void chb_editmode_CheckedChanged(object sender, EventArgs e)
        {
            cbx_curiotags.Enabled =
                ch_showdesc.AutoCheck =
                ch_positive.AutoCheck =
                ch_disease.AutoCheck =
                ch_keeploot.AutoCheck =
                b_addquirk.Enabled =
                b_reset.Enabled =
                num_curiotagchance.Visible =
                chb_editmode.Checked;

            lbx_incompatible.BackColor =
                lbx_buffs.BackColor =
                tbx_class.BackColor =
                    chb_editmode.Checked ?
                        Color.White : this.BackColor;

            tbx_quirkid.ReadOnly =
                rtb_description.ReadOnly =
                rtb_curiodialog1.ReadOnly =
                rtb_curiodialog2.ReadOnly =
                rtb_curiodialog3.ReadOnly =
                tbx_curiochance.Visible =
                b_save.Enabled =
                !chb_editmode.Checked;

            if (chb_editmode.Checked)
            {
                if (ch_clear.Checked)
                {
                    cbx_curiotags.SelectedIndex = 0;

                    rtb_curiodialog1.Text =
                        rtb_curiodialog2.Text =
                        rtb_curiodialog3.Text = "";

                    b_reset_Click(this, null);
                }
            }
            else if (lbx_quirklist.SelectedIndex > -1)
            {
                lbx_quirklist_SelectedIndexChanged(this, null);
            }
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbx_buffs_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                int index = lbx_buffs.IndexFromPoint(
                    lbx_buffs.PointToClient(new Point(e.X, e.Y)));

                if (index == -1)
                {
                    lbx_buffs.Items.Add(
                        (string)e.Data.GetData(DataFormats.StringFormat));
                }
                else
                {
                    lbx_buffs.Items[index] =
                        (string)e.Data.GetData(DataFormats.StringFormat);
                }

                lbx_buffs.AllowDrop = false;
            }
        }

        private void lbx_buffroster_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chb_editmode.Checked)
            {
                return;
            }

            if (lbx_buffroster.Items.Count == 0)
            {
                return;
            }

            int index = lbx_buffroster.IndexFromPoint(e.X, e.Y);

            if (index == -1)
            {
                return;
            }

            string item = lbx_buffroster.Items[index].ToString();

            lbx_buffs.AllowDrop = true;
            lbx_incompatible.AllowDrop = false;
            lbx_buffroster.DoDragDrop((string)item, DragDropEffects.All);
        }

        private void lbx_buffs_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbx_buffs.Items.Count == 0)
            {
                return;
            }

            int index = lbx_buffs.IndexFromPoint(e.X, e.Y);

            if (index == -1)
            {
                return;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                lbx_buffs.Items.RemoveAt(index);
            }
        }

        private void b_addquirk_Click(object sender, EventArgs e)
        {
            if (tbx_quirkid.Text.Length == 0)
            {
                tooltip_warning.Show(
                    "Quirk needs a valid a name:\nexample_quirk",
                    tbx_quirkid, 3000);
                return;
            }
            
            if (!ch_showdesc.Checked && rtb_description.Text.Length == 0)
            {
                tc_properties.SelectedTab = tc_properties.TabPages[1];

                tooltip_warning.Show(
                    "Create a unique description or uncheck to use\nthe explicit version",
                    rtb_description, 4000);

                return;
            }

            if (cbx_curiotags.SelectedIndex != 0)
            {
                tc_properties.SelectedTab = tc_properties.TabPages[1];

                if (num_curiotagchance.Value == 0.0m)
                {
                    tooltip_warning.Show(
                        "Chance must be greater than zero if a tag is set.\nElse set the tag to (none)",
                        num_curiotagchance, 4000);
                }

                if (rtb_curiodialog1.Text.Length == 0 ||
                    rtb_curiodialog2.Text.Length == 0 ||
                    rtb_curiodialog3.Text.Length == 0)
                {

                    if (cbx_curiotags.SelectedIndex == 1)
                    {
                        tooltip_warning.Show(
                            "Must create 3 valid quotes if using the \"All\" curio tag.\nElse set the tag to (none)",
                            rtb_curiodialog1, 4000);
                        return;
                    }

                    tooltip_warning.Show(
                        "Must create a valid quote if a tag is set.\nElse set the tag to (none)",
                        rtb_curiodialog1, 4000);
                }

                return;
            }

            string item_id = tbx_quirkid.Text.ToLower().Replace("  ", "").Replace(' ', '_');
            while (item_id.Contains(" "))
            {
                item_id = item_id.Replace(" ", "");
            }

            if (lbx_quirklist.Items.Contains(item_id))
            {
                if (MessageBox.Show("Quirk already exists. Modify existing quirk instead?", "Notice", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    ModifyExistingQuirk(item_id);
                }

                lbx_quirklist.SelectedItem = item_id;

                return;
            }

            Quirk q = new Quirk()
            {
                id = item_id,
                show_explicit_description = ch_showdesc.Checked,
                is_positive = ch_positive.Checked,
                is_disease = ch_disease.Checked,
                classification = tbx_class.Text,
                curio_tag = cbx_curiotags.SelectedIndex == 0 ?
                    "" : (string)cbx_curiotags.SelectedItem,
                curio_tag_chance = num_curiotagchance.Value,
                keep_loot = ch_keeploot.Checked,
            };

            q.incompatible_quirks = new string[lbx_incompatible.Items.Count];
            lbx_incompatible.Items.CopyTo(q.incompatible_quirks, 0);

            q.buffs = new string[lbx_buffs.Items.Count];
            lbx_buffs.Items.CopyTo(q.buffs, 0);

            quirks.Add(q);

            XElement entry = new XElement("entry", "");
            XAttribute attr = new XAttribute("id", "");
            entry.Add(attr);
            XCData data = new XCData("");
            entry.Add(data);

            string s;

            attr.Value = "str_quirk_name_" + item_id;

            s = tbx_quirkid.Text;
            while (s.Contains("  "))
            {
                s.Replace("  ", "");
            }

            data.Value = s;

            descriptions
                .XPathSelectElement(".//language")
                .Add(entry);

            if (!ch_showdesc.Checked)
            {
                attr.Value = "str_quirk_description_" + item_id;

                s = rtb_description.Text.Replace('\n', ' ');
                while (s.Contains("  "))
                {
                    s.Replace("  ", "");
                }

                data.Value = s;

                descriptions
                    .XPathSelectElement(".//language")
                    .Add(entry);
            }

            attr.Value = "trigger_curio_quirk_" + item_id;
            switch (cbx_curiotags.SelectedIndex)
            {
                case 0: break;

                case 1:

                    if (rtb_curiodialog1.Text.Length > 0)
                    {
                        s = rtb_curiodialog1.Text.Replace('\n', ' ');
                        while (s.Contains("  "))
                        {
                            s.Replace("  ", "");
                        }

                        data.Value = s;
                            
                        dialogue
                            .XPathSelectElement(".//language")
                            .Add(entry);
                    }

                    if (rtb_curiodialog2.Text.Length > 0)
                    {
                        s = rtb_curiodialog2.Text.Replace('\n', ' ');
                        while (s.Contains("  "))
                        {
                            s.Replace("  ", "");
                        }

                        data.Value = s;

                        dialogue
                            .XPathSelectElement(".//language")
                            .Add(entry);
                    }

                    if (rtb_curiodialog3.Text.Length > 0)
                    {
                        s = rtb_curiodialog3.Text.Replace('\n', ' ');
                        while (s.Contains("  "))
                        {
                            s.Replace("  ", "");
                        }

                        data.Value = s;

                        dialogue
                            .XPathSelectElement(".//language")
                            .Add(entry);
                    }

                    break;

                default:
                    s = rtb_curiodialog1.Text.Replace('\n', ' ');
                        while (s.Contains("  "))
                        {
                            s.Replace("  ", "");
                        }

                        data.Value = s;
                            
                        dialogue
                            .XPathSelectElement(".//language")
                            .Add(entry);

                    break;
            }

            SortQuirks(this, null);
        }

        private void ModifyExistingQuirk(string item)
        {
            Quirk q = quirks.FirstOrDefault(
                x => x.id == item);

            if (q == null)
            {
                return;
            }

            q.show_explicit_description = ch_showdesc.Checked;
            q.is_positive = ch_positive.Checked;
            q.is_disease = ch_disease.Checked;
            q.classification = tbx_class.Text;
            q.curio_tag = cbx_curiotags.SelectedIndex == 0 ?
                "" : (string)cbx_curiotags.SelectedItem;
            q.curio_tag_chance = num_curiotagchance.Value;
            q.keep_loot = ch_keeploot.Checked;

            q.incompatible_quirks = new string[lbx_incompatible.Items.Count];
            lbx_incompatible.Items.CopyTo(q.incompatible_quirks, 0);

            q.buffs = new string[lbx_buffs.Items.Count];
            lbx_buffs.Items.CopyTo(q.buffs, 0);

            if (ch_showdesc.Checked)
            {
                descriptions.XPathSelectElement(
                    ".//entry[@id = \"" +
                    "str_quirk_description_" +
                    item +
                    "\"]").Remove();
            }
            
            XElement entry = new XElement("entry", "");
            XAttribute attr = new XAttribute("id", "");
            entry.Add(attr);
            XCData data = new XCData("");
            entry.Add(data);

            string s;
            
            if (!ch_showdesc.Checked)
            {
                attr.Value = "str_quirk_description_" + item;

                s = rtb_description.Text.Replace('\n', ' ');
                while (s.Contains("  "))
                {
                    s.Replace("  ", "");
                }

                data.Value = s;

                descriptions
                    .XPathSelectElement(".//language")
                    .Add(entry);
            }

            if (cbx_curiotags.SelectedIndex != 0)
            {
                descriptions.XPathSelectElements(
                    ".//entry[@id = \"" +
                    "str_trigger_curio_quirk_" +
                    item +
                    "\"]").Remove();

                attr.Value = "trigger_curio_quirk_" + item;
                switch (cbx_curiotags.SelectedIndex)
                {
                    case 0: break;

                    case 1:

                        if (rtb_curiodialog1.Text.Length > 0)
                        {
                            s = rtb_curiodialog1.Text.Replace('\n', ' ');
                            while (s.Contains("  "))
                            {
                                s.Replace("  ", "");
                            }

                            data.Value = s;

                            dialogue
                                .XPathSelectElement(".//language")
                                .Add(entry);
                        }

                        if (rtb_curiodialog2.Text.Length > 0)
                        {
                            s = rtb_curiodialog2.Text.Replace('\n', ' ');
                            while (s.Contains("  "))
                            {
                                s.Replace("  ", "");
                            }

                            data.Value = s;

                            dialogue
                                .XPathSelectElement(".//language")
                                .Add(entry);
                        }

                        if (rtb_curiodialog3.Text.Length > 0)
                        {
                            s = rtb_curiodialog3.Text.Replace('\n', ' ');
                            while (s.Contains("  "))
                            {
                                s.Replace("  ", "");
                            }

                            data.Value = s;

                            dialogue
                                .XPathSelectElement(".//language")
                                .Add(entry);
                        }

                        break;

                    default:
                        s = rtb_curiodialog1.Text.Replace('\n', ' ');
                        while (s.Contains("  "))
                        {
                            s.Replace("  ", "");
                        }

                        data.Value = s;

                        dialogue
                            .XPathSelectElement(".//language")
                            .Add(entry);

                        break;
                }
            }

            SortQuirks(this, null);
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            tbx_quirkid.Text = "";
            tbx_class.Text = "physical";
            ch_showdesc.Checked = true;
            ch_positive.Checked = true;
            ch_disease.Checked = false;
            ch_keeploot.Checked = false;

            lbx_incompatible.Items.Clear();

            cbx_curiotags.SelectedIndex = 0;
            num_curiotagchance.Value = 0.0m;
            lbx_buffs.Items.Clear();

            rtb_description.Text =
                rtb_curiodialog1.Text =
                rtb_curiodialog2.Text =
                rtb_curiodialog3.Text = "";
        }

        private void lbx_incompatible_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                int index = lbx_incompatible.IndexFromPoint(
                    lbx_incompatible.PointToClient(new Point(e.X, e.Y)));

                string item = (string)e.Data.GetData(DataFormats.StringFormat);

                if (!lbx_incompatible.Items.Contains(item))
                {
                    if (index == -1)
                    {
                        lbx_incompatible.Items.Add(item);
                    }
                }

                lbx_incompatible.AllowDrop = false;
            }
        }

        private void lbx_incompatible_MouseDown(object sender, MouseEventArgs e)
        {
            if (lbx_incompatible.Items.Count == 0)
            {
                return;
            }

            int index = lbx_incompatible.IndexFromPoint(e.X, e.Y);

            if (index == -1)
            {
                return;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                lbx_incompatible.Items.RemoveAt(index);
            }
        }

        private void lbx_quirklist_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chb_editmode.Checked)
            {
                return;
            }

            if (lbx_quirklist.Items.Count == 0)
            {
                return;
            }

            int index = lbx_quirklist.IndexFromPoint(e.X, e.Y);
            string item = lbx_quirklist.Items[index].ToString();

            if (index == -1)
            {
                return;
            }

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                lbx_quirklist.SelectedIndex = index;
                RemoveQuirk(item);
                return;
            }

            lbx_incompatible.AllowDrop = true;
            lbx_buffs.AllowDrop = false;
            lbx_quirklist.DoDragDrop((string)item, DragDropEffects.All);
        }

        private void RemoveQuirk(string item)
        {
            if (MessageBox.Show("Really remove " + tbx_quirkid.Text + "?", 
                "Confirm", MessageBoxButtons.YesNo) ==
                System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            quirks.Remove(quirks.FirstOrDefault(
                x => x.id == item));

            descriptions.XPathSelectElement(
                ".//entry[@id = \"" +
                "str_quirk_name_" +
                item +
                "\"]").Remove();

            var desc = descriptions.XPathSelectElement(
                ".//entry[@id = \"" +
                "str_quirk_description_" +
                item +
                "\"]");

            if (desc != null)
            {
                descriptions.XPathSelectElement(
                ".//entry[@id = \"" +
                "str_quirk_description_" +
                item +
                "\"]").Remove();
            }

            var quotes = dialogue.XPathSelectElements(
                ".//entry[@id = \"" +
                "trigger_curio_quirk_" +
                item +
                "\"]");

            if (quotes != null)
            {
                dialogue.XPathSelectElements(
                ".//entry[@id = \"" +
                "trigger_curio_quirk_" +
                item +
                "\"]").Remove();
            }

            SortQuirks(this, null);
        }

        private void mainCheckBoxesChecked(object sender, EventArgs e)
        {
            if (!chb_editmode.Checked)
            {
                return;
            }

            ch_positive.Checked = !(ch_disease.Checked | ch_keeploot.Checked);
        }

        private void cbx_curiotags_SelectedIndexChanged(object sender, EventArgs e)
        {
            flp_quotes.Controls.Clear();
            switch (cbx_curiotags.SelectedIndex)
            {
                case 0: break;
                case 1:
                    flp_quotes.Controls.Add(rtb_curiodialog1);
                    flp_quotes.Controls.Add(rtb_curiodialog2);
                    flp_quotes.Controls.Add(rtb_curiodialog3);
                    break;
                default:
                    flp_quotes.Controls.Add(rtb_curiodialog1);
                    break;
            }
        }
    }

    public class Quirk
    {
        public string id;
        public bool show_explicit_description;
        public bool is_positive;
        public bool is_disease;
        public string classification;
        public string[] incompatible_quirks;
        public string curio_tag;
        public decimal curio_tag_chance;
        public bool keep_loot;
        public string[] buffs;

        public Quirk() { }
    }

    public class Buff
    {
        public string id;
        public string stat_type;
        public string stat_sub_type;
        public decimal amount;
        public string rule_type;
        public bool is_false_rule;
        public KeyValuePair<float, string> rule_data;

        public Buff() { }
    }

    public class JsonQuirkData
    {
        public Quirk[] quirks;
        public JsonQuirkData() { }
    }

    public class JsonBuffData
    {
        public Buff[] buffs;
        public JsonBuffData() { }
    }
}