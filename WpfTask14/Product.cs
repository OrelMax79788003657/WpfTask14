using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTask14
{
    public enum Categories
    {
        Food,
        Appliance
    }


    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public Categories Category { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
