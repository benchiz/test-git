using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_sessionSecond
{
    public partial class delAdmin : Form
    {
        Service service = new Service();
        public delAdmin()
        {
            InitializeComponent();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            //SqlDataReader service = Service.SelectService(Convert.ToInt32((sender as Button).Tag));
            //if (service.HasRows)
            //{
            //    while (service.Read())
            //    {
            //        object Title = service.GetValue(1);
            //        DialogResult result = MessageBox.Show("Вы действительно хотите удалить услугу " + Title + "? ", "", MessageBoxButtons.YesNo);
            //        if (result == DialogResult.Yes)
            //        {
            //            MessageBox.Show("Услуга удалена", "", MessageBoxButtons.OK);
            //        }
            //    }
            //}

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить услугу " + "? ", "", MessageBoxButtons.YesNo);
            if (ID_Place.Text != "" && result == DialogResult.Yes)
            {
                int idTmp = Convert.ToInt32(ID_Place.Text);
                service.DeleteService(idTmp);
                MessageBox.Show("Услуга удалена", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Нужно ввести значение", "", MessageBoxButtons.OK);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
            Hide();
        }
    }
}
