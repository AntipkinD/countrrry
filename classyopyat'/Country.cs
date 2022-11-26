using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countrrry
{
    class Country
    {
        public string country;
        public string capital;
        public double square;
        public int ppl;
        public Country(string country, string capital, double square, int ppl)
        {
            this.country = country;
            this.square = square;
            this.capital = capital;
            this.ppl = ppl;
        }
        public Country()
        {
            country = "unknown";
            capital = "unknown";
            square = 0;
            ppl = 0;
        }
        public double PopulationDensity(int ppl, double square)
        {
            double result = ppl / square;
            return result;
        }
        internal string Print(string country, string capital, double square, int ppl)
        {
            string all_info = $"Название страны: {country}; столица: {capital}; площадь: {square}; численность населения: {ppl}; плотность населения: {PopulationDensity(ppl, square)}";
            return all_info;
        }
    }
}
