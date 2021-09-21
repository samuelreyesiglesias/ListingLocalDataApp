using System;
using System.Collections.Generic;
using System.Text;

namespace ListingLocalDataApp
{
    
    class ListsClass
    {
        public List<int> From1To10 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public List<int> From90to100;
        public ListsClass()
        {
            From90to100 = new List<int>() { 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
        }


        public List<string> ListNames
        {
            get
            {
                return new List<string>() { "Samuel","Alexander","Santiago"};
            }    
        }


        public string[] Devices = new string[] {"Printer","SmartPhone","Speaker","SmartBuble","SmartCamera","Tablet","PC","Modem","Router","Switch","Laptop","PSP4","WiiU"};


        public List<string> Greetings = new List<string>()
        {
            "Hi",
            "Hello",
            "How are you?",
            "Good Morning",
            "Howdy",
            "Whats Up",
            "Good Night",
            "Good AfterNoon",
            "Good Evening",
            "Nice to meet you",
            "Nice to see you",
            "I am happy to see you"
        };

    }



}
