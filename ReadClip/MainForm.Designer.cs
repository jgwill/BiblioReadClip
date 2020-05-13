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
            this.textToSynthesize__textBox = new System.Windows.Forms.TextBox();
            this.pasteNRead__button = new System.Windows.Forms.Button();
            this.citeFull__textBox = new System.Windows.Forms.TextBox();
            this.cite__textBox = new System.Windows.Forms.TextBox();
            this.cite__button = new System.Windows.Forms.Button();
            this.citeSource__comboBox = new System.Windows.Forms.ComboBox();
            this.biblioCslBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.biblioCslBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // readText_button
            // 
            this.readText_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readText_button.Location = new System.Drawing.Point(618, 110);
            this.readText_button.Name = "readText_button";
            this.readText_button.Size = new System.Drawing.Size(358, 95);
            this.readText_button.TabIndex = 0;
            this.readText_button.Text = "Read";
            this.readText_button.UseVisualStyleBackColor = true;
            this.readText_button.Click += new System.EventHandler(this.test_Synt_button_Click);
            // 
            // textToSynthesize__textBox
            // 
            this.textToSynthesize__textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textToSynthesize__textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToSynthesize__textBox.Location = new System.Drawing.Point(1, 12);
            this.textToSynthesize__textBox.Multiline = true;
            this.textToSynthesize__textBox.Name = "textToSynthesize__textBox";
            this.textToSynthesize__textBox.Size = new System.Drawing.Size(596, 602);
            this.textToSynthesize__textBox.TabIndex = 1;
            this.textToSynthesize__textBox.Text = "This is a sample text that will be read";
            // 
            // pasteNRead__button
            // 
            this.pasteNRead__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteNRead__button.Location = new System.Drawing.Point(618, 12);
            this.pasteNRead__button.Name = "pasteNRead__button";
            this.pasteNRead__button.Size = new System.Drawing.Size(358, 83);
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
            this.citeFull__textBox.Location = new System.Drawing.Point(618, 432);
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
            this.cite__textBox.Location = new System.Drawing.Point(618, 387);
            this.cite__textBox.Multiline = true;
            this.cite__textBox.Name = "cite__textBox";
            this.cite__textBox.Size = new System.Drawing.Size(358, 39);
            this.cite__textBox.TabIndex = 3;
            this.cite__textBox.TextChanged += new System.EventHandler(this.cite__textBox_TextChanged);
            // 
            // cite__button
            // 
            this.cite__button.Location = new System.Drawing.Point(733, 234);
            this.cite__button.Name = "cite__button";
            this.cite__button.Size = new System.Drawing.Size(243, 59);
            this.cite__button.TabIndex = 4;
            this.cite__button.Text = "Cite";
            this.cite__button.UseVisualStyleBackColor = true;
            // 
            // citeSource__comboBox
            // 
            this.citeSource__comboBox.DataSource = this.biblioCslBindingSource;
            this.citeSource__comboBox.FormattingEnabled = true;
            this.citeSource__comboBox.Location = new System.Drawing.Point(618, 336);
            this.citeSource__comboBox.Name = "citeSource__comboBox";
            this.citeSource__comboBox.Size = new System.Drawing.Size(358, 33);
            this.citeSource__comboBox.TabIndex = 5;
            // 
            // biblioCslBindingSource
            // 
            this.biblioCslBindingSource.DataSource = typeof(ReadClip.BiblioCsl);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 605);
            this.Controls.Add(this.citeSource__comboBox);
            this.Controls.Add(this.cite__button);
            this.Controls.Add(this.cite__textBox);
            this.Controls.Add(this.citeFull__textBox);
            this.Controls.Add(this.pasteNRead__button);
            this.Controls.Add(this.textToSynthesize__textBox);
            this.Controls.Add(this.readText_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Synthesizer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioCslBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readText_button;
        private System.Windows.Forms.TextBox textToSynthesize__textBox;
        private System.Windows.Forms.Button pasteNRead__button;
        private System.Windows.Forms.TextBox citeFull__textBox;
        private System.Windows.Forms.TextBox cite__textBox;
        private System.Windows.Forms.Button cite__button;
        private System.Windows.Forms.ComboBox citeSource__comboBox;
        private System.Windows.Forms.BindingSource biblioCslBindingSource;
    }
}

