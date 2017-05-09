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
        public Product() {;}
        public Product(int id, string ttl, double pr, string desc, string img)
        {
            this.ID = id;
            this.title = ttl;
            this.price = pr;
            this.description = desc;
            this.imagePath = img;
        }
        public Enumerator GetEnumerator()
        {
            return new Enumerator();
        }
    }
    public class Enumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public object Current
        {
            get { return null; }
        }
    }
}
