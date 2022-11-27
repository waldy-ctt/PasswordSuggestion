namespace PasswordSuggestion
{
    partial class EnglishForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.LowerCaseLetter_ChkBx = new System.Windows.Forms.CheckBox();
            this.UpperCaseLetter_ChkBx = new System.Windows.Forms.CheckBox();
            this.Number_ChkBx = new System.Windows.Forms.CheckBox();
            this.Symbol_ChkBx = new System.Windows.Forms.CheckBox();
            this.SpecialCharacter_ChkBx = new System.Windows.Forms.CheckBox();
            this.LenghthOfPassword_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.txt3 = new System.Windows.Forms.Label();
            this.CreatePassword_Button = new System.Windows.Forms.Button();
            this.Password_TxtBx = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.LanguageBox = new System.Windows.Forms.ComboBox();
            this.txt6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LenghthOfPassword_NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(18, 9);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(183, 15);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Password Suggestion Application";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(18, 31);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(284, 15);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "Please choose what you want your password to have";
            // 
            // LowerCaseLetter_ChkBx
            // 
            this.LowerCaseLetter_ChkBx.AutoSize = true;
            this.LowerCaseLetter_ChkBx.Location = new System.Drawing.Point(20, 49);
            this.LowerCaseLetter_ChkBx.Name = "LowerCaseLetter_ChkBx";
            this.LowerCaseLetter_ChkBx.Size = new System.Drawing.Size(119, 19);
            this.LowerCaseLetter_ChkBx.TabIndex = 2;
            this.LowerCaseLetter_ChkBx.Text = "Lower Case Letter";
            this.toolTip1.SetToolTip(this.LowerCaseLetter_ChkBx, "a, b, c, d,...");
            this.LowerCaseLetter_ChkBx.UseVisualStyleBackColor = true;
            this.LowerCaseLetter_ChkBx.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // UpperCaseLetter_ChkBx
            // 
            this.UpperCaseLetter_ChkBx.AutoSize = true;
            this.UpperCaseLetter_ChkBx.Location = new System.Drawing.Point(183, 49);
            this.UpperCaseLetter_ChkBx.Name = "UpperCaseLetter_ChkBx";
            this.UpperCaseLetter_ChkBx.Size = new System.Drawing.Size(119, 19);
            this.UpperCaseLetter_ChkBx.TabIndex = 3;
            this.UpperCaseLetter_ChkBx.Text = "Upper Case Letter";
            this.toolTip2.SetToolTip(this.UpperCaseLetter_ChkBx, "A, B, C, D,...");
            this.UpperCaseLetter_ChkBx.UseVisualStyleBackColor = true;
            this.UpperCaseLetter_ChkBx.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // Number_ChkBx
            // 
            this.Number_ChkBx.AutoSize = true;
            this.Number_ChkBx.Location = new System.Drawing.Point(20, 74);
            this.Number_ChkBx.Name = "Number_ChkBx";
            this.Number_ChkBx.Size = new System.Drawing.Size(70, 19);
            this.Number_ChkBx.TabIndex = 4;
            this.Number_ChkBx.Text = "Number";
            this.toolTip3.SetToolTip(this.Number_ChkBx, "1, 2, 3, 4,...");
            this.Number_ChkBx.UseVisualStyleBackColor = true;
            this.Number_ChkBx.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // Symbol_ChkBx
            // 
            this.Symbol_ChkBx.AutoSize = true;
            this.Symbol_ChkBx.Location = new System.Drawing.Point(183, 74);
            this.Symbol_ChkBx.Name = "Symbol_ChkBx";
            this.Symbol_ChkBx.Size = new System.Drawing.Size(71, 19);
            this.Symbol_ChkBx.TabIndex = 5;
            this.Symbol_ChkBx.Text = "Symbols";
            this.toolTip4.SetToolTip(this.Symbol_ChkBx, "!, @, #, $,...");
            this.Symbol_ChkBx.UseVisualStyleBackColor = true;
            this.Symbol_ChkBx.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // SpecialCharacter_ChkBx
            // 
            this.SpecialCharacter_ChkBx.AutoSize = true;
            this.SpecialCharacter_ChkBx.Location = new System.Drawing.Point(94, 99);
            this.SpecialCharacter_ChkBx.Name = "SpecialCharacter_ChkBx";
            this.SpecialCharacter_ChkBx.Size = new System.Drawing.Size(122, 19);
            this.SpecialCharacter_ChkBx.TabIndex = 6;
            this.SpecialCharacter_ChkBx.Text = "Special Characters";
            this.toolTip5.SetToolTip(this.SpecialCharacter_ChkBx, "`, ~, (, ),...");
            this.SpecialCharacter_ChkBx.UseVisualStyleBackColor = true;
            this.SpecialCharacter_ChkBx.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // LenghthOfPassword_NumUpDown
            // 
            this.LenghthOfPassword_NumUpDown.Location = new System.Drawing.Point(18, 156);
            this.LenghthOfPassword_NumUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.LenghthOfPassword_NumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LenghthOfPassword_NumUpDown.Name = "LenghthOfPassword_NumUpDown";
            this.LenghthOfPassword_NumUpDown.Size = new System.Drawing.Size(120, 23);
            this.LenghthOfPassword_NumUpDown.TabIndex = 7;
            this.LenghthOfPassword_NumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(18, 138);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(198, 15);
            this.txt3.TabIndex = 8;
            this.txt3.Text = "Please choose your password length";
            // 
            // CreatePassword_Button
            // 
            this.CreatePassword_Button.Enabled = false;
            this.CreatePassword_Button.Location = new System.Drawing.Point(18, 199);
            this.CreatePassword_Button.Name = "CreatePassword_Button";
            this.CreatePassword_Button.Size = new System.Drawing.Size(173, 23);
            this.CreatePassword_Button.TabIndex = 9;
            this.CreatePassword_Button.Text = "Create Password";
            this.CreatePassword_Button.UseVisualStyleBackColor = true;
            this.CreatePassword_Button.Click += new System.EventHandler(this.CreatePassword_Button_Click);
            // 
            // Password_TxtBx
            // 
            this.Password_TxtBx.Location = new System.Drawing.Point(18, 251);
            this.Password_TxtBx.Name = "Password_TxtBx";
            this.Password_TxtBx.ReadOnly = true;
            this.Password_TxtBx.Size = new System.Drawing.Size(309, 23);
            this.Password_TxtBx.TabIndex = 10;
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Location = new System.Drawing.Point(15, 233);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(87, 15);
            this.txt4.TabIndex = 11;
            this.txt4.Text = "Your password:";
            // 
            // txt5
            // 
            this.txt5.AutoSize = true;
            this.txt5.Location = new System.Drawing.Point(18, 286);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(256, 15);
            this.txt5.TabIndex = 12;
            this.txt5.Text = "Your password have been copied to clipboard !!";
            this.txt5.Visible = false;
            // 
            // LanguageBox
            // 
            this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageBox.FormattingEnabled = true;
            this.LanguageBox.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt"});
            this.LanguageBox.Location = new System.Drawing.Point(18, 327);
            this.LanguageBox.Name = "LanguageBox";
            this.LanguageBox.Size = new System.Drawing.Size(121, 23);
            this.LanguageBox.TabIndex = 13;
            this.LanguageBox.SelectedIndexChanged += new System.EventHandler(this.SetLanguage);
            // 
            // txt6
            // 
            this.txt6.AutoSize = true;
            this.txt6.Location = new System.Drawing.Point(18, 309);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(62, 15);
            this.txt6.TabIndex = 14;
            this.txt6.Text = "Language:";
            // 
            // EnglishForm
            // 
            this.AcceptButton = this.CreatePassword_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(342, 395);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.LanguageBox);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.Password_TxtBx);
            this.Controls.Add(this.CreatePassword_Button);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.LenghthOfPassword_NumUpDown);
            this.Controls.Add(this.SpecialCharacter_ChkBx);
            this.Controls.Add(this.Symbol_ChkBx);
            this.Controls.Add(this.Number_ChkBx);
            this.Controls.Add(this.UpperCaseLetter_ChkBx);
            this.Controls.Add(this.LowerCaseLetter_ChkBx);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EnglishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P.S";
            ((System.ComponentModel.ISupportInitialize)(this.LenghthOfPassword_NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txt1;
        private Label txt2;
        private CheckBox LowerCaseLetter_ChkBx;
        private CheckBox UpperCaseLetter_ChkBx;
        private CheckBox Number_ChkBx;
        private CheckBox Symbol_ChkBx;
        private CheckBox SpecialCharacter_ChkBx;
        private NumericUpDown LenghthOfPassword_NumUpDown;
        private Label txt3;
        private Button CreatePassword_Button;
        private TextBox Password_TxtBx;
        private Label txt4;
        private Label txt5;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private ToolTip toolTip3;
        private ToolTip toolTip4;
        private ToolTip toolTip5;
        private ComboBox LanguageBox;
        private Label txt6;
    }
}