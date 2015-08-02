namespace DarkestQuirks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbx_quirklist = new System.Windows.Forms.ListBox();
            this.cbx_curiotags = new System.Windows.Forms.ComboBox();
            this.lbx_incompatible = new System.Windows.Forms.ListBox();
            this.b_save = new System.Windows.Forms.Button();
            this.num_curiotagchance = new System.Windows.Forms.NumericUpDown();
            this.lb_buffroster = new System.Windows.Forms.Label();
            this.chb_editmode = new System.Windows.Forms.CheckBox();
            this.lbx_buffroster = new System.Windows.Forms.ListBox();
            this.tbx_class = new System.Windows.Forms.TextBox();
            this.lb_class = new System.Windows.Forms.Label();
            this.b_reset = new System.Windows.Forms.Button();
            this.b_addquirk = new System.Windows.Forms.Button();
            this.lbx_buffs = new System.Windows.Forms.ListBox();
            this.lb_buffs = new System.Windows.Forms.Label();
            this.lb_curiochance = new System.Windows.Forms.Label();
            this.lb_curiotag = new System.Windows.Forms.Label();
            this.lb_incompatible = new System.Windows.Forms.Label();
            this.ch_keeploot = new System.Windows.Forms.CheckBox();
            this.ch_disease = new System.Windows.Forms.CheckBox();
            this.ch_showdesc = new System.Windows.Forms.CheckBox();
            this.lb_quirkid = new System.Windows.Forms.Label();
            this.tbx_quirkid = new System.Windows.Forms.TextBox();
            this.tbx_curiochance = new System.Windows.Forms.TextBox();
            this.tooltip_id = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_class = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_show_explicit_desc = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_positive = new System.Windows.Forms.ToolTip(this.components);
            this.ch_positive = new System.Windows.Forms.CheckBox();
            this.ch_sortalphabetic = new System.Windows.Forms.CheckBox();
            this.ch_sortpositive = new System.Windows.Forms.CheckBox();
            this.tooltip_disease = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_buffs = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_warning = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_buffroster = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_incompatible = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_save = new System.Windows.Forms.ToolTip(this.components);
            this.lb_quirklist = new System.Windows.Forms.Label();
            this.tooltip_quirklist = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_quotes = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_curiotag = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_curiotagchance = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_keeploot = new System.Windows.Forms.ToolTip(this.components);
            this.tc_properties = new System.Windows.Forms.TabControl();
            this.tab_main = new System.Windows.Forms.TabPage();
            this.tab_text = new System.Windows.Forms.TabPage();
            this.lb_curiodialog = new System.Windows.Forms.Label();
            this.flp_quotes = new System.Windows.Forms.FlowLayoutPanel();
            this.rtb_curiodialog1 = new System.Windows.Forms.RichTextBox();
            this.rtb_curiodialog2 = new System.Windows.Forms.RichTextBox();
            this.rtb_curiodialog3 = new System.Windows.Forms.RichTextBox();
            this.rtb_description = new System.Windows.Forms.RichTextBox();
            this.ch_clear = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_curiotagchance)).BeginInit();
            this.tc_properties.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_text.SuspendLayout();
            this.flp_quotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_quirklist
            // 
            this.lbx_quirklist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_quirklist.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_quirklist.FormattingEnabled = true;
            this.lbx_quirklist.Location = new System.Drawing.Point(12, 32);
            this.lbx_quirklist.Name = "lbx_quirklist";
            this.lbx_quirklist.Size = new System.Drawing.Size(160, 418);
            this.lbx_quirklist.TabIndex = 0;
            // 
            // cbx_curiotags
            // 
            this.cbx_curiotags.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_curiotags.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_curiotags.Enabled = false;
            this.cbx_curiotags.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_curiotags.FormattingEnabled = true;
            this.cbx_curiotags.Location = new System.Drawing.Point(103, 116);
            this.cbx_curiotags.Name = "cbx_curiotags";
            this.cbx_curiotags.Size = new System.Drawing.Size(96, 21);
            this.cbx_curiotags.TabIndex = 28;
            // 
            // lbx_incompatible
            // 
            this.lbx_incompatible.BackColor = System.Drawing.SystemColors.Control;
            this.lbx_incompatible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_incompatible.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_incompatible.FormattingEnabled = true;
            this.lbx_incompatible.Location = new System.Drawing.Point(6, 52);
            this.lbx_incompatible.Name = "lbx_incompatible";
            this.lbx_incompatible.Size = new System.Drawing.Size(160, 80);
            this.lbx_incompatible.TabIndex = 27;
            // 
            // b_save
            // 
            this.b_save.AutoSize = true;
            this.b_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_save.Location = new System.Drawing.Point(425, 470);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 26;
            this.b_save.Text = "Save Quirks";
            this.tooltip_save.SetToolTip(this.b_save, "Save changes to file. Also creates backup\r\nof original.");
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.SaveData);
            // 
            // num_curiotagchance
            // 
            this.num_curiotagchance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_curiotagchance.DecimalPlaces = 1;
            this.num_curiotagchance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_curiotagchance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.num_curiotagchance.Location = new System.Drawing.Point(103, 144);
            this.num_curiotagchance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_curiotagchance.Name = "num_curiotagchance";
            this.num_curiotagchance.Size = new System.Drawing.Size(45, 20);
            this.num_curiotagchance.TabIndex = 25;
            this.num_curiotagchance.Visible = false;
            // 
            // lb_buffroster
            // 
            this.lb_buffroster.AutoSize = true;
            this.lb_buffroster.Location = new System.Drawing.Point(6, 208);
            this.lb_buffroster.Name = "lb_buffroster";
            this.lb_buffroster.Size = new System.Drawing.Size(55, 13);
            this.lb_buffroster.TabIndex = 21;
            this.lb_buffroster.Text = "Buff roster";
            this.tooltip_buffroster.SetToolTip(this.lb_buffroster, "A list of existing buffs. To add a buff,\r\ndrag one from the roster to the buff\r\nl" +
        "ist above.");
            // 
            // chb_editmode
            // 
            this.chb_editmode.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_editmode.AutoSize = true;
            this.chb_editmode.Location = new System.Drawing.Point(233, 470);
            this.chb_editmode.Name = "chb_editmode";
            this.chb_editmode.Size = new System.Drawing.Size(65, 23);
            this.chb_editmode.TabIndex = 20;
            this.chb_editmode.Text = "Edit Mode";
            this.chb_editmode.UseVisualStyleBackColor = true;
            this.chb_editmode.CheckedChanged += new System.EventHandler(this.chb_editmode_CheckedChanged);
            // 
            // lbx_buffroster
            // 
            this.lbx_buffroster.BackColor = System.Drawing.SystemColors.Control;
            this.lbx_buffroster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_buffroster.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_buffroster.FormattingEnabled = true;
            this.lbx_buffroster.Location = new System.Drawing.Point(6, 224);
            this.lbx_buffroster.Name = "lbx_buffroster";
            this.lbx_buffroster.Size = new System.Drawing.Size(302, 171);
            this.lbx_buffroster.TabIndex = 19;
            // 
            // tbx_class
            // 
            this.tbx_class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_class.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbx_class.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_class.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbx_class.Location = new System.Drawing.Point(210, 6);
            this.tbx_class.Name = "tbx_class";
            this.tbx_class.ReadOnly = true;
            this.tbx_class.Size = new System.Drawing.Size(98, 20);
            this.tbx_class.TabIndex = 18;
            this.tbx_class.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(172, 8);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(32, 13);
            this.lb_class.TabIndex = 17;
            this.lb_class.Text = "Class";
            this.tooltip_class.SetToolTip(this.lb_class, "Quirk classification, either Physical or Mental.\r\nIn Edit Mode, click to change.");
            // 
            // b_reset
            // 
            this.b_reset.AutoSize = true;
            this.b_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_reset.Enabled = false;
            this.b_reset.Location = new System.Drawing.Point(374, 470);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(45, 23);
            this.b_reset.TabIndex = 16;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_addquirk
            // 
            this.b_addquirk.AutoSize = true;
            this.b_addquirk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_addquirk.Enabled = false;
            this.b_addquirk.Location = new System.Drawing.Point(304, 470);
            this.b_addquirk.Name = "b_addquirk";
            this.b_addquirk.Size = new System.Drawing.Size(64, 23);
            this.b_addquirk.TabIndex = 15;
            this.b_addquirk.Text = "Add Quirk";
            this.b_addquirk.UseVisualStyleBackColor = true;
            this.b_addquirk.Click += new System.EventHandler(this.b_addquirk_Click);
            // 
            // lbx_buffs
            // 
            this.lbx_buffs.BackColor = System.Drawing.SystemColors.Control;
            this.lbx_buffs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_buffs.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_buffs.FormattingEnabled = true;
            this.lbx_buffs.Location = new System.Drawing.Point(6, 151);
            this.lbx_buffs.Name = "lbx_buffs";
            this.lbx_buffs.Size = new System.Drawing.Size(302, 54);
            this.lbx_buffs.TabIndex = 13;
            // 
            // lb_buffs
            // 
            this.lb_buffs.AutoSize = true;
            this.lb_buffs.Location = new System.Drawing.Point(6, 135);
            this.lb_buffs.Name = "lb_buffs";
            this.lb_buffs.Size = new System.Drawing.Size(31, 13);
            this.lb_buffs.TabIndex = 12;
            this.lb_buffs.Text = "Buffs";
            this.tooltip_buffs.SetToolTip(this.lb_buffs, "The buffs given to the hero.\r\nUp to four maximum. In Edit Mode, right\r\nclick to r" +
        "emove a buff.");
            // 
            // lb_curiochance
            // 
            this.lb_curiochance.AutoSize = true;
            this.lb_curiochance.Location = new System.Drawing.Point(6, 145);
            this.lb_curiochance.Name = "lb_curiochance";
            this.lb_curiochance.Size = new System.Drawing.Size(88, 13);
            this.lb_curiochance.TabIndex = 10;
            this.lb_curiochance.Text = "Curio tag chance";
            this.tooltip_curiotagchance.SetToolTip(this.lb_curiochance, resources.GetString("lb_curiochance.ToolTip"));
            // 
            // lb_curiotag
            // 
            this.lb_curiotag.AutoSize = true;
            this.lb_curiotag.Location = new System.Drawing.Point(6, 119);
            this.lb_curiotag.Name = "lb_curiotag";
            this.lb_curiotag.Size = new System.Drawing.Size(49, 13);
            this.lb_curiotag.TabIndex = 8;
            this.lb_curiotag.Text = "Curio tag";
            this.tooltip_curiotag.SetToolTip(this.lb_curiotag, "The type of curios that heroes will react to\r\non encounter. In Edit Mode, setting" +
        " this will\r\nforce you to create dialogue for this quirk.");
            // 
            // lb_incompatible
            // 
            this.lb_incompatible.AutoSize = true;
            this.lb_incompatible.Location = new System.Drawing.Point(6, 36);
            this.lb_incompatible.Name = "lb_incompatible";
            this.lb_incompatible.Size = new System.Drawing.Size(89, 13);
            this.lb_incompatible.TabIndex = 7;
            this.lb_incompatible.Text = "Incompatible with";
            this.tooltip_incompatible.SetToolTip(this.lb_incompatible, "Quirk is incompatible with 0~6 other quirks \r\nthat have opposite or contradicting" +
        " effects.\r\nExamples:\r\nhard_skinned /= soft\r\nenlightened /= alcoholism + gambler");
            // 
            // ch_keeploot
            // 
            this.ch_keeploot.AutoCheck = false;
            this.ch_keeploot.AutoSize = true;
            this.ch_keeploot.Location = new System.Drawing.Point(237, 98);
            this.ch_keeploot.Name = "ch_keeploot";
            this.ch_keeploot.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_keeploot.Size = new System.Drawing.Size(71, 17);
            this.ch_keeploot.TabIndex = 5;
            this.ch_keeploot.Text = "Keep loot";
            this.tooltip_disease.SetToolTip(this.ch_keeploot, "The hero approaches curios on his/her own\r\nand steals loot if there is any. Unche" +
        "cks\r\n\"Positive quirk\" if used.");
            this.ch_keeploot.UseVisualStyleBackColor = true;
            // 
            // ch_disease
            // 
            this.ch_disease.AutoCheck = false;
            this.ch_disease.AutoSize = true;
            this.ch_disease.Location = new System.Drawing.Point(244, 75);
            this.ch_disease.Name = "ch_disease";
            this.ch_disease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_disease.Size = new System.Drawing.Size(64, 17);
            this.ch_disease.TabIndex = 4;
            this.ch_disease.Text = "Disease";
            this.tooltip_disease.SetToolTip(this.ch_disease, "This quirk is a Disease and gives negative\r\neffects. Unchecks \"Positive quirk\" if" +
        " used.");
            this.ch_disease.UseVisualStyleBackColor = true;
            // 
            // ch_showdesc
            // 
            this.ch_showdesc.AutoCheck = false;
            this.ch_showdesc.AutoSize = true;
            this.ch_showdesc.Location = new System.Drawing.Point(6, 38);
            this.ch_showdesc.Name = "ch_showdesc";
            this.ch_showdesc.Size = new System.Drawing.Size(142, 17);
            this.ch_showdesc.TabIndex = 2;
            this.ch_showdesc.Text = "Show explicit description";
            this.tooltip_show_explicit_desc.SetToolTip(this.ch_showdesc, "If checked, the game shows the effects\r\nof given buffs:\r\nNatural Eye\r\n\"+5 ACC\"\r\n\r" +
        "\nIf unchecked, the game shows a special\r\ndescription in which you must create:\r\n" +
        "Tippler\r\n\"In town, will only Drink.\"\r\n");
            this.ch_showdesc.UseVisualStyleBackColor = true;
            // 
            // lb_quirkid
            // 
            this.lb_quirkid.AutoSize = true;
            this.lb_quirkid.Location = new System.Drawing.Point(6, 8);
            this.lb_quirkid.Name = "lb_quirkid";
            this.lb_quirkid.Size = new System.Drawing.Size(15, 13);
            this.lb_quirkid.TabIndex = 1;
            this.lb_quirkid.Text = "id";
            this.tooltip_id.SetToolTip(this.lb_quirkid, "The name of the quirk, capitalized, and\r\nseperated by single spaces. No numbers\r\n" +
        "or punctuation allowed.");
            // 
            // tbx_quirkid
            // 
            this.tbx_quirkid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_quirkid.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_quirkid.Location = new System.Drawing.Point(28, 6);
            this.tbx_quirkid.MaxLength = 20;
            this.tbx_quirkid.Name = "tbx_quirkid";
            this.tbx_quirkid.ReadOnly = true;
            this.tbx_quirkid.Size = new System.Drawing.Size(138, 20);
            this.tbx_quirkid.TabIndex = 0;
            this.tbx_quirkid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_curiochance
            // 
            this.tbx_curiochance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_curiochance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_curiochance.Location = new System.Drawing.Point(103, 144);
            this.tbx_curiochance.Name = "tbx_curiochance";
            this.tbx_curiochance.ReadOnly = true;
            this.tbx_curiochance.Size = new System.Drawing.Size(45, 20);
            this.tbx_curiochance.TabIndex = 11;
            // 
            // tooltip_show_explicit_desc
            // 
            this.tooltip_show_explicit_desc.AutoPopDelay = 12000;
            this.tooltip_show_explicit_desc.InitialDelay = 500;
            this.tooltip_show_explicit_desc.ReshowDelay = 100;
            // 
            // tooltip_positive
            // 
            this.tooltip_positive.AutoPopDelay = 5000;
            this.tooltip_positive.InitialDelay = 500;
            this.tooltip_positive.ReshowDelay = 100;
            // 
            // ch_positive
            // 
            this.ch_positive.AutoCheck = false;
            this.ch_positive.AutoSize = true;
            this.ch_positive.Location = new System.Drawing.Point(219, 52);
            this.ch_positive.Name = "ch_positive";
            this.ch_positive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_positive.Size = new System.Drawing.Size(89, 17);
            this.ch_positive.TabIndex = 28;
            this.ch_positive.Text = "Positive quirk";
            this.tooltip_positive.SetToolTip(this.ch_positive, "The quirk gives positive effects.");
            this.ch_positive.UseVisualStyleBackColor = true;
            // 
            // ch_sortalphabetic
            // 
            this.ch_sortalphabetic.AutoSize = true;
            this.ch_sortalphabetic.Checked = true;
            this.ch_sortalphabetic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ch_sortalphabetic.Location = new System.Drawing.Point(12, 456);
            this.ch_sortalphabetic.Name = "ch_sortalphabetic";
            this.ch_sortalphabetic.Size = new System.Drawing.Size(112, 17);
            this.ch_sortalphabetic.TabIndex = 2;
            this.ch_sortalphabetic.Text = "Sort alphabetically";
            this.ch_sortalphabetic.UseVisualStyleBackColor = true;
            // 
            // ch_sortpositive
            // 
            this.ch_sortpositive.AutoSize = true;
            this.ch_sortpositive.Location = new System.Drawing.Point(12, 479);
            this.ch_sortpositive.Name = "ch_sortpositive";
            this.ch_sortpositive.Size = new System.Drawing.Size(98, 17);
            this.ch_sortpositive.TabIndex = 3;
            this.ch_sortpositive.Text = "Sort by positive";
            this.ch_sortpositive.UseVisualStyleBackColor = true;
            // 
            // tooltip_buffs
            // 
            this.tooltip_buffs.AutoPopDelay = 6000;
            this.tooltip_buffs.InitialDelay = 500;
            this.tooltip_buffs.ReshowDelay = 100;
            // 
            // tooltip_warning
            // 
            this.tooltip_warning.AutomaticDelay = 0;
            this.tooltip_warning.AutoPopDelay = 3000;
            this.tooltip_warning.ForeColor = System.Drawing.Color.Red;
            this.tooltip_warning.InitialDelay = 0;
            this.tooltip_warning.ReshowDelay = 0;
            this.tooltip_warning.UseAnimation = false;
            // 
            // tooltip_buffroster
            // 
            this.tooltip_buffroster.AutoPopDelay = 6000;
            this.tooltip_buffroster.InitialDelay = 500;
            this.tooltip_buffroster.ReshowDelay = 100;
            // 
            // tooltip_incompatible
            // 
            this.tooltip_incompatible.AutoPopDelay = 11500;
            this.tooltip_incompatible.InitialDelay = 500;
            this.tooltip_incompatible.ReshowDelay = 100;
            // 
            // lb_quirklist
            // 
            this.lb_quirklist.AutoSize = true;
            this.lb_quirklist.Location = new System.Drawing.Point(12, 13);
            this.lb_quirklist.Name = "lb_quirklist";
            this.lb_quirklist.Size = new System.Drawing.Size(51, 13);
            this.lb_quirklist.TabIndex = 4;
            this.lb_quirklist.Text = "Quirk List";
            this.tooltip_quirklist.SetToolTip(this.lb_quirklist, "Shows a list of available quirks including\r\nthose from mods. In Edit Mode, you ca" +
        "n \r\ndrag an existing quirk into the incompatibity \r\npanel and right click to rem" +
        "ove quirks.");
            // 
            // tooltip_quirklist
            // 
            this.tooltip_quirklist.AutoPopDelay = 9500;
            this.tooltip_quirklist.InitialDelay = 500;
            this.tooltip_quirklist.ReshowDelay = 100;
            // 
            // tooltip_curiotag
            // 
            this.tooltip_curiotag.AutoPopDelay = 7500;
            this.tooltip_curiotag.InitialDelay = 500;
            this.tooltip_curiotag.ReshowDelay = 100;
            // 
            // tooltip_curiotagchance
            // 
            this.tooltip_curiotagchance.AutoPopDelay = 16500;
            this.tooltip_curiotagchance.InitialDelay = 500;
            this.tooltip_curiotagchance.ReshowDelay = 100;
            // 
            // tooltip_keeploot
            // 
            this.tooltip_keeploot.AutoPopDelay = 6000;
            this.tooltip_keeploot.InitialDelay = 500;
            this.tooltip_keeploot.ReshowDelay = 100;
            // 
            // tc_properties
            // 
            this.tc_properties.Controls.Add(this.tab_main);
            this.tc_properties.Controls.Add(this.tab_text);
            this.tc_properties.Location = new System.Drawing.Point(178, 12);
            this.tc_properties.Name = "tc_properties";
            this.tc_properties.SelectedIndex = 0;
            this.tc_properties.Size = new System.Drawing.Size(322, 438);
            this.tc_properties.TabIndex = 5;
            // 
            // tab_main
            // 
            this.tab_main.BackColor = System.Drawing.Color.White;
            this.tab_main.Controls.Add(this.ch_positive);
            this.tab_main.Controls.Add(this.lb_quirkid);
            this.tab_main.Controls.Add(this.lbx_incompatible);
            this.tab_main.Controls.Add(this.tbx_quirkid);
            this.tab_main.Controls.Add(this.lb_buffroster);
            this.tab_main.Controls.Add(this.lbx_buffroster);
            this.tab_main.Controls.Add(this.ch_disease);
            this.tab_main.Controls.Add(this.tbx_class);
            this.tab_main.Controls.Add(this.ch_keeploot);
            this.tab_main.Controls.Add(this.lb_class);
            this.tab_main.Controls.Add(this.lb_incompatible);
            this.tab_main.Controls.Add(this.lbx_buffs);
            this.tab_main.Controls.Add(this.lb_buffs);
            this.tab_main.Location = new System.Drawing.Point(4, 22);
            this.tab_main.Name = "tab_main";
            this.tab_main.Padding = new System.Windows.Forms.Padding(3);
            this.tab_main.Size = new System.Drawing.Size(314, 412);
            this.tab_main.TabIndex = 0;
            this.tab_main.Text = "Main";
            // 
            // tab_text
            // 
            this.tab_text.Controls.Add(this.lb_curiodialog);
            this.tab_text.Controls.Add(this.flp_quotes);
            this.tab_text.Controls.Add(this.rtb_description);
            this.tab_text.Controls.Add(this.ch_showdesc);
            this.tab_text.Controls.Add(this.num_curiotagchance);
            this.tab_text.Controls.Add(this.tbx_curiochance);
            this.tab_text.Controls.Add(this.cbx_curiotags);
            this.tab_text.Controls.Add(this.lb_curiochance);
            this.tab_text.Controls.Add(this.lb_curiotag);
            this.tab_text.Location = new System.Drawing.Point(4, 22);
            this.tab_text.Name = "tab_text";
            this.tab_text.Padding = new System.Windows.Forms.Padding(3);
            this.tab_text.Size = new System.Drawing.Size(314, 412);
            this.tab_text.TabIndex = 1;
            this.tab_text.Text = "Text";
            this.tab_text.UseVisualStyleBackColor = true;
            // 
            // lb_curiodialog
            // 
            this.lb_curiodialog.AutoSize = true;
            this.lb_curiodialog.Location = new System.Drawing.Point(6, 181);
            this.lb_curiodialog.Name = "lb_curiodialog";
            this.lb_curiodialog.Size = new System.Drawing.Size(74, 13);
            this.lb_curiodialog.TabIndex = 35;
            this.lb_curiodialog.Text = "Curio dialogue";
            // 
            // flp_quotes
            // 
            this.flp_quotes.BackColor = System.Drawing.SystemColors.Control;
            this.flp_quotes.Controls.Add(this.rtb_curiodialog1);
            this.flp_quotes.Controls.Add(this.rtb_curiodialog2);
            this.flp_quotes.Controls.Add(this.rtb_curiodialog3);
            this.flp_quotes.Location = new System.Drawing.Point(6, 197);
            this.flp_quotes.Name = "flp_quotes";
            this.flp_quotes.Size = new System.Drawing.Size(302, 209);
            this.flp_quotes.TabIndex = 34;
            // 
            // rtb_curiodialog1
            // 
            this.rtb_curiodialog1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_curiodialog1.Location = new System.Drawing.Point(3, 3);
            this.rtb_curiodialog1.MaxLength = 64;
            this.rtb_curiodialog1.Name = "rtb_curiodialog1";
            this.rtb_curiodialog1.ReadOnly = true;
            this.rtb_curiodialog1.Size = new System.Drawing.Size(293, 38);
            this.rtb_curiodialog1.TabIndex = 31;
            this.rtb_curiodialog1.Text = "";
            // 
            // rtb_curiodialog2
            // 
            this.rtb_curiodialog2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_curiodialog2.Location = new System.Drawing.Point(3, 47);
            this.rtb_curiodialog2.MaxLength = 64;
            this.rtb_curiodialog2.Name = "rtb_curiodialog2";
            this.rtb_curiodialog2.ReadOnly = true;
            this.rtb_curiodialog2.Size = new System.Drawing.Size(293, 38);
            this.rtb_curiodialog2.TabIndex = 32;
            this.rtb_curiodialog2.Text = "";
            // 
            // rtb_curiodialog3
            // 
            this.rtb_curiodialog3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_curiodialog3.Location = new System.Drawing.Point(3, 91);
            this.rtb_curiodialog3.MaxLength = 64;
            this.rtb_curiodialog3.Name = "rtb_curiodialog3";
            this.rtb_curiodialog3.ReadOnly = true;
            this.rtb_curiodialog3.Size = new System.Drawing.Size(293, 38);
            this.rtb_curiodialog3.TabIndex = 33;
            this.rtb_curiodialog3.Text = "";
            // 
            // rtb_description
            // 
            this.rtb_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_description.Location = new System.Drawing.Point(6, 56);
            this.rtb_description.MaxLength = 64;
            this.rtb_description.Name = "rtb_description";
            this.rtb_description.ReadOnly = true;
            this.rtb_description.Size = new System.Drawing.Size(302, 38);
            this.rtb_description.TabIndex = 30;
            this.rtb_description.Text = "";
            // 
            // ch_clear
            // 
            this.ch_clear.AutoSize = true;
            this.ch_clear.Location = new System.Drawing.Point(319, 9);
            this.ch_clear.Name = "ch_clear";
            this.ch_clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_clear.Size = new System.Drawing.Size(181, 17);
            this.ch_clear.TabIndex = 27;
            this.ch_clear.Text = "Clear controls when in Edit Mode";
            this.ch_clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 505);
            this.Controls.Add(this.ch_clear);
            this.Controls.Add(this.tc_properties);
            this.Controls.Add(this.lb_quirklist);
            this.Controls.Add(this.ch_sortpositive);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.ch_sortalphabetic);
            this.Controls.Add(this.chb_editmode);
            this.Controls.Add(this.lbx_quirklist);
            this.Controls.Add(this.b_addquirk);
            this.Controls.Add(this.b_reset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(528, 624);
            this.MinimumSize = new System.Drawing.Size(528, 500);
            this.Name = "Form1";
            this.Text = "Darkest Quirks v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.num_curiotagchance)).EndInit();
            this.tc_properties.ResumeLayout(false);
            this.tab_main.ResumeLayout(false);
            this.tab_main.PerformLayout();
            this.tab_text.ResumeLayout(false);
            this.tab_text.PerformLayout();
            this.flp_quotes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_quirklist;
        private System.Windows.Forms.TextBox tbx_quirkid;
        private System.Windows.Forms.Label lb_quirkid;
        private System.Windows.Forms.CheckBox ch_disease;
        private System.Windows.Forms.CheckBox ch_showdesc;
        private System.Windows.Forms.CheckBox ch_keeploot;
        private System.Windows.Forms.Label lb_incompatible;
        private System.Windows.Forms.Label lb_curiotag;
        private System.Windows.Forms.Label lb_curiochance;
        private System.Windows.Forms.TextBox tbx_curiochance;
        private System.Windows.Forms.Label lb_buffs;
        private System.Windows.Forms.ListBox lbx_buffs;
        private System.Windows.Forms.Button b_addquirk;
        private System.Windows.Forms.Button b_reset;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.TextBox tbx_class;
        private System.Windows.Forms.ToolTip tooltip_id;
        private System.Windows.Forms.ToolTip tooltip_class;
        private System.Windows.Forms.ToolTip tooltip_show_explicit_desc;
        private System.Windows.Forms.ToolTip tooltip_positive;
        private System.Windows.Forms.CheckBox ch_sortalphabetic;
        private System.Windows.Forms.CheckBox ch_sortpositive;
        private System.Windows.Forms.ToolTip tooltip_disease;
        private System.Windows.Forms.ListBox lbx_buffroster;
        private System.Windows.Forms.CheckBox chb_editmode;
        private System.Windows.Forms.Label lb_buffroster;
        private System.Windows.Forms.ToolTip tooltip_buffs;
        private System.Windows.Forms.ToolTip tooltip_warning;
        private System.Windows.Forms.NumericUpDown num_curiotagchance;
        private System.Windows.Forms.ToolTip tooltip_buffroster;
        private System.Windows.Forms.ToolTip tooltip_incompatible;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.ToolTip tooltip_save;
        private System.Windows.Forms.ListBox lbx_incompatible;
        private System.Windows.Forms.Label lb_quirklist;
        private System.Windows.Forms.ToolTip tooltip_quirklist;
        private System.Windows.Forms.ToolTip tooltip_quotes;
        private System.Windows.Forms.ToolTip tooltip_curiotag;
        private System.Windows.Forms.ToolTip tooltip_curiotagchance;
        private System.Windows.Forms.ComboBox cbx_curiotags;
        private System.Windows.Forms.ToolTip tooltip_keeploot;
        private System.Windows.Forms.TabControl tc_properties;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_text;
        private System.Windows.Forms.CheckBox ch_positive;
        private System.Windows.Forms.RichTextBox rtb_description;
        private System.Windows.Forms.RichTextBox rtb_curiodialog3;
        private System.Windows.Forms.RichTextBox rtb_curiodialog2;
        private System.Windows.Forms.RichTextBox rtb_curiodialog1;
        private System.Windows.Forms.FlowLayoutPanel flp_quotes;
        private System.Windows.Forms.Label lb_curiodialog;
        private System.Windows.Forms.CheckBox ch_clear;
    }
}

