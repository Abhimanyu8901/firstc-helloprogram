using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace helloprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Program of hello world in c#");
            Console.Write("lets not change the track ");
            Console.WriteLine("What is he is the and what is c is the");
            Console.WriteLine(" finally changed the track");
            
            String input = "THIS IS STRING INPUT";
            Console.WriteLine(input);

            bool t=true;
            Console.WriteLine(t);

            Char x = 'j';
            Console.WriteLine(x);

            Console.WriteLine("type the text  ");
            string takinginput = Console.ReadLine();
            Console.WriteLine(takinginput);

                  //Type Casting
            // char to int ot lang to float to double
            //1. Implicit casting
            int z = 3;
            double y = x;

            //2. Explict casting
            int r = (int)5.4;

            Console.WriteLine(3+3.5);
            float var=Convert.ToInt32((56.74));
            Console.WriteLine(var);

            //Convert.ToDouble(var);
            //Convert.ToString(var);
           
            try
            {
                Console.WriteLine("get more energy");
                string can = Console.ReadLine();
                Console.WriteLine("you will get 4 more energy free  " +
                                 (Convert.ToInt32(can) + 4));
            }
            catch (System.FormatException)
            {
                Console.WriteLine("enter only numbers");
            }




            Console.ReadLine();
        }
    }
}
