using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Services
    {
        static public Book CreateBook()
        {
            String userInput;

            while (true)
            {
                Console.WriteLine("What is the type of the book? Enter 1 for ebook, Enter 2 for PrintedBook");
                userInput = Console.ReadLine();
                if (userInput == "1" || userInput == "2")
                {
                    break;
                }
            }

            if (userInput == "1")
            {
                Console.WriteLine("BookName please");
                Console.WriteLine("ISBN NO. please");
                Console.WriteLine("Filetype please"); return new Ebook(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());







            }

            else
            {

                float WeIGHt;
                String BOOkName;
                String Isbn;

                Console.WriteLine("BookName please");
                BOOkName = Console.ReadLine();
                Console.WriteLine("ISBN NO. please");
                Isbn = Console.ReadLine();
                



                while (true)
                {


                    Console.WriteLine("weight please");
                    WeIGHt = float.Parse(Console.ReadLine());

                    if(WeIGHt > 0)
                    {
                        break;


                    }



                }









                return new PrintedBook(BOOkName, Isbn, WeIGHt);
            }










        }
       static public void ViewBooks(List<Book> BookList)
        {



            foreach (Book book in BookList)
            {
                Console.WriteLine($"{book.BookName}");
            }
        }

        static public float GEtDiscountPercent()
        {
            float DiscountPercent;

            Console.WriteLine("what is the discount percent");
            DiscountPercent= float.Parse(Console.ReadLine());


            return DiscountPercent;


        }








   
    }

    }
