using countrrry;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

internal class Program
{
    public static void Main(string[] args)
    {
        List<string> cntrs = new List<string>(4);
        List<double> plotnost = new List<double>(4);

        Country country0 = new Country();
        Country country1 = new Country();
        Country country2 = new Country();
        Country country3 = new Country();

        InsertMy(country0);
        InsertMy(country1);
        /*InsertMy(country2);
        InsertMy(country3);*/

        GetMassive(country0);
        GetMassive(country1);
        /*GetMassive(country2);
        GetMassive(country3);*/
        Perebor();
        //метод, заполняющий листы
        void GetMassive(Country value)
        {
            cntrs.Add(value.Print(value.country, value.capital, value.square, value.ppl));
            plotnost.Add(value.PopulationDensity(value.ppl, value.square));
        }
        //метод выводящий значения, хранящиеся в листе стран:
        void Perebor()
        {
            foreach (var value_znach in cntrs)
                Console.WriteLine(value_znach + "\n");
        }
        //метод, позволяющий вводить характеристики государств:
        void InsertMy(Country value)
        {
            Console.WriteLine("Введите название страны, ее столицы, площадь и численность населения");
            Console.Write("Название: ");
            value.country = Console.ReadLine();
            Console.Write("Столица: ");
            value.capital = Console.ReadLine();
            Console.Write("Площадь: ");
            value.square = double.Parse(Console.ReadLine());
            Console.Write("Численность: ");
            value.ppl = int.Parse(Console.ReadLine());
        }
        //метод, позволяющий выводить характеристики страны с максимальной плотностью населения:
        void MaxCountryDensity()
        {
            int maxIndex = plotnost.IndexOf(plotnost.Max());
            Console.WriteLine(cntrs[maxIndex]);
        }
        MaxCountryDensity();
    }
}