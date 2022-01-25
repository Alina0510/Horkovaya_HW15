using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT file has been opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT file has been created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT file has been changed");
        }
        public override void Save()
        {
            Console.WriteLine("TXT file has been saved");
        }
    }
}
