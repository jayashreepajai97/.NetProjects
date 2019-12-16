using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class UserDetails
    {

        public string Name
        {
            get;
            set;
        }

        public UserDetails()
        {
            
            Name = string.Empty;
        }
        public UserDetails(string n)
        {
           
            Name = n;
        }
        public void displayData()
        {
           
            Console.WriteLine("Name : {0}", Name);
        }
    }
    class GFG
    {

       
        static void Main(string[] args)
        {
           
            Assembly executing = Assembly.GetExecutingAssembly();

          
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                
                Console.WriteLine("Class : {0}", item.Name);

               
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                   
                    Console.WriteLine("--> Method : {0}", method.Name);

                 
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        
                        Console.WriteLine("----> Parameter : {0} Type : {1}",
                                                arg.Name, arg.ParameterType);
                    }
                }
            }
            Console.ReadLine();
        }
    }
} 

