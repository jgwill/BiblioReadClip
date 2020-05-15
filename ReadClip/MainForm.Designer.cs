namespace ReadClip
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.readText_button = new System.Windows.Forms.Button();
            this.pasteNRead__button = new System.Windows.Forms.Button();
            this.citeFull__textBox = new System.Windows.Forms.TextBox();
            this.cite__textBox = new System.Windows.Forms.TextBox();
            this.cite__button = new System.Windows.Forms.Button();
            this.citeSource__comboBox = new System.Windows.Forms.ComboBox();
            this.biblioCslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.copy__button = new System.Windows.Forms.Button();
            this.citeNCopy__button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textToSynthesize__textBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stop__toolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.biblioCslBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readText_button
            // 
            this.readText_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readText_button.Location = new System.Drawing.Point(118, 121);
            this.readText_button.Name = "readText_button";
            this.readText_button.Size = new System.Drawing.Size(210, 48);
            this.readText_button.TabIndex = 0;
            this.readText_button.Text = "Read";
            this.readText_button.UseVisualStyleBackColor = true;
            this.readText_button.Click += new System.EventHandler(this.test_Synt_button_Click);
            // 
            // pasteNRead__button
            // 
            this.pasteNRead__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteNRead__button.Location = new System.Drawing.Point(3, 39);
            this.pasteNRead__button.Name = "pasteNRead__button";
            this.pasteNRead__button.Size = new System.Drawing.Size(325, 76);
            this.pasteNRead__button.TabIndex = 2;
            this.pasteNRead__button.Text = "Paste and Read";
            this.pasteNRead__button.UseVisualStyleBackColor = true;
            this.pasteNRead__button.Click += new System.EventHandler(this.pasteNRead__button_Click);
            // 
            // citeFull__textBox
            // 
            this.citeFull__textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Xing, B., & Marwala, T. (2018). Creativity and Artificial Intelligence: A Digital" +
                " Art Perspective. https://arxiv.org/abs/1807.08195v1",
            resources.GetString("citeFull__textBox.AutoCompleteCustomSource"),
            "Ezratty, O. (n.d.). Les usages de l’intelligence artificielle. 522.",
            "Whitelaw, M. (n.d.). Metacreation: Art and Artificial Life.",
            "Miller, A. I. (2019). The Artist in the Machine: The World of AI-Powered Creativi" +
                "ty. MIT Press. http://international.scholarvox.com/book/88874178"});
            this.citeFull__textBox.Location = new System.Drawing.Point(1323, 436);
            this.citeFull__textBox.Multiline = true;
            this.citeFull__textBox.Name = "citeFull__textBox";
            this.citeFull__textBox.Size = new System.Drawing.Size(358, 72);
            this.citeFull__textBox.TabIndex = 3;
            // 
            // cite__textBox
            // 
            this.cite__textBox.AutoCompleteCustomSource.AddRange(new string[] {
            "(Whitelaw, n.d.)",
            "(Miller, 2019)",
            "(Ezratty, n.d.)",
            "(Wiener, 1971)",
            "(Xing & Marwala, 2018)"});
            this.cite__textBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cite__textBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cite__textBox.Location = new System.Drawing.Point(1323, 391);
            this.cite__textBox.Multiline = true;
            this.cite__textBox.Name = "cite__textBox";
            this.cite__textBox.Size = new System.Drawing.Size(358, 39);
            this.cite__textBox.TabIndex = 3;
            this.cite__textBox.TextChanged += new System.EventHandler(this.cite__textBox_TextChanged);
            // 
            // cite__button
            // 
            this.cite__button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cite__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cite__button.Location = new System.Drawing.Point(347, 39);
            this.cite__button.Name = "cite__button";
            this.cite__button.Size = new System.Drawing.Size(300, 76);
            this.cite__button.TabIndex = 4;
            this.cite__button.Text = "Cite";
            this.cite__button.UseVisualStyleBackColor = false;
            this.cite__button.Click += new System.EventHandler(this.cite__button_Click);
            // 
            // citeSource__comboBox
            // 
            this.citeSource__comboBox.DataSource = this.biblioCslBindingSource;
            this.citeSource__comboBox.DisplayMember = "Title";
            this.citeSource__comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citeSource__comboBox.FormattingEnabled = true;
            this.citeSource__comboBox.Location = new System.Drawing.Point(1, 3);
            this.citeSource__comboBox.Name = "citeSource__comboBox";
            this.citeSource__comboBox.Size = new System.Drawing.Size(1085, 39);
            this.citeSource__comboBox.TabIndex = 5;
            this.citeSource__comboBox.SelectedIndexChanged += new System.EventHandler(this.citeSource__comboBox_SelectedIndexChanged);
            // 
            // biblioCslBindingSource
            // 
            this.biblioCslBindingSource.DataSource = typeof(ReadClip.BiblioCsl);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.copy__button);
            this.splitContainer1.Panel1.Controls.Add(this.citeSource__comboBox);
            this.splitContainer1.Panel1.Controls.Add(this.citeNCopy__button);
            this.splitContainer1.Panel1.Controls.Add(this.cite__button);
            this.splitContainer1.Panel1.Controls.Add(this.readText_button);
            this.splitContainer1.Panel1.Controls.Add(this.pasteNRead__button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1098, 814);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 6;
            // 
            // copy__button
            // 
            this.copy__button.BackColor = System.Drawing.Color.YellowGreen;
            this.copy__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy__button.Location = new System.Drawing.Point(347, 110);
            this.copy__button.Name = "copy__button";
            this.copy__button.Size = new System.Drawing.Size(300, 59);
            this.copy__button.TabIndex = 6;
            this.copy__button.Text = "Copy";
            this.copy__button.UseVisualStyleBackColor = false;
            this.copy__button.Click += new System.EventHandler(this.copy__button_Click);
            // 
            // citeNCopy__button
            // 
            this.citeNCopy__button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.citeNCopy__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citeNCopy__button.Location = new System.Drawing.Point(644, 39);
            this.citeNCopy__button.Name = "citeNCopy__button";
            this.citeNCopy__button.Size = new System.Drawing.Size(300, 130);
            this.citeNCopy__button.TabIndex = 4;
            this.citeNCopy__button.Text = "Cite and Copy";
            this.citeNCopy__button.UseVisualStyleBackColor = false;
            this.citeNCopy__button.Click += new System.EventHandler(this.citeNCopy__button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 630);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textToSynthesize__textBox);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Context";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textToSynthesize__textBox
            // 
            this.textToSynthesize__textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textToSynthesize__textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToSynthesize__textBox.Location = new System.Drawing.Point(3, 3);
            this.textToSynthesize__textBox.Name = "textToSynthesize__textBox";
            this.textToSynthesize__textBox.Size = new System.Drawing.Size(1076, 577);
            this.textToSynthesize__textBox.TabIndex = 0;
            this.textToSynthesize__textBox.Text = "This is a sample text";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.consoleText);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Console";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // consoleText
            // 
            this.consoleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleText.Location = new System.Drawing.Point(3, 3);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(1076, 240);
            this.consoleText.TabIndex = 0;
            this.consoleText.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 856);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 42);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _status
            // 
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(85, 32);
            this._status.Text = "-------";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stop__toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1098, 42);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // stop__toolStripButton
            // 
            this.stop__toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stop__toolStripButton.Image = global::ReadClip.Properties.Resources.Add_inverse_16x;
            this.stop__toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop__toolStripButton.Name = "stop__toolStripButton";
            this.stop__toolStripButton.Size = new System.Drawing.Size(46, 36);
            this.stop__toolStripButton.Text = "Stop reading";
            this.stop__toolStripButton.Click += new System.EventHandler(this.stop__toolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 898);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.cite__textBox);
            this.Controls.Add(this.citeFull__textBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Synthesizer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioCslBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readText_button;
        private System.Windows.Forms.Button pasteNRead__button;
        private System.Windows.Forms.TextBox citeFull__textBox;
        private System.Windows.Forms.TextBox cite__textBox;
        private System.Windows.Forms.Button cite__button;
        private System.Windows.Forms.ComboBox citeSource__comboBox;
        private System.Windows.Forms.BindingSource biblioCslBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox consoleText;
        private System.Windows.Forms.RichTextBox textToSynthesize__textBox;
        private System.Windows.Forms.Button copy__button;
        private System.Windows.Forms.Button citeNCopy__button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _status;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stop__toolStripButton;
    }
}

