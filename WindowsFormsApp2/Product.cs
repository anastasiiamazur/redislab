using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp2
{
    public class Product
    {
        public int ID { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}
