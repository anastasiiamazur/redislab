using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class RedisControl
    {

        public static void SaveBigData(Product[] prod)
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            foreach (Product p in prod)
            {
                if (p != null)
                {
                    int ID = Convert.ToInt32(cache.StringIncrement("Products:lastid"));
                    cache.HashSet($"Products:{ID}", "title", p.title);
                    cache.HashSet($"Products:{ID}", "description", p.description);
                    cache.HashSet($"Products:{ID}", "price", p.price);
                    cache.HashSet($"Products:{ID}", "image", p.imagePath);
                }
            }
           
        }
        public static Product[] ReadData()
        {
            var cache = RedisConnectorHelper.Connection.GetDatabase();
            int ID = Convert.ToInt32(cache.StringGet("Products:lastid"));
            Product[] prod = new Product[ID];
            for (int i = 0; i <= ID-1; i++)
            {
                prod[i] = new Product(i, cache.HashGet($"Products:{i}", "title"),
                                    Convert.ToInt32(cache.HashGet($"Products:{i}", "price").ToString()),
                                    cache.HashGet($"Products:{i}", "descriprion"),
                                    cache.HashGet($"Products:{i}", "image"));
            }
            return prod;
        }
    }
}
