using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class CustomExceptionDemo
    {
        static void Main(string[] args)

        {

            int age;

            Console.WriteLine("Enter the Age:");

            age = Convert.ToInt32(Console.ReadLine());

            try

            {

                if (age < 21 || age > 80)

                {

                   throw new AgeException(age);

                }

                else

                {

                    Console.WriteLine("Valid Age");

                }

            }

            catch (AgeException ex)

            {

                Console.WriteLine(ex.ToString());

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }

            Console.ReadLine();

        }

    }

}
 
    

