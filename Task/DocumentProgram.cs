using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    interface IDocument
    {
       sealed public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
    internal class DocumentProgram
    {

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        virtual public void  SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }
}
