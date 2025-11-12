using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
        internal class Program
        {
            public static void MethodDivide()
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
                    throw ex;
                }
                catch (System.Exception e)
                {
                    throw new System.Exception(e.Message);
                }
                finally
                {
                    Console.WriteLine("End of the program");
                }
            }
            static void Main(string[] args)
            {
                try
                {
                    MethodDivide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception caught in Main: {ex.Message}");
                }
                Console.ReadLine();
            }
        }
    }