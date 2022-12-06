using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store("Дискотека", "Проспект Вернадского 78");

            Audio audio1 = new Audio("Linkin Park", "Noname Studio1", 13, "Meteora", "Rock");
            Audio audio2 = new Audio("Limp Bizkit", "Noname Studio2", 15, "Chocolate Starfish And The Hot Dog Flavored Water", "Rock");
            Audio audio3 = new Audio("Кровосток", "Noname Studio3", 15, "Сквозное", "Rap");

            DVD dvd1 = new DVD("Quentin Tarantino", "Miramax", 165, "Pulp Fiction", "Criminal");
            DVD dvd2 = new DVD("Guy Ritchie", "Summit Entertainment", 108, "Lock, Stock And Two Smoking Barrels", "Criminal");

            Store _ = store1 * audio1 * audio2 * audio3 + dvd1 + dvd2;

            Console.WriteLine(store1.ToString());
            dvd1.Burn("Martin Scorsese", "Paramount Pictures", "180", "The Wolf of Wall Street", "Comedy");

            Console.Write(audio1.Name + "\t");
            Console.WriteLine(audio1.DiskSize);
            Console.Write(audio2.Name + "\t");
            Console.WriteLine(audio2.DiskSize);
            Console.Write(audio3.Name + "\t");
            Console.WriteLine(audio3.DiskSize);
            Console.Write(dvd1.Name + "\t");
            Console.WriteLine(dvd1.DiskSize);
            Console.Write(dvd2.Name + "\t");
            Console.WriteLine(dvd2.DiskSize);

            Console.ReadKey();
        }
    }
}
