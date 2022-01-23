using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_linq
{
    class Program
    {
      static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer (){Name="HP", Frequency=1, HDVolume=1, CDRom=true, MemoryVolume=1, Price=30000, Processor="Baikal", Quantity=2, VideoVolume=1 },
                new Computer (){Name="MSI", Frequency=2, HDVolume=2, CDRom=false, MemoryVolume=1, Price=40000, Processor="AMD", Quantity=4, VideoVolume=1 },
                new Computer (){Name="IRU", Frequency=1, HDVolume=2, CDRom=false, MemoryVolume=2, Price=50000, Processor="AMD", Quantity=6, VideoVolume=2 },
                new Computer (){Name="Lenovo", Frequency=2, HDVolume=1, CDRom=false, MemoryVolume=2, Price=50000, Processor="INTEL", Quantity=10, VideoVolume=2 },
                new Computer (){Name="Irbis", Frequency=2, HDVolume=2, CDRom=true, MemoryVolume=4, Price=60000, Processor="INTEL", Quantity=35, VideoVolume=4 },
                new Computer (){Name="Dexp", Frequency=4, HDVolume=2, CDRom=false, MemoryVolume=4, Price=70000, Processor="INTEL", Quantity=2, VideoVolume=8 }
            };
            Console.Write("Введите процессор: ");
            string processor = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.Processor == processor).ToList();
            Print(computers1);
            Console.ReadKey();

            Console.Write("Объем памяти ОЗУ: ");
            int memoryvolume = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.MemoryVolume>= memoryvolume).ToList();
            Print(computers2);
            Console.ReadKey();

            List<Computer> computers3 = computers.OrderBy(x=>x.Price).ToList();
            Print(computers3);
            Console.ReadKey();

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Processor);
            foreach(IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach(Computer c in gr)
                {
                    Console.WriteLine($"{c.Name}-{c.Frequency}-{c.HDVolume}-{c.CDRom}-{c.MemoryVolume}-{c.Processor}-{c.VideoVolume}-{c.Price}-{c.Quantity}");
                }
            }
            Console.ReadKey();
            Console.WriteLine();
            Computer computer5 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Name}-{computer5.Frequency}-{computer5.HDVolume}-{computer5.CDRom}-{computer5.MemoryVolume}-{computer5.Processor}-{computer5.VideoVolume}-{computer5.Price}-{computer5.Quantity}");
            Console.ReadKey();
            Console.WriteLine();
            Computer computer6 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer6.Name}-{computer6.Frequency}-{computer6.HDVolume}-{computer6.CDRom}-{computer6.MemoryVolume}-{computer6.Processor}-{computer6.VideoVolume}-{computer6.Price}-{computer6.Quantity}");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(computers.Any(x => x.Quantity > 30));
            Console.WriteLine();
            List<Computer> computers8 = computers.Where(x => x.CDRom == true).ToList();
            Print(computers8);
            Console.ReadKey();

        }
        static void Print(List<Computer>computers)
        {
            foreach(Computer c in computers)
            {
                Console.WriteLine($"{c.Name}-{c.Frequency}-{c.HDVolume}-{c.CDRom}-{c.MemoryVolume}-{c.Processor}-{c.VideoVolume}-{c.Price}-{c.Quantity}");
            }
            Console.WriteLine();

        }
            }
}
