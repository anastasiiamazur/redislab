using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class addproduct : Form
    {
        public addproduct()
        {
            InitializeComponent();
        }
        string img;
        private void save_Click(object sender, EventArgs e)
        {
            Product[] pr = new Product[1];
            pr[0] = new Product();
            pr[0].title = title.Text;
            pr[0].description = desc.Text;
            pr[0].price = Convert.ToDouble(price.Text);
            pr[0].imagePath = img;
            RedisControl.SaveBigData(pr);
            this.Close();
        }

        private void choose_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\nasty\Desktop";
            openFileDialog1.Filter = "Image files (*.jpeg; *.jpg; *.png; *.gif; *.bmp)|*.jpeg; *.jpg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string backupDir = AppDomain.CurrentDomain.BaseDirectory + @"images\" + openFileDialog1.SafeFileName;

                            // Use the Path.Combine method to safely append the file name to the path.
                            // Will overwrite if the destination file already exists.
                            File.Copy(openFileDialog1.FileName, backupDir, true);
                            image.BackgroundImage = Image.FromFile(backupDir);
                            image.BackgroundImageLayout = ImageLayout.Stretch;
                            img = backupDir;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductCSV pr = new ProductCSV();
            pr.Show();
        }
    }
}
