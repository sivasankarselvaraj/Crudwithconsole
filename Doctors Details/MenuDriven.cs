using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;

namespace Doctors_Details
{
    class MenuDriven
    { 
            private readonly IDoctors Run;
            public MenuDriven()
            {
                Run = new DoctorsRepository();
            }

            int choice;
            public void Select()
            {
                do
                {
                    Console.WriteLine("1-Insert");
                    Console.WriteLine("2-Update");
                    Console.WriteLine("3-GetAll");
                    Console.WriteLine("4-Delete");
                     Console.WriteLine("5-Exit");
                    Console.WriteLine("Enter the Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                            List<Doctors> DoctorsList = new List<Doctors>();
                                Console.WriteLine("Enter the No of Doctors");
                                int NO = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < NO; i++)
                                {
                                     Doctors Add = new Doctors();
                                    Console.WriteLine("Enter the Doctor Name");
                                    Add.DoctorsName = Console.ReadLine();
                                    Console.WriteLine("Enter the Qualification");
                                    Add.Qualification = Console.ReadLine();
                                    Console.WriteLine("Enter the PassoutYear");
                                    Add.PassoutYear = Convert.ToInt64(Console.ReadLine());
                                    Console.WriteLine("Enter the PhoneNUmber");
                                    Add.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                    Console.WriteLine("Enter the Address");
                                    Add.Addresss = Console.ReadLine();
                                    DoctorsList.Add(Add);
                                    Run.Insert(Add);

                            }

                                break;

                            }
                        case 2:
                            {

                                Doctors Replace = new Doctors();
                                Console.WriteLine("Enter the DoctorsID");
                                 long DoctorsID= Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Enter the Doctor Name");
                                Replace.DoctorsName = Console.ReadLine();
                                Console.WriteLine("Enter the Qualification");
                                Replace.Qualification = Console.ReadLine();
                                Console.WriteLine("Enter the PassoutYear");
                                Replace.PassoutYear = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Enter the PhoneNUmber");
                                Replace.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                                Console.WriteLine("Enter the Address");
                                Replace.Addresss = Console.ReadLine();
                                Run.Update(DoctorsID,Replace);



                            break;
                            }

                        
                        case 3:
                            {
                            Run.GetAll();
                                var pro = Run.GetAll();
                            Console.WriteLine(" DoctorsID" + "\t" + "DoctorsName" + "\t" + "Qualification" + "\t" + "PassoutYear" + "\t" + "PhoneNUmber" + "\t" + "Addresss");
                            foreach (Doctors s in pro)
                                {
                                    Console.WriteLine($"{s.DoctorsID} \t {s.DoctorsName}\t {s.Qualification}\t {s.PassoutYear}\t{s.PhoneNumber}\t{s.Addresss}");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter the DoctorsID To Delete");
                                long No = Convert.ToInt64(Console.ReadLine());
                                var Remove = Run.Delete(No);
                               
                           
                                 


                            break;
                            }
                        case 5:
                            {


                                break;
                            }
                    }
                } while (choice < 5);
            }

        }



    
}
