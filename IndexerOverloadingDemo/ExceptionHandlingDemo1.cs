using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class ExceptionHandlingDemo1
    {
        static void Main(string[] args)
        {
            try
            {
                int x, y, z;
                Console.WriteLine("enter 2 numbers");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine(z);
            }
            catch (DivideByZeroException ex)
            {
                throw new System.Exception($"Exception occured while divide by 0{ex.Message} \n source :{ex.Source}");

            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            Console.ReadLine();
        }
    }
}
