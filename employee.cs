using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using date_accounts;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace date_employee
{
    internal class employee
    {
        int id;
        string name;
        DateTime date;
        private int km;
        private Boolean food;
        int ta;
        int totalta;
        string input = "yes";
       

        public void employeedetails()
        {
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter employee ID:");
            id = Convert.ToInt32(Console.ReadLine());
           
           while(input == "yes")
            {
                Console.WriteLine("Enter date:");
                date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter the number of kilometers travelled:");
                int km = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Did the employee utilize food? (yes/no):");
                string food = Console.ReadLine().ToLower();
               

                int ta = km * 3;
                totalta += ta;

                if (food == "yes")
                {
                    totalta += 100;
                                     
                }

                Console.WriteLine("Your travel expense is:" + ta);
                Console.WriteLine("Your total travel expense is: " + totalta);
                Console.WriteLine("do you want to continue?");
                input = Console.ReadLine().ToLower();
               
            }
            Console.WriteLine("Exiting... Your final total travel expense is: " + totalta);
            Console.ReadLine();
        }
        }
    }

