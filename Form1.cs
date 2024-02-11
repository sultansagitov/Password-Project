using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.IO;

namespace Password_Project
{
    public partial class Form1 : Form
    {
        List<Control> password_list = new();

        private const string UPPERS = "QWERTYUIPASDFGHJKLZXCVBNM";
        private const string LOWERS = "qwertyuipasdfghjklzxcvbnm";
        private const string NUMBERS = "123456789";
        private const string SYMBOLS = "!@#$%^&*_+-=";

        public static string app_folder = Environment.ExpandEnvironmentVariables("%APPDATA%\\Result\\Password-Generator\\");
        public static string passwordPath = app_folder + "passwords.txt";
        public static string logPath = app_folder + "log.txt";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumSize = MaximumSize = Size = new(438, 490);
            //if (Environment.OSVersion.Version.Build < 22000)

            if (!File.Exists(passwordPath))
                File.Create(passwordPath);

            if (!File.Exists(logPath))
                File.Create(logPath);
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            string chars =
                (symbols_chk.Checked ? SYMBOLS : "");

            if (lower_chk.Checked)
            {
                chars += LOWERS;
                if (ltr_o_chk.Enabled && ltr_o_chk.Checked)
                    chars += "o";
            }
            if (upper_chk.Checked)
            {
                chars += UPPERS;
                if (ltr_o_chk.Enabled && ltr_o_chk.Checked)
                    chars += "O";
            }
            if (numbers_chk.Checked)
            {
                chars += NUMBERS;
                if (zero_chk.Enabled && zero_chk.Checked)
                    chars += "0";
            };

            foreach (Control cont in password_list)
                Controls.Remove(cont);
            password_list.Clear();

            if (chars.Length == 0)
            {

                Label msg = new()
                {
                    Location = new(12, 185),
                    Text = "Нет символов для пароля"
                };

                password_list.Add(msg);
                Controls.Add(msg);
            }
            else
            {
                Random rnd = new();

                for (int i = 0; i < count_num.Value; i++)
                {
                    string password = "";

                    for (int j = 0; j < length_num.Value; j++)
                        password += chars[rnd.Next(chars.Length)];

                    Button copybtn = new()
                    {
                        Text = "Скопировать",
                        TabIndex = 10 + i,
                        Location = new(12, 186 + i * 29)
                    };

                    copybtn.Size = new(106, copybtn.Size.Height);

                    EventArgs eventArgs = new EventArgs();

                    void copybtn_Click(object sender, EventArgs e)
                    {
                        Clipboard.SetText(password);

                        DateTime dt = DateTime.Now;
                        File.AppendAllText(passwordPath, $"[{DateTime.Now.ToString("HH:mm:ss dd/MMM/YYYY")}] {password}\n");
                    }

                    copybtn.Click += new EventHandler(copybtn_Click);

                    Label passwd = new()
                    {
                        Text = password,
                        Location = new(124, 189 + i * 29)
                    };

                    password_list.Add(copybtn);
                    password_list.Add(passwd);

                    Controls.Add(copybtn);
                    Controls.Add(passwd);
                }
            }
        }

        private void lower_chk_CheckedChanged(object sender, EventArgs e)
        {
            ltr_o_chk.Enabled = lower_chk.Checked || upper_chk.Checked;
            generate_btn.Enabled = lower_chk.Checked || upper_chk.Checked || symbols_chk.Checked || numbers_chk.Checked;
        }

        private void upper_chk_CheckedChanged(object sender, EventArgs e)
        {
            ltr_o_chk.Enabled = lower_chk.Checked || upper_chk.Checked;
            generate_btn.Enabled = lower_chk.Checked || upper_chk.Checked || symbols_chk.Checked || numbers_chk.Checked;
        }

        private void numbers_chk_CheckedChanged(object sender, EventArgs e)
        {
            zero_chk.Enabled = numbers_chk.Checked;
            generate_btn.Enabled = lower_chk.Checked || upper_chk.Checked || symbols_chk.Checked || numbers_chk.Checked;
        }

        private void symbols_chk_CheckedChanged(object sender, EventArgs e)
        {
            generate_btn.Enabled = lower_chk.Checked || upper_chk.Checked || symbols_chk.Checked || numbers_chk.Checked;
        }

        private void count_num_ValueChanged(object sender, EventArgs e)
        {
            generate_btn.Enabled = lower_chk.Checked || upper_chk.Checked || symbols_chk.Checked || numbers_chk.Checked;
        }

        private void file_btn_Click(object sender, EventArgs e)
        {
            Process.Start("notepad", app_folder + "passwords.txt");
        }
    }
}
