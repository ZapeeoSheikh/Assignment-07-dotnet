using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public int Sum( int a, int b){
            int add = a + b;
            return add;
        }
        public double Sum( double a, double b, double c){
            double add = a + b + c;
            return add;
         }
    }
}


// Muhammad Rameez 
// Assignment 07

        /*
         //Overloading
    Class Calculator
    Sum(int, int)
    Sum(double,double)
    and use them in Program.cs


    //Overriding
    Worker (parent class) : Work() General Work
    Carpenter :  Work() Wood Work
    Blacksmith : Work() Iron Work*/
