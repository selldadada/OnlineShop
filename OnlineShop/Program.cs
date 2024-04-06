using System;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using ClassLibrary1;
using OnlineShop;
using static System.Formats.Asn1.AsnWriter;

namespace OnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
                Console.WriteLine("┌──────────────────────────────┐");
                Console.WriteLine("Welcome to Sellda's Tiktok Shop!");
                Console.WriteLine("└──────────────────────────────┘");
                Console.WriteLine("\r\nWhat are you looking for? Please select from the Categories:");
                Console.WriteLine("");
                Console.WriteLine("  TOPS");
                Console.WriteLine("  BOTTOMS");
                Console.WriteLine("  BAGS");
                Console.WriteLine("");

                Store SelldaTiktokShop = new Store();
                string num = Console.ReadLine();

                Calling croptop = new Calling();
                croptop.product = "Crew Neck Semi Crop Top";
                croptop.variation = "Black | White | Brown";
                croptop.size = "XS | S | M | L | XL";
                croptop.price = "P149.00";

                Calling fulllength = new Calling();
                fulllength.product = "Crew Neck Full Length Top";
                fulllength.variation = "Black | White | Grey";
                fulllength.size = "XS | S | M | L | XL";
                fulllength.price = "P170.00";

                Calling jeans = new Calling();
                jeans.product = "Baggy Jeans High Waist";
                jeans.variation = "Dark Blue | Blue | Light Blue";
                jeans.size = "S | M | L";
                jeans.price = "P269.00";

                Calling trouser = new Calling();
                trouser.product = "Wide Leg Trouser High Waist";
                trouser.variation = "Brown | Khaki | White";
                trouser.size = "S | M | L";
                trouser.price = "P249.00";

                Calling shoulderbag = new Calling();
                shoulderbag.product = "Leather Shoulder Bag";
                shoulderbag.variation = "White | Black | Brown";
                shoulderbag.size = "N/A";
                shoulderbag.price = "P150.00";

                Calling slingbag = new Calling();
                slingbag.product = "Corduroy Sling Bag";
                slingbag.variation = "Brown | Khaki | White";
                slingbag.size = "N/A";
                slingbag.price = "P170.00";
               
                switch (num)
                {
                    case "TOPS":
                        Console.WriteLine("");
                        SelldaTiktokShop.DisplayItemInfo(croptop);
                        SelldaTiktokShop.DisplayItemInfo(fulllength);
                        break;

                    case "BOTTOMS":
                        Console.WriteLine("");
                        SelldaTiktokShop.DisplayItemInfo(jeans);
                        SelldaTiktokShop.DisplayItemInfo(trouser);
                        break;

                    case "BAGS":
                        Console.WriteLine("");
                        SelldaTiktokShop.DisplayItemInfo(shoulderbag);
                        SelldaTiktokShop.DisplayItemInfo(slingbag);
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("────────────────────────────────────────────────────────────");
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("────────────────────────────────────────────────────────────");
                        Console.WriteLine("");
                        break;
                }
        }
    }
}