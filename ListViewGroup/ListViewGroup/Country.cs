using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewGroup
{
    class Country : List<City>
    {
        string nameCountry { get; set; }
        public Country(string nameinit)
        {
            nameCountry = nameinit;
        }
    }
}
