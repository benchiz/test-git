using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_sessionSecond
{
    public partial class EditAdmin : Form
    {
        Service service = new Service();
        public EditAdmin()
        {
            InitializeComponent();
        }

        //public void Update(int id)
        //{
        //    SqlDataReader services = service.SelectService(id);
        //    if (services.HasRows)
        //    {
        //        while (services.Read())
        //        {
        //            object Id = services.GetValue(0);
        //            object MainImagePath = services.GetValue(1);
        //            object Cost = services.GetValue(2);
        //            object Discount = services.GetValue(3);
        //            object Title = services.GetValue(4);
        //            object DurationInSeconds = services.GetValue(5);
        //            string MainPathImg = Convert.ToString(MainImagePath);
        //            titlePlace.Text = Title + "";

        //            ID_Place.Text = id + "";
        //            imgpathPlace.Text = MainPathImg + "";
        //            costPlace.Text = Cost + "";
        //            discountPlace.Text = Discount + "";
        //            titlePlace.Text = Title + "";
        //            timePlace.Text = DurationInSeconds + "";
        //        }
        //    }
        //}

        private void backButton_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            admin.Show();
            this.Hide();
        }

        private void saveeditButton_Click(object sender, EventArgs e)
        {
            if(titlePlace.Text != "" && timePlace.Text != "" && costPlace.Text != "" && discountPlace.Text != "" && imgpathPlace.Text != "" && ID_Place.Text != "")
            {
                int idTmp = Convert.ToInt32(ID_Place.Text);
                string titleTmp = titlePlace.Text;
                int timeTmp = Convert.ToInt32(timePlace.Text);
                double costTmp = Convert.ToDouble(costPlace.Text);
                double discountTmp = Convert.ToDouble(discountPlace.Text);
                string imgpathTmp = imgpathPlace.Text;
                service.UpdateService(idTmp, titleTmp, costTmp, timeTmp, imgpathTmp, discountTmp);

                MessageBox.Show("Изменения успешно приняты", "", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Нужно заполнить все поля", "", MessageBoxButtons.OK);
            }
        }
    }
}
