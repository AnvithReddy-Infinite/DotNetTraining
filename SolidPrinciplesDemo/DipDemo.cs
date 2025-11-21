using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo
{
    // DIP: Dependency Inversion Principle
    public interface IDatabase
    {
        void Save();
    }

    public class SqlDatabase : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("Saving to SQL Database");
        }
    }

    public class NoSqlDatabase : IDatabase
    {
        public void Save()
        {
            Console.WriteLine("Saving to NoSQL Database");
        }
    }

    public class OrderProcessor
    {
        private readonly IDatabase _database;

        // Dependency is injected via constructor, depending on abstraction
        public OrderProcessor(IDatabase database)
        {
            _database = database;
        }

        public void Process()
        {
            Console.WriteLine("Processing order...");
            _database.Save();
        }
    }

    class DipDemo
    {
        static void Main(string[] args)
        {
         

            IDatabase sqlDb = new SqlDatabase();
            OrderProcessor orderWithSql = new OrderProcessor(sqlDb);
            orderWithSql.Process();

            Console.WriteLine();

            IDatabase noSqlDb = new NoSqlDatabase();
            OrderProcessor orderWithNoSql = new OrderProcessor(noSqlDb);
            orderWithNoSql.Process();

            Console.WriteLine("DIP example finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
