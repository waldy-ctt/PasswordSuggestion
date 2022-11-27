using System.Drawing.Text;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace PasswordSuggestion
{
    public partial class EnglishForm : Form
    {
        public string[] password { get; set; }

        private string[] LowerCaseLetter = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
        private string[] UpperCaseLetter = new string[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
        private string[] NumberLeter = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string[] Symbols = new string[] { "!", "@", "#", "$", "%", "^", "&", "*" };
        private string[] SpecialLetter = new string[] { "(", ")", "{", "}", ":", ";", "'", "\"", "\\", "|", "?", "/", ".", ">", "<", ",", "~", "`"};

        public EnglishForm()
        {
            InitializeComponent();
            LanguageBox.SelectedIndex = 0;
        }

        private void CreatePassword_Button_Click(object sender, EventArgs e)
        {
            SoundPlayer son = new SoundPlayer(@"E:\Code\C#\Project\PasswordSuggestion\click.wav");
            son.Play();

            string[] password = new string[Convert.ToInt16(LenghthOfPassword_NumUpDown.Value)];
            Random random = new Random();

            for(int i = 0; i < password.Length; i++)
            {
                switch(random.Next(5))
                {
                    case 0:
                        if(LowerCaseLetter_ChkBx.Checked == true)
                        {
                            password[i] = LowerCaseLetter[random.Next(UpperCaseLetter.Length)];
                            break;
                        }
                        else
                        {
                            i--;
                            break;
                        }

                    case 1:
                        if(UpperCaseLetter_ChkBx.Checked == true)
                        {
                            password[i] = UpperCaseLetter[random.Next(LowerCaseLetter.Length)];
                            break;
                        }
                        else
                        {
                            i--;
                            break;
                        }

                    case 2:
                        if(Number_ChkBx.Checked == true)
                        {
                            password[i] = NumberLeter[random.Next(NumberLeter.Length)];
                            break;
                        }
                        else
                        {
                            i--;
                            break;
                        }

                    case 3:
                        if(Symbol_ChkBx.Checked == true)
                        {
                            password[i] = Symbols[random.Next(Symbols.Length)];
                            break;
                        }
                        else
                        {
                            i--;
                            break;
                        }

                    case 4:
                        if(SpecialCharacter_ChkBx.Checked == true)
                        {
                            password[i] = SpecialLetter[random.Next(SpecialLetter.Length)];
                            break;
                        }
                        else
                        {
                            i--;
                            break;
                        }
                }
            }

            this.password = password;
            this.Password_TxtBx.Text = string.Concat(this.password);
            this.Password_TxtBx.Refresh();

            if(Password_TxtBx.Text != string.Empty)
            {
                System.Windows.Forms.Clipboard.SetText(string.Concat(this.password));
                txt5.Visible = true;
            }
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            if(LowerCaseLetter_ChkBx.Checked == false && UpperCaseLetter_ChkBx.Checked == false && Number_ChkBx.Checked == false && Symbol_ChkBx.Checked == false && SpecialCharacter_ChkBx.Checked == false)
            {
                CreatePassword_Button.Enabled = false;
            }
            else
            {
                CreatePassword_Button.Enabled = true;
            }
        }

        private void SetLanguage(object sender, EventArgs e)
        {
            if(LanguageBox.SelectedIndex == 1)
            {
                txt1.Text = "Ứng dụng gợi ý mật khẩu";
                txt2.Text = "Hãy chọn những thứ bạn muốn có trong mật khẩu";
                LowerCaseLetter_ChkBx.Text = "Chữ cái thường";
                UpperCaseLetter_ChkBx.Text = "Chữ cái in hoa";
                Number_ChkBx.Text = "Số";
                Symbol_ChkBx.Text = "Kí tự đặc biệt bậc 1";
                SpecialCharacter_ChkBx.Text = "Kí tự đặc biệt bậc 2";
                txt3.Text = "Hãy chọn độ dài mật khẩu";
                CreatePassword_Button.Text = "Tạo mật khẩu";
                txt4.Text = "Mật khẩu của bạn:";
                txt5.Text = "Mật khẩu của bạn đã được copy";
                txt6.Text = "Ngôn ngữ:";

                txt1.Update();
                txt2.Update();
                txt3.Update(); 
                txt4.Update(); 
                txt5.Update();
                txt6.Update();
                LowerCaseLetter_ChkBx.Update();
                UpperCaseLetter_ChkBx.Update();
                Number_ChkBx.Update();
                Symbol_ChkBx.Update();
                SpecialCharacter_ChkBx.Update();
                CreatePassword_Button.Update();
            }
            else if(LanguageBox.SelectedIndex == 0)
            {
                txt1.Text = "Password Suggestion Application";
                txt2.Text = "Please choose what you want your password to have";
                LowerCaseLetter_ChkBx.Text = "Lower Case Letter";
                UpperCaseLetter_ChkBx.Text = "Upper Case Letter";
                Number_ChkBx.Text = "Number";
                Symbol_ChkBx.Text = "Symbols";
                SpecialCharacter_ChkBx.Text = "Special Characters";
                txt3.Text = "Please choose your password length";
                CreatePassword_Button.Text = "Create Password";
                txt4.Text = "Your password:";
                txt5.Text = "Your password have been copied to clipboard";
                txt6.Text = "Language:";

                txt1.Update();
                txt2.Update();
                txt3.Update();
                txt4.Update();
                txt5.Update();
                txt6.Update();
                LowerCaseLetter_ChkBx.Update();
                UpperCaseLetter_ChkBx.Update();
                Number_ChkBx.Update();
                Symbol_ChkBx.Update();
                SpecialCharacter_ChkBx.Update();
                CreatePassword_Button.Update();
            }
        }
    }
}