using ConsoleApp1;
using System;
using System.Runtime.CompilerServices;
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Book> listofBooks = new List<Book>();

            listofBooks.Add(Services.CreateBook());
            Services.ViewBooks(listofBooks);




            if (listofBooks[0] is Ebook){
                Console.WriteLine($"Price is {(listofBooks[0] as Ebook).Calculateprice()}");
                Console.WriteLine($"Price is {(listofBooks[0] as Ebook).Calculateprice(Services.GEtDiscountPercent())}");
            }


            else

            {
                Console.WriteLine($"weight is {(listofBooks[0] as PrintedBook).GetWeight()}");

                Console.WriteLine($"Price is {(listofBooks[0] as PrintedBook).Calculateprice()}");
                Console.WriteLine($"Price is {(listofBooks[0] as PrintedBook).Calculateprice(Services.GEtDiscountPercent())}");
            }







           



        }



        
    }
}

