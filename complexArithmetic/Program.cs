using System;
using System.Numerics;//add in reference

namespace complexArithmetic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //complex addition
            Console.WriteLine("complex addition");
            Complex c1 = new Complex(1, 2);
            Console.WriteLine("c1 is {0}+j{1}",c1.Real,c1.Imaginary);
            Complex c2 = new Complex(1, 3);
            Console.WriteLine("c2 is {0}+j{1}", c2.Real, c2.Imaginary);
            Complex c3 = new Complex();
            c3 = c1 + c2;
            Console.WriteLine("c1+c2 is {0}+j{1}", c3.Real, c3.Imaginary);

            //complex subtraction
            Console.WriteLine("complex subtraction");
            Complex c11 = new Complex(1, 2);
            Console.WriteLine("c1 is {0}+j{1}", c11.Real, c11.Imaginary);
            Complex c21 = new Complex(1, 3);
            Console.WriteLine("c2 is {0}+j{1}", c21.Real, c21.Imaginary);
            Complex c31 = new Complex();
            c31 = c11 - c21;
            Console.WriteLine("c1-c2 is {0}+j{1}", c31.Real, c31.Imaginary);


            //complex multiplication
            Console.WriteLine("complex multiplication");
            Complex c12 = new Complex(1, 2);
            Console.WriteLine("c1 is {0}+j{1}", c12.Real, c12.Imaginary);
            Complex c22 = new Complex(1, 3);
            Console.WriteLine("c2 is {0}+j{1}", c22.Real, c22.Imaginary);
            Complex c32 = new Complex();
            c32 = c12 * c22;
            Console.WriteLine("c1*c2 is {0}+j{1}", c32.Real, c32.Imaginary);

            //complex division
            Console.WriteLine("complex division");
            Complex c13 = new Complex(1, 2);
            Console.WriteLine("c1 is {0}+j{1}", c13.Real, c13.Imaginary);
            Complex c23 = new Complex(1, 3);
            Console.WriteLine("c2 is {0}+j{1}", c23.Real, c23.Imaginary);
            Complex c33 = new Complex();
            c33 = c13 / c23;
            Console.WriteLine("c1/c2 is {0}+j{1}", c33.Real, c33.Imaginary);


        }
    }
}
