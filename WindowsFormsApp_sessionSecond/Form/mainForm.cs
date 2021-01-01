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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            userForm userForm = new userForm();
            userForm.Show();
            this.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            authForm authForm = new authForm();
            authForm.Show();
            this.Hide();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
