using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppTests;
using AppTests.ModelsGUI;

namespace SmartParkingUserGUI
{
    public partial class frmAutorization : Form
    {
        public frmAutorization()
        {
            InitializeComponent();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            User user = TestsManager.Autorization(txtLogin.Text, txtPassword.Text);
            if (user != null)
            {
                this.Hide();
                frmMain fMain = new frmMain(user);
                fMain.ShowDialog();
            }
            else MessageBox.Show("Неверное имя пользователя или пароль!",
                "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                MessageBox.Show("Заполните имя пользователя!");
            else if (string.IsNullOrEmpty(txtUserLogin.Text))
                MessageBox.Show("Заполните логин пользователя!");
            else if (string.IsNullOrEmpty(txtUserPassword.Text))
                MessageBox.Show("Заполните пароль!");
            else
            {
                User newUser = new User(
                    txtUserLogin.Text,
                    txtUserName.Text,                  
                    txtUserPassword.Text);
                if (TestsManager.RegisterUser(newUser))
                {
                    foreach (Control ctr in grbRegister.Controls)
                        if (ctr is TextBox) (ctr as TextBox).Text = string.Empty;
                    MessageBox.Show("Пользователь успешно зарегистрирован!",
                        "Регистрация успешна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Такой пользователь уже существует!\n" +
                        "Войдите с телефоном и паролем!", "Пользователь есть",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
