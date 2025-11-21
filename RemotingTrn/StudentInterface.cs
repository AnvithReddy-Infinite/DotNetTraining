using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingTrn
{
    public interface IStudentService
    {
        string ShowAllStudents();
        string GetStudentDetails(int id);
    }

}
