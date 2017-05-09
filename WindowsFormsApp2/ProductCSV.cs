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
    public partial class ProductCSV : Form
    {
        public ProductCSV()
        {
            InitializeComponent();
            ImportCSV();
        }
        DataTable dt;
        public void ImportCSV()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\nasty\Desktop";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string CSVFilePathName = openFileDialog1.FileName;
                            string[] Lines = File.ReadAllLines(CSVFilePathName);
                            string[] Fields;
                            Fields = Lines[0].Split(new char[] { ',' });
                            int Cols = Fields.GetLength(0);
                            dt = new DataTable();
                            //1st row must be column names; force lower case to ensure matching later on.
                            for (int i = 0; i < Cols; i++)
                                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                            DataRow Row;
                            for (int i = 1; i < Lines.GetLength(0); i++)
                            {
                                Fields = Lines[i].Split(new char[] { ',' });
                                Row = dt.NewRow();
                                for (int f = 0; f < Cols; f++)
                                    Row[f] = Fields[f];
                                dt.Rows.Add(Row);
                            }
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                    throw;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product[] product = new Product[dataGridView1.Rows.Count];
            int i = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                product[i] = new Product();
                product[i].imagePath = r.Cells[0].Value.ToString();
                product[i].price = Convert.ToInt32(r.Cells[1].Value.ToString());
                product[i].title= r.Cells[2].Value.ToString();
                product[i].description = r.Cells[3].Value.ToString();
                i++;
                if (i == dataGridView1.Rows.Count - 1)
                    break;
            }
            RedisControl.SaveBigData(product);
            this.Close();
        }
    }
}
