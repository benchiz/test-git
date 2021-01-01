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
    public partial class AddService : Form
    {
        Service service = new Service();
        public AddService()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputTitle.Text != "" && inputTime.Text != "" && inputCost.Text != "" && inputImagePath.Text != "" && inputDiscount.Text != "")
            {
                string titleTmp = inputTitle.Text;
                int timeTmp = Convert.ToInt32(inputTime.Text);
                double costTmp = Convert.ToDouble(inputCost.Text);
                double discountTmp = Convert.ToDouble(inputDiscount.Text);
                string imgpathTmp = inputImagePath.Text;
                service.AddService(titleTmp, costTmp, timeTmp, imgpathTmp, discountTmp);
                MessageBox.Show("Услуга успешно добавлена", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены", "", MessageBoxButtons.OK);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm admin = new adminForm();
            admin.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddService_Load(object sender, EventArgs e)
        {

        }
    }
}
