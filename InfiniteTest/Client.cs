using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteTest
{
    public class Client
    {
        IMath math;
        public Client(IMath m)
        {
            math = m;
        }

        public string AddClient(int x, int y)
        {
            // other logic goes here
            // other logic goes here
            return math.Add(x, y);
        }
    }
    public class Client1
    {
        DbInter d;
        public Client1(DbInter m)
        {
            d = m;
        }

        public List<string> AddClient(string st)
        {
            return d.GetData(st);
        }
    }
}
