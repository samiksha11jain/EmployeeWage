﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpWageComputation
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME )
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");            }
        }
    }
}
