using System;
using System.Collections.Generic;
using System.Linq;

namespace ListingLocalDataApp
{




    class Program
    {
        static void Main(string[] args)
        {
            //Implementing Enums
            var LanguageSelected = Languages.Chinesse;
           Console.WriteLine(LanguageSelected.ToString());

            //Implementing Structs
            //First at all we need to set the data to the struct , in this 
            //case the members of the struct are privated , then i assigned the data in the construct,
            //after that i creted one getter property to get the data setted in the previous instance
            var Data= new PersonalData("Samuel",30,"Software Developer",false);
            Console.WriteLine($"Name:{Data.getData.Item1}, Age:{Data.getData.Item2},Occupation:{Data.getData.Item3}, Is Single:{Data.getData.Item4}");


            //Another example of struct using private members of it.
            //First we need set data in the constructor.
            Book CSharpBook = new Book("CSharp for Dummies", "CSharp for Begginners", "Microsoft", 60.7);
            Console.WriteLine($"Title of the Book:{CSharpBook.ReturnData.Item1}, Description:{CSharpBook.ReturnData.Item2},Autor:{CSharpBook.ReturnData.Item3},Price:${CSharpBook.ReturnData.Item4}");

            ListsClass Listing = new ListsClass();
            var Seven=Listing.From1To10.Where(x=>(x<8 & x>6)).FirstOrDefault();
            Console.WriteLine($"Number Selected is:{Seven}");

            var NumbersFrom4toTen = Listing.From1To10.Where(i => i > 3).ToList();
            foreach(var ItemNumber in NumbersFrom4toTen)
            {
                Console.WriteLine($"Printing the Number:" + ItemNumber);
            }

            var ListNames = new ListsClass().ListNames;
            Console.WriteLine($"Number of Names:{ListNames.Count()}, First Element:{ListNames.FirstOrDefault()},Last Element:{ListNames.LastOrDefault()}, Se encuentra Sant:{ListNames.Where(x=>  x.IndexOf("Santi")!=-1 ).FirstOrDefault()}");


            var Greetings = new ListsClass().Greetings;
            var SelectedGreetings = from string Greet in Greetings where Greet.Length > 7 select Greet;
            var LessThanSeventChars = from string G in Greetings where G.Length < 7 select G;
            var LessThan4Chars = (from string GreetingSelected in Greetings where GreetingSelected.Length<4 select GreetingSelected);

            // from ....type [selector] ListingOrArray where [selector condition] select [selector]


            var NumbersSelected = from int N_ in new ListsClass().From1To10 where N_ > 5 & N_ < 9 select N_;
            foreach (var NSelected in NumbersSelected)
            {
                Console.WriteLine($"Number selected using Linq:{NSelected}");
            }

         }
    }
}
