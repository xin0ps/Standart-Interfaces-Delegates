using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class ExpertDocument:ProDocumentProgram
    {
       override public void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
