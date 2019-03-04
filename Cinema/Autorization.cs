using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Cinema
{
    public partial class Autorization : Form
    {
        MainForm main_form;
        public Autorization()
        {
            main_form = new MainForm();
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputLogin.Text == "" | InputPassword.Text == "")
                MessageBox.Show("Вы заполнили не все поля!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!File.Exists("Password.cn"))
                {
                    #region Если мы не авторизированы в системе
                    FileStream fs = new FileStream("Password.cn", FileMode.Create);
                    StreamWriter writer = new StreamWriter(fs);
                    writer.WriteLine(Hesh(InputLogin.Text));
                    writer.WriteLine(Hesh(InputPassword.Text));
                    writer.Close();
                    MessageBox.Show("Вы успешно авторизированы!\nДобро пожаловать в систему!", Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    main_form.Show();
                    #endregion
                }
                else
                {
                    #region Если мы авторизированы в системе
                    FileStream fs = new FileStream("Password.cn", FileMode.Open);
                    StreamReader reader = new StreamReader(fs);
                    if (Hesh(InputLogin.Text) == reader.ReadLine())     /*Хеширование - это необратимая операция.*/
                    {
                        if (Hesh(InputPassword.Text) == reader.ReadLine())
                        {
                            MessageBox.Show("Добро пожаловать в систему!", Text, MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Hide();
                            main_form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Пароль не верен!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            InputPassword.Clear();
                            reader.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин не верен!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InputLogin.Clear();
                        reader.Close();
                    }
                    #endregion
                }
            }

        }

        private static string Hesh(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
                return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
            }
        }
    }
}