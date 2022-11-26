using countrrry;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

internal class Program
{
    public static void Main(string[] args)
    {
        Country country0 = new Country();
        Country country1 = new Country();
        Country country2 = new Country();
        Country country3 = new Country();
        InsertMy(country0);
        List<object> cntrs = new List<object>(20);
        double[] plotnost = new double[20];
        country0.Print(country0.country, country0.capital, country0.square, country0.ppl);
        GetMassive(country0);
        GetMassive(country1);
        Perebor();
        void GetMassive(Country value)
        {
            cntrs.Add(value.country);
            cntrs.Add(value.capital);
            cntrs.Add(value.square);
            cntrs.Add(value.ppl);
            cntrs.Add(value.PopulationDensity(value.ppl, value.square));
            //Perebor();
        }
        void Perebor()
        {
            foreach (var cntr in cntrs)
                Console.Write(cntr + " ");
        }
        //string nazv = Console.ReadLine();
        //Country russia = new Country(Console.ReadLine(), Console.ReadLine(), double.Parse(Console.ReadLine()), ref int.Parse(Console.ReadLine()));
        void InsertMy(Country value)
        {
            Console.WriteLine("Введите название страны, ее столицы, площадь и численность населения");
            value.country = Console.ReadLine();
            value.capital = Console.ReadLine();
            value.square = double.Parse(Console.ReadLine());
            value.ppl = int.Parse(Console.ReadLine());
        }
        
        /*InsertMy();
        InsertMy();
        InsertMy();
        GetMassive();
        Console.WriteLine(country.Print($"{country.country}", $"{country.capital}", double.Parse($"{country.square}"), int.Parse($"{country.ppl}")));*/
        //Console.WriteLine(Country.PPLtndnst(country.ppl, country.square));
        //$"{country.country}", $"{country.capital}", double.Parse($"{country.square}"), int.Parse($"{country.ppl}")
        //Country.Print(country.country, country.capital, country.square, country.ppl);*/
        string znach = "5";
        double naibolshee = 0;
        double raznsot = naibolshee - double.Parse(znach);
        
        //if(raznost>0) naibolshee то же, if (raznost < 0) raznost = znach
    }
}