using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Book
    {
        public String BookName;
        public String ISBNnumber;
        private int NoOfCopies = 0;
        public Book(String BookName, String ISBNnumber)
        {

            this.BookName = BookName;
            this.ISBNnumber = ISBNnumber;
        }
        public void SetNoOfCopies(int noOfCopies)
        {
            if (noOfCopies >= 0)
            {
                this.NoOfCopies = noOfCopies;
            }
        }
        public int GetNoOfCopies()
        { return this.NoOfCopies; }

        public void Calculateprice()
        {
        }

        public float Calculateprice(float discountPercent)
        {
            return 0;
        }
    }
}


class Ebook : Book
{
    public String fileType;
    public float fileSize;
    public Ebook(string BookName, string ISBNnumber, String fileType) : base(BookName, ISBNnumber)
    {
        this.fileType = fileType;
    }


    public float Calculateprice()
    {
        float price = fileSize * 400 + 200;
       
        return price;
    }

    public float Calculateprice(float discountPercent)
    {
        float discount;
        discount = this.Calculateprice() * discountPercent/100;
        Console.WriteLine($"A discount of {discount} will be added");
        return this.Calculateprice() - discount;
    }


}


class PrintedBook : Book
{
    private float weight = -1;
    public PrintedBook(string BookName, string ISBNnumber, float weight) : base(BookName, ISBNnumber)
    {
        this.weight = weight;
    }
    public void SetWeight(float abc)
    {
        
            this.weight = abc;
        
    }





    public float GetWeight()
    {
        return weight;                      

    }

    public float Calculateprice()
    {
        
        return weight * 400 + 200;
    }

    public float Calculateprice(float discountPercent)
    {
        
        float discount;
        discount = this.Calculateprice() * discountPercent/100;
        Console.WriteLine($"A discount of {discount} will be added");
        return this.Calculateprice() - discount;
    }

}
