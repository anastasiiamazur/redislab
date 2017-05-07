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
        public void SaveBigData(long ID, string title, string descriprion, double price, string imagePath)
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            cache.StringSet($"Title:{ID}", title);
            cache.StringSet($"Descriprion:{ID}", descriprion);
            cache.StringSet($"Price:{ID}", price);
            cache.StringSet($"Image:{ID}", imagePath);

        }
        private void save_Click(object sender, EventArgs e)
        {
            Random id = new Random();
            long ID = id.Next(99999999);
            string Title = title.ToString();
            string Descriprion = desc.ToString();
            double Price = Convert.ToDouble(price.ToString());
            string ImagePath = image.ImageLocation;
            SaveBigData(ID, Title, Descriprion, Price, ImagePath);
            this.Close();
        }

        private void choose_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\nasty\Desktop";
            openFileDialog1.Filter = "Image files (*.jpeg)|*.jpeg|(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.bmp|All files (*.*)|*.*";
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
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
