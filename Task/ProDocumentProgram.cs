using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class ProDocumentProgram : DocumentProgram
    {
    
        sealed override public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        override public void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
