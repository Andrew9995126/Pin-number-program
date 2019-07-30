using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin_number_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 4 digit PIN number: ");
            int pin1 = int.Parse(Console.ReadLine());

            if (pin1 >= 1000 && pin1 <= 9999)
            { Console.WriteLine("Please enter your PIN again: ");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin1 == pin2)
                Console.WriteLine("Your PIN number has been set!");
                    
                else
                    Console.WriteLine("Your pins did not match.");
                Console.ReadLine();
                
            }
            else
            Console.WriteLine("This PIN number is not within the right parameters");
            Console.ReadLine();
            
            

        
        }
    }
}
