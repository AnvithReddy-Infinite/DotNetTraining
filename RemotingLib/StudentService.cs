using RemotingTrn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingLib
{
    public class StudentService : MarshalByRefObject, IStudentService
    {
        private Dictionary<int, (string Name, string Class, int TotalMarks, char Gender)> students =
            new Dictionary<int, (string, string, int, char)>
            {
                [1] = ("Amit", "10th", 550, 'M'),
                [2] = ("Neha", "9th", 420, 'F'),
                [3] = ("Arjun", "11th", 490, 'M'),
                [4] = ("Sneha", "12th", 310, 'F')
            };

        public string ShowAllStudents()
        {
            string result = "All Students:\n";
            foreach (var kv in students)
                result += $"ID {kv.Key}: {kv.Value.Name}, Class: {kv.Value.Class}, Total Marks: {kv.Value.TotalMarks}\n";
            return result;
        }

        public string GetStudentDetails(int id)
        {
            if (!students.TryGetValue(id, out var data) || id == 0)
                return "Default, Class: Unknown, Total Marks: 500";
            if (data.TotalMarks < 300)
                return "Student has insufficient marks (below 300)";
            return $"{data.Name}, Class: {data.Class}, Total Marks: {data.TotalMarks}";
        }
    }
}
