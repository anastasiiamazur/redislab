using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateControls();
        }

        public void ReadData()
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            int n = cache.get;
            for (int i = 0; i < devicesCount; i++)
            {
                var value = cache.StringGet($"Device_Status:{i}");
                //textBox1.Text += $"Valor={value}";
            }
        }

        public void SaveBigData()
        {
            var devicesCount = 10;
            var rnd = new Random();
            var cache = RedisConnectorHelper.Connection.GetDatabase();

            for (int i = 1; i < devicesCount; i++)
            {
                var value = rnd.Next(0, 10000);
                cache.StringSet($"Device_Status:{i}", value);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void CreateControls()
        {
            int count =20;
            for (int i = 0; i < count; i++)
            {
                Button but = new Button();
                PictureBox pic = new PictureBox();
                Panel pan = new Panel();
                Bitmap img = new Bitmap(@"C:\Users\nasty\Documents\Visual Studio 2017\Projects\WindowsFormsApp2\WindowsFormsApp2\bin\Debug\images\sign-check-icon.png");

                pan.Width = 150;
                pan.Height = 150;
                pan.BorderStyle = BorderStyle.FixedSingle;

                pic.Width = 145;
                pic.Height = 124;
                pic.Top = 2;
                pic.Left = 2;
                pic.Image = img;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                but.Width = 145;
                but.Height = 20;
                but.Top = 128;
                but.Left = 2;

                pan.Controls.Add(but);
                pan.Controls.Add(pic);
                flowLayoutPanel1.Controls.Add(pan);
                pan.Top = 10 + 170 * i;
                pan.Left = 10 + 170 * i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addproduct n = new addproduct();
            n.Show();
        }
    }
}
