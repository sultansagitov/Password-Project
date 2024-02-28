using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace Password_Project
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        readonly List<Control> password_list = [];
        readonly Random rnd = new();

        private const string UPPERS = "QWERTYUIPASDFGHJKLZXCVBNM";
        private const string LOWERS = "qwertyuipasdfghjklzxcvbnm";
        private const string NUMBERS = "123456789";
        private const string SYMBOLS = "!@#$%^&*_+-=";

        public static string app_folder =
            Environment.ExpandEnvironmentVariables("%APPDATA%/Result/Password-Generator/");
        public static string passwordPath = app_folder + "passwords.txt";
        public static string logPath = app_folder + "log.txt";

        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red900,
                Primary.Red900,
                Primary.Red100,
                Accent.Red200,
                TextShade.WHITE
            );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumSize = MaximumSize = Size;
            //if (Environment.OSVersion.Version.Build < 22000)

            if (!Directory.Exists(app_folder))
                Directory.CreateDirectory(app_folder);

            if (!File.Exists(passwordPath))
            {
                using FileStream sw = File.Create(passwordPath);
            }
            if (!File.Exists(logPath))
            {
                using FileStream sw = File.Create(logPath);
            }
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
                for (int i = 0; i < count_num.Value; i++)
                {
                    string password = "";

                    for (int j = 0; j < length_num.Value; j++)
                        password += chars[rnd.Next(chars.Length)];

                    Point startPosition = new(12, 329);

                    MaterialButton copybtn = new()
                    {
                        Text = "Скопировать",
                        TabIndex = 10 + i,
                        Location = new(startPosition.X, startPosition.Y + i * 48)
                    };

                    copybtn.Size = new(106, copybtn.Size.Height);

                    EventArgs eventArgs = new();

                    void copybtn_Click(object sender, EventArgs e)
                    {
                        Clipboard.SetText(password);

                        DateTime dt = DateTime.Now;
                        using StreamWriter writer = File.AppendText(passwordPath);
                        writer.WriteLine($"[{DateTime.Now:HH:mm:ss dd-MMMM-yyyy}] {password}");
                    }

                    copybtn.Click += new EventHandler(copybtn_Click);

                    MaterialLabel passwd = new()
                    {
                        Text = password,
                        Location = new(startPosition.X + 136, startPosition.Y + 10 + i * 48),
                        AutoSize = true
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
            if (File.Exists(passwordPath))
                Process.Start("notepad", passwordPath);
            else
            {
                MessageBox.Show($"Файл {passwordPath} не найден, Попробуйте перезапустить приложение", "Файл не найден", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void theme_changer_Click(object sender, EventArgs e)
        {
            if (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
