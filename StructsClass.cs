using System;
using System.Collections.Generic;
using System.Text;

namespace ListingLocalDataApp
{
    //The struct type data needs to specify the type of data of each element or item added to it
    struct PersonalData
    {
        private string Name;
        private int Age;
        private string Occupation;
        private bool IsSingle;

        public PersonalData(string Name_, int Age_, string Occupation_, bool IsSingle_) : this()
        {
            Name = Name_;
            Age = Age_;
            Occupation = Occupation_;
            IsSingle = IsSingle_;
        }

        public (string, int, string, bool) getData
        {
            get
            {
                return (Name, Age, Occupation, IsSingle);
            }
        }

    }
    struct Book
    {
        private string Title;
        private string Description;
        private string Autor;
        private double Price;

        public Book(string Title_,string Description_,string Autor_,double Price_) : this()
        {
            Title = Title_;
            Description = Description_;
            Autor = Autor_;
            Price = Price_;
        }

        public (string,string,string,double) ReturnData
        {
            get{
                return (Title,Description,Autor,Price);
            }
        }

    }
}
