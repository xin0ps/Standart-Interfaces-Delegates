using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    static public class start
    {
        public static void Start()
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("[1]-basic\n[2]-pro\n[3]-expert\nyour choice:");
            string? choice = Console.ReadLine();
                if (choice != null)
                {
                    if (choice == "1")
                    {
                        DocumentProgram newdoc = new DocumentProgram();
                        while(true)
                        {
                            Console.Clear();
                            Console.WriteLine("[1]-Open Doc\n[2]-Edit Doc\n[3]-Save Doc\n[4]-Exit\nyour choice:");
                            string? choice1 = Console.ReadLine();
                            if(choice1!=null)
                            {
                                if (choice1 == "1")
                                {
                                    newdoc.OpenDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();  
                                }
                                if (choice1 == "2")
                                {
                                    newdoc.EditDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "3")
                                {
                                    newdoc.SaveDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "4")
                                {
                                    break;
                                }

                            }
                        }
                    }
                    if (choice == "2")
                    {
                        DocumentProgram newdoc = new ProDocumentProgram();
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("[1]-Open Doc\n[2]-Edit Doc\n[3]-Save Doc\n[4]-Exit\nyour choice:");
                            string? choice1 = Console.ReadLine();
                            if (choice1 != null)
                            {
                                if (choice1 == "1")
                                {
                                    newdoc.OpenDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "2")
                                {
                                    newdoc.EditDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "3")
                                {
                                    newdoc.SaveDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "4")
                                {
                                    break;
                                }

                            }
                        }
                    }
                    if (choice == "3")
                    {
                        DocumentProgram newdoc = new ExpertDocument();
                        while (true)
                        {Console.Clear  ();
                            Console.WriteLine("[1]-Open Doc\n[2]-Edit Doc\n[3]-Save Doc\n[4]-Exit\nyour choice:");
                            string? choice1 = Console.ReadLine();
                            if (choice1 != null)
                            {
                                if (choice1 == "1")
                                {
                                    newdoc.OpenDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "2")
                                {
                                    newdoc.EditDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "3")
                                {
                                    newdoc.SaveDocument();
                                    Console.WriteLine("Press any key for continue!");
                                    Console.ReadKey();
                                }
                                if (choice1 == "4")
                                {
                                    break;
                                }

                            }
                        }
                    }
                }
                else { Console.WriteLine("Choice is wrong!"); }
            }
        }
    }
}
