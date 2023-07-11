using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorpshym
{
    public class PrintWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Printing");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printing");
        }
    }

    public class Epson : PrintWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printing with a epson printer ");
        }
        public override void Print()
        {
            Console.WriteLine("Printing with a epson printer ");
        }

    }
    public class Canon : PrintWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printing with a Canon printer ");
        }
        public override void Print()
        {
            Console.WriteLine("Printing with a Canon printer ");
        }

    }
    public class LaserJet : PrintWindows
    {
        public override void Show()
        {
            Console.WriteLine("Printing with a LaserJet printer ");
        }
        public override void Print()
        {
            Console.WriteLine("Printing with a Laserjet printer ");
        }

    }
}
