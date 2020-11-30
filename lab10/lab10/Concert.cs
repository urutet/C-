using System;
using System.Collections;
using System.Collections.Generic;
namespace lab10
{
    public class Concert
    {

        public string Name { get; set; }
        public string Date { get; set; }
        public int NumberOfTickets { get; set; }

        public Concert()
        {

        }
        public Concert(string name, string date, int numOfTicks)
        {
            Name = name;
            Date = date;
            NumberOfTickets = numOfTicks;
        }
    }
}
