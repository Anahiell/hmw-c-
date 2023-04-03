using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_struct_class
{
    struct Article
    {
        public int Prod_num { get; set; }
        public string Prod_name { get; set; }
        public decimal Prod_price { get; set; }
        public Article(int Num, string Name, decimal Price)
        {
            Prod_num = Num;
            Prod_name = Name;
            Prod_price = Price;
        }
        public override string ToString()
        {
            return "Product number:" + Prod_num + "\nProduct name:" + Prod_name + "\nProduct price:" + Prod_price;
        }
    }
}
