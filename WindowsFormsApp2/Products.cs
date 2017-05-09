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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            //CreateControls();
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
            Product[] product = RedisControl.ReadData();
            int i = 0;
            foreach (Product prod in product)
            {
                PictureBox pic = new PictureBox();
                Bitmap img = new Bitmap(prod.imagePath);

                pic.Width = 145;
                pic.Height = 124;
                pic.Top = 2;
                pic.Left = 2;
                pic.Image = img;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                flowLayoutPanel1.Controls.Add(pic);
                pic.Top = 30 + 170 * i;
                pic.Left = 30 + 170 * i;
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addproduct n = new addproduct();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            CreateControls();
        }
    }
}
