using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class ChinaCity:City
    {
        public ChinaCity(int area)
        {
            if (area > 100)
            {
                Area= area;
            }

            
        }
        public readonly int Area = 100;
        public const string Country="China";
        public string President { get; init; }
       
        public override int Population 
        { 
            get => _population;
            set
            {
                if(value>=100000)
                    _population = value;
            }
        }


    }
}
