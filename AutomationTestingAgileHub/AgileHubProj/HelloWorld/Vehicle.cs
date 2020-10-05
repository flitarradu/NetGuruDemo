using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProj
{
    class Vehicle
    {
        public int NumTires { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public bool Runs { get; set; }

        public Vehicle(string Type, int NumTires, int Year, bool Runs)
        {
            this.Type = Type;
            this.NumTires = NumTires;
            this.Year = Year;
            this.Runs = Runs;
        }

    }
}
