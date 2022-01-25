using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class XMLHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML file has been opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML file has been created");
        }
        public override void Change()
        {
            Console.WriteLine("XML file has been changed");
        }
        public override void Save()
        {
            Console.WriteLine("XML file has been saved");
        }
    }
}
