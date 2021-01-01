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
    public partial class userForm : Form
    {
        Service service = new Service();
        TableLayoutPanel brick = new TableLayoutPanel();
        public userForm()
        {
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Add(brick);
            brick.Width = panelMain.Width - 20;
            brick.Height = 0;

            brick.ColumnCount = 2;
            brick.RowCount = 0;

            brick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            brick.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            int i = 0;
            int rowHeight = 150;
            SqlDataReader services = service.SelectServices();

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

                    // Добавление строк и стилей
                    brick.RowCount++;
                    brick.Height = rowHeight * brick.RowCount;
                    brick.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    brick.RowCount++;
                    brick.Height = rowHeight * brick.RowCount;
                    brick.RowStyles.Add(new RowStyle(SizeType.AutoSize, rowHeight));

                    // Динамическое добавление панели для картинки
                    Panel panelImg = new Panel();
                    PictureBox serviceImg = new PictureBox();
                    serviceImg.BackgroundImageLayout = ImageLayout.Center;
                    panelImg.Controls.Add(serviceImg);
                    panelImg.Dock = DockStyle.Fill;
                    serviceImg.Dock = DockStyle.Fill;

                    char[] charsToTrim = { ' ' };
                    string result = MainPathImg.Trim(charsToTrim);
                    serviceImg.BackgroundImage = Image.FromFile(".\\" + result);

                    brick.Controls.Add(panelImg, 0, i);

                    // Динамическое добавление вложенной таблицы
                    TableLayoutPanel brickIn = new TableLayoutPanel();
                    brick.Controls.Add(brickIn, 1, i);
                    brickIn.Dock = DockStyle.Fill;
                    brickIn.ColumnCount = 2;
                    brickIn.RowCount = 3;
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                    brickIn.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    brickIn.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                    Label nameService = new Label();
                    nameService.Dock = DockStyle.Fill;
                    nameService.Text = Title + "";
                    nameService.Font = new Font(nameService.Font.FontFamily, 14);

                    Label costService = new Label();
                    string[] CostTmp = Convert.ToString(Cost).Split(new char[] { ',' });
                    int DurationInSecondsTmp = Convert.ToInt32(DurationInSeconds) / 60;

                    double DiscountTmp = Convert.ToDouble(Discount);

                    Label labelDiscount = new Label();
                    labelDiscount.Dock = DockStyle.Fill;
                    labelDiscount.Text = "";

                    double discount = 100 * DiscountTmp;
                    if (DiscountTmp > 0)
                    {
                        labelDiscount.Text = "*скидка " + discount + "%";
                        labelDiscount.Font = new Font(labelDiscount.Font.FontFamily, 14);

                        string g = Encoding.UTF8.GetString(new byte[] { 204, 182 });
                        double NewCost = Convert.ToDouble(CostTmp[0]) - (Convert.ToDouble(CostTmp[0]) * DiscountTmp);
                        costService.Text = string.Join(g, CostTmp[0].AsEnumerable()).Insert(0, g) + " " + NewCost + " рублей за " + DurationInSecondsTmp + " минут";
                    }
                    else
                    {
                        costService.Text = CostTmp[0] + " рублей за " + DurationInSecondsTmp + " минут";
                    }

                    costService.Dock = DockStyle.Fill;
                    costService.Font = new Font(costService.Font.FontFamily, 14);

                    brickIn.Controls.Add(nameService, 0, 0);
                    brickIn.Controls.Add(costService, 0, 1);
                    if (DiscountTmp > 0)
                    {
                        brickIn.Controls.Add(labelDiscount, 0, 2);
                        brickIn.BackColor = Color.FromArgb(255, 255, 225);

                    }
                    i++;
                }
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

