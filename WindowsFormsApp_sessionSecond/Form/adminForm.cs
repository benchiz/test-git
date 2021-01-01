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
    public partial class adminForm : Form
    {
        Service Service = new Service();
        TableLayoutPanel brick = new TableLayoutPanel();
        //TableLayoutPanel brickinsec = new TableLayoutPanel();
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {

            panelService.Controls.Add(brick);
            panelService.Dock = DockStyle.Fill;
            brick.Width = panelService.Width - 20;
            brick.Height = 0;

            brick.ColumnCount = 2;
            brick.RowCount = 0;

            brick.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            brick.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            //Панель редактирования и удаления
            //defPanel.Controls.Add(brick);
            //defPanel.Dock = DockStyle.Fill;
            //brick.Width = defPanel.Width - 20;
            //brick.Height = 0;

            //brick.ColumnCount = 2;
            //brick.RowCount = 0;

            //brick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //brick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            int rowHeight = 150;
            int i = 0;
            SqlDataReader services = Service.SelectServices();
            if (services.HasRows)
            {
                while (services.Read())
                {
                    object Id = services.GetValue(0);
                    object MainImagePath = services.GetValue(1);
                    object Cost = services.GetValue(2);
                    object Discount = services.GetValue(3);
                    object Title = services.GetValue(4);
                    object DurationInSeconds = services.GetValue(5);
                    string MainPathImg = Convert.ToString(MainImagePath);

                    // Динамическое добавление строчки к tableLayoutPanel
                    brick.RowCount++;
                    brick.Height = rowHeight * brick.RowCount;
                    brick.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    brick.RowCount++;
                    brick.Height = rowHeight * brick.RowCount;
                    brick.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    // Динамическое добавление панели для картинки
                    Panel imagePanel = new Panel();
                    PictureBox serviceImage = new PictureBox();
                    serviceImage.BackgroundImageLayout = ImageLayout.Center;
                    imagePanel.Controls.Add(serviceImage);  
                    imagePanel.Dock = DockStyle.Fill;
                    serviceImage.Dock = DockStyle.Fill;
                    imagePanel.Controls.Add(serviceImage);
                    imagePanel.Dock = DockStyle.Fill;
                    serviceImage.Dock = DockStyle.Fill;
                    //imagePanel.BackgroundImage = Image.FromFile(".\\" + serviceImage);

                    try
                    {
                        char[] charsToTrim = { ' ' };
                        string result = MainPathImg.Trim(charsToTrim);
                        serviceImage.BackgroundImage = Image.FromFile(".\\" + result);
                    }
                    catch 
                    {
                        MessageBox.Show("Неправильный путь для картинки", "", MessageBoxButtons.OK);
                    }
                    

                    brick.Controls.Add(imagePanel, 0, i);

                    // Динамическое добавление вложенного TLP
                    TableLayoutPanel brickin = new TableLayoutPanel();
                    brick.Controls.Add(brickin, 1, i);
                    brickin.Dock = DockStyle.Fill;
                    brickin.ColumnCount = 2;
                    brickin.RowCount = 3;
                    brickin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    brickin.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    brickin.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickin.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickin.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    //TLP для редактирования и удаления
                    //brick.Controls.Add(brickin, 0, i);
                    //brickin.Dock = DockStyle.Fill;
                    //brickin.ColumnCount = 2;
                    //brickin.RowCount = 0;
                    //brickin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    //brickin.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                    //Label nameEdit = new Label();
                    //nameEdit.Dock = DockStyle.Fill;
                    //nameEdit.Text = "Режим администратора";
                    //nameEdit.Font = new Font(nameEdit.Font.FontFamily, 14);

                    //Button buttonEdit = new Button();
                    //buttonEdit.Text = "Редактировать";
                    //buttonEdit.Font = new Font(nameEdit.Font.FontFamily, 14);

                    //Button buttonDel = new Button();
                    //buttonDel.Text = "Удалить";
                    //buttonDel.Font = new Font(nameEdit.Font.FontFamily, 14);

                    Label nameService = new Label();
                    nameService.Dock = DockStyle.Fill;
                    nameService.Text = Title + "";
                    nameService.Font = new Font(nameService.Font.FontFamily, 14);

                    Label costService = new Label();
                    string[] costTmp = Convert.ToString(Cost).Split(new char[] { ',' });
                    int durationInSecondsTmp = Convert.ToInt32(DurationInSeconds) / 60;

                    double discountTmp = Convert.ToDouble(Discount);

                    Label labelDiscount = new Label();
                    labelDiscount.Dock = DockStyle.Fill;
                    labelDiscount.Text = "";

                    double discount = 100 * discountTmp;
                    if (discountTmp > 0)
                    {
                        labelDiscount.Text = " *скидка" + discount + "%";
                        labelDiscount.Font = new Font(labelDiscount.Font.FontFamily, 14);

                        string g = Encoding.UTF8.GetString(new byte[] { 204, 182 });
                        double newCost = Convert.ToDouble(costTmp[0]) - (Convert.ToDouble(costTmp[0]) * discountTmp);
                        costService.Text = string.Join(g, costTmp[0].AsEnumerable()).Insert(0, g) + " " + newCost + " рублей за " + durationInSecondsTmp + " минут";
                    }
                    else
                    {
                        costService.Text = costTmp + " рублей за " + durationInSecondsTmp + " минут";
                    }

                    costService.Dock = DockStyle.Fill;
                    costService.Font = new Font(costService.Font.FontFamily, 14);

                    brickin.Controls.Add(nameService, 0, 0);
                    brickin.Controls.Add(costService, 0, 1);
                    if (discountTmp > 0)
                    {
                        brickin.Controls.Add(labelDiscount, 0, 2);
                        brickin.BackColor = Color.FromArgb(255, 255, 255);
                    }
                    i++;
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            delAdmin deleteAdmin = new delAdmin();
            deleteAdmin.Show();
            Hide();
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditAdmin edit = new EditAdmin();
            edit.Show();
            Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddService add = new AddService();
            add.Show();
            Hide();
        }

        private void panelService_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
