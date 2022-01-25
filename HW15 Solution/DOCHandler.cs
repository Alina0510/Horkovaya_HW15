using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC file has been opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC file has been created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC file has been changed");
        }
        public override void Save()
        {
            Console.WriteLine("DOC file has been saved");
        }
    }
}
