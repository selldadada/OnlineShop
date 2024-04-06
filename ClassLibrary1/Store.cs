using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Store
    {
        public string product;
        List<Calling> callings = new List<Calling>();

        public void DisplayItemInfo(Calling calling)
        {
            Console.WriteLine("╒════════════════════════════════════════════╕");
            Console.WriteLine("Product: " + calling.product);
            Console.WriteLine("Variations: " + calling.variation);
            Console.WriteLine("Sizes: " + calling.size);
            Console.WriteLine("Price: " + calling.price);
            Console.WriteLine("╘════════════════════════════════════════════╛");
            Console.WriteLine("");
        }
    }
}
