namespace E17_Font_Fix
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
            this.textboxFontName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonApplyRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkboxSkipSpeed = new System.Windows.Forms.CheckBox();
            this.checkboxMusicFix = new System.Windows.Forms.CheckBox();
            this.checkboxFontFix = new System.Windows.Forms.CheckBox();
            this.textboxW1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxH1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxH6 = new System.Windows.Forms.TextBox();
            this.textboxW6 = new System.Windows.Forms.TextBox();
            this.textboxH5 = new System.Windows.Forms.TextBox();
            this.textboxW5 = new System.Windows.Forms.TextBox();
            this.textboxHW4 = new System.Windows.Forms.TextBox();
            this.textboxH3 = new System.Windows.Forms.TextBox();
            this.textboxW3 = new System.Windows.Forms.TextBox();
            this.textboxH2 = new System.Windows.Forms.TextBox();
            this.textboxW2 = new System.Windows.Forms.TextBox();
            this.checkboxRightclickMenu = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxFontName
            // 
            this.textboxFontName.Location = new System.Drawing.Point(79, 21);
            this.textboxFontName.Name = "textboxFontName";
            this.textboxFontName.Size = new System.Drawing.Size(189, 20);
            this.textboxFontName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Name";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(8, 372);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(118, 49);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply Fixes";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonApplyRun
            // 
            this.buttonApplyRun.Location = new System.Drawing.Point(135, 372);
            this.buttonApplyRun.Name = "buttonApplyRun";
            this.buttonApplyRun.Size = new System.Drawing.Size(133, 49);
            this.buttonApplyRun.TabIndex = 3;
            this.buttonApplyRun.Text = "Apply fixes and run ever17PC_us.exe";
            this.buttonApplyRun.UseVisualStyleBackColor = true;
            this.buttonApplyRun.Click += new System.EventHandler(this.buttonApplyRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkboxRightclickMenu);
            this.groupBox1.Controls.Add(this.checkboxSkipSpeed);
            this.groupBox1.Controls.Add(this.checkboxMusicFix);
            this.groupBox1.Controls.Add(this.checkboxFontFix);
            this.groupBox1.Location = new System.Drawing.Point(8, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patches";
            // 
            // checkboxSkipSpeed
            // 
            this.checkboxSkipSpeed.AutoSize = true;
            this.checkboxSkipSpeed.Checked = true;
            this.checkboxSkipSpeed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxSkipSpeed.Location = new System.Drawing.Point(7, 66);
            this.checkboxSkipSpeed.Name = "checkboxSkipSpeed";
            this.checkboxSkipSpeed.Size = new System.Drawing.Size(224, 17);
            this.checkboxSkipSpeed.TabIndex = 2;
            this.checkboxSkipSpeed.Text = "Increase skip speed (may cause crashing)";
            this.checkboxSkipSpeed.UseVisualStyleBackColor = true;
            // 
            // checkboxMusicFix
            // 
            this.checkboxMusicFix.AutoSize = true;
            this.checkboxMusicFix.Checked = true;
            this.checkboxMusicFix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxMusicFix.Location = new System.Drawing.Point(7, 43);
            this.checkboxMusicFix.Name = "checkboxMusicFix";
            this.checkboxMusicFix.Size = new System.Drawing.Size(249, 17);
            this.checkboxMusicFix.TabIndex = 1;
            this.checkboxMusicFix.Text = "Prevent music from reseting if game loses focus";
            this.checkboxMusicFix.UseVisualStyleBackColor = true;
            // 
            // checkboxFontFix
            // 
            this.checkboxFontFix.AutoSize = true;
            this.checkboxFontFix.Checked = true;
            this.checkboxFontFix.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxFontFix.Location = new System.Drawing.Point(7, 20);
            this.checkboxFontFix.Name = "checkboxFontFix";
            this.checkboxFontFix.Size = new System.Drawing.Size(111, 17);
            this.checkboxFontFix.TabIndex = 0;
            this.checkboxFontFix.Text = "Use arbitrary fonts";
            this.checkboxFontFix.UseVisualStyleBackColor = true;
            // 
            // textboxW1
            // 
            this.textboxW1.Location = new System.Drawing.Point(116, 31);
            this.textboxW1.MaxLength = 3;
            this.textboxW1.Name = "textboxW1";
            this.textboxW1.Size = new System.Drawing.Size(62, 20);
            this.textboxW1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Height";
            // 
            // textboxH1
            // 
            this.textboxH1.Location = new System.Drawing.Point(184, 31);
            this.textboxH1.MaxLength = 3;
            this.textboxH1.Name = "textboxH1";
            this.textboxH1.Size = new System.Drawing.Size(62, 20);
            this.textboxH1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Main";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textboxH6);
            this.groupBox2.Controls.Add(this.textboxW6);
            this.groupBox2.Controls.Add(this.textboxH5);
            this.groupBox2.Controls.Add(this.textboxW5);
            this.groupBox2.Controls.Add(this.textboxHW4);
            this.groupBox2.Controls.Add(this.textboxH3);
            this.groupBox2.Controls.Add(this.textboxW3);
            this.groupBox2.Controls.Add(this.textboxH2);
            this.groupBox2.Controls.Add(this.textboxW2);
            this.groupBox2.Controls.Add(this.textboxH1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textboxW1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 189);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font sizes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Popup: Save data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Save/Load Menus";
            // 
            // textboxH6
            // 
            this.textboxH6.Location = new System.Drawing.Point(184, 161);
            this.textboxH6.MaxLength = 3;
            this.textboxH6.Name = "textboxH6";
            this.textboxH6.Size = new System.Drawing.Size(62, 20);
            this.textboxH6.TabIndex = 18;
            // 
            // textboxW6
            // 
            this.textboxW6.Location = new System.Drawing.Point(116, 161);
            this.textboxW6.MaxLength = 3;
            this.textboxW6.Name = "textboxW6";
            this.textboxW6.Size = new System.Drawing.Size(62, 20);
            this.textboxW6.TabIndex = 17;
            // 
            // textboxH5
            // 
            this.textboxH5.Location = new System.Drawing.Point(184, 135);
            this.textboxH5.MaxLength = 3;
            this.textboxH5.Name = "textboxH5";
            this.textboxH5.Size = new System.Drawing.Size(62, 20);
            this.textboxH5.TabIndex = 16;
            // 
            // textboxW5
            // 
            this.textboxW5.Location = new System.Drawing.Point(116, 135);
            this.textboxW5.MaxLength = 3;
            this.textboxW5.Name = "textboxW5";
            this.textboxW5.Size = new System.Drawing.Size(62, 20);
            this.textboxW5.TabIndex = 15;
            // 
            // textboxHW4
            // 
            this.textboxHW4.Location = new System.Drawing.Point(116, 109);
            this.textboxHW4.MaxLength = 3;
            this.textboxHW4.Name = "textboxHW4";
            this.textboxHW4.Size = new System.Drawing.Size(130, 20);
            this.textboxHW4.TabIndex = 14;
            // 
            // textboxH3
            // 
            this.textboxH3.Location = new System.Drawing.Point(184, 83);
            this.textboxH3.MaxLength = 3;
            this.textboxH3.Name = "textboxH3";
            this.textboxH3.Size = new System.Drawing.Size(62, 20);
            this.textboxH3.TabIndex = 13;
            // 
            // textboxW3
            // 
            this.textboxW3.Location = new System.Drawing.Point(116, 83);
            this.textboxW3.MaxLength = 3;
            this.textboxW3.Name = "textboxW3";
            this.textboxW3.Size = new System.Drawing.Size(62, 20);
            this.textboxW3.TabIndex = 12;
            // 
            // textboxH2
            // 
            this.textboxH2.Location = new System.Drawing.Point(184, 57);
            this.textboxH2.MaxLength = 3;
            this.textboxH2.Name = "textboxH2";
            this.textboxH2.Size = new System.Drawing.Size(62, 20);
            this.textboxH2.TabIndex = 11;
            // 
            // textboxW2
            // 
            this.textboxW2.Location = new System.Drawing.Point(116, 57);
            this.textboxW2.MaxLength = 3;
            this.textboxW2.Name = "textboxW2";
            this.textboxW2.Size = new System.Drawing.Size(62, 20);
            this.textboxW2.TabIndex = 10;
            // 
            // checkboxRightclickMenu
            // 
            this.checkboxRightclickMenu.AutoSize = true;
            this.checkboxRightclickMenu.Checked = true;
            this.checkboxRightclickMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxRightclickMenu.Location = new System.Drawing.Point(7, 89);
            this.checkboxRightclickMenu.Name = "checkboxRightclickMenu";
            this.checkboxRightclickMenu.Size = new System.Drawing.Size(147, 17);
            this.checkboxRightclickMenu.TabIndex = 3;
            this.checkboxRightclickMenu.Text = "Clean up rightclick menus";
            this.checkboxRightclickMenu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonApplyRun);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxFontName);
            this.Name = "Form1";
            this.Text = "E17 Font Fix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxFontName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonApplyRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkboxMusicFix;
        private System.Windows.Forms.CheckBox checkboxFontFix;
        private System.Windows.Forms.TextBox textboxW1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxH1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textboxH6;
        private System.Windows.Forms.TextBox textboxW6;
        private System.Windows.Forms.TextBox textboxH5;
        private System.Windows.Forms.TextBox textboxW5;
        private System.Windows.Forms.TextBox textboxHW4;
        private System.Windows.Forms.TextBox textboxH3;
        private System.Windows.Forms.TextBox textboxW3;
        private System.Windows.Forms.TextBox textboxH2;
        private System.Windows.Forms.TextBox textboxW2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkboxSkipSpeed;
        private System.Windows.Forms.CheckBox checkboxRightclickMenu;
    }
}

