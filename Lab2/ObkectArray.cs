using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.NewFolder
{
    using System;
    class Employee
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }
     class ObkectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }
            Console.WriteLine("THe int array...");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }
            Console.WriteLine("\nThe employee array...");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
        static void Main(String[] args)
        {
            ObkectArray arr = new ObkectArray();
            arr.Run();
            Console.ReadLine();
        }
    }
}
