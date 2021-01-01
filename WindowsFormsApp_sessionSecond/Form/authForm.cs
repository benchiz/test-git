using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_sessionSecond
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
            pwdInput.PasswordChar = '*';
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            if (pwdInput.Text == "0000")
            {
                adminForm adminForm = new adminForm();
                adminForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Вы ввели неправильный пароль");
        }

    }
}
