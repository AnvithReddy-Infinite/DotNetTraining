using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adotnetprj
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Actor { get; set; }
        public string Actress { get; set; }
        public int YOR { get; set; }
    }

    internal class LinqMovies
    {
        public void MovieLinq()
        {
            List<Movies> li = new List<Movies>()
            {
                new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas", Actress="Tamanna", YOR=2015 },
                new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas", Actress="Anushka", YOR=2017 },
                new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini", Actress="Aish", YOR=2010 },
                new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir", Actress="kareena", YOR=2009 },
                new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas", Actress="shraddha", YOR=2019 },
            };

            // 1. display list of movienames acted by prabhas
            var q1 = from m in li
                     where m.Actor == "Prabhas"
                     select m.MovieName;
            Console.WriteLine("1)");
            foreach (var x in q1) Console.WriteLine(x);

            // 2. display list of all movies released in year 2019
            var q2 = from m in li
                     where m.YOR == 2019
                     select m.MovieName;
            Console.WriteLine("\n2)");
            foreach (var x in q2) Console.WriteLine(x);

            // 3. display the list of movies who acted together by prabhas and anushka
            var q3 = from m in li
                     where m.Actor == "Prabhas" && m.Actress == "Anushka"
                     select m.MovieName;
            Console.WriteLine("\n3)");
            foreach (var x in q3) Console.WriteLine(x);

            // 4. display the list of all actress who acted with prabhas
            var q4 = (from m in li
                      where m.Actor == "Prabhas"
                      select m.Actress).Distinct();
            Console.WriteLine("\n4)");
            foreach (var x in q4) Console.WriteLine(x);

            // 5. display the list of all moves released from 2010 - 2018
            var q5 = from m in li
                     where m.YOR >= 2010 && m.YOR <= 2018
                     select m.MovieName;
            Console.WriteLine("\n5)");
            foreach (var x in q5) Console.WriteLine(x);

            // 6. sort YOR in descending order and display all its records
            var q6 = from m in li
                     orderby m.YOR descending
                     select m;
            Console.WriteLine("\n6)");
            foreach (var m in q6) Console.WriteLine($"{m.MovieName}  {m.Actor}  {m.Actress}  {m.YOR}");

            // 7. display max movies acted by each actor (count of movies per actor)
            var q7 = from m in li
                     group m by m.Actor into g
                     select new { Actor = g.Key, Count = g.Count() };
            Console.WriteLine("\n7)");
            foreach (var g in q7) Console.WriteLine($"{g.Actor}  {g.Count}");

            // 8. display the name of all movies which is 5 characters long
            var q8 = from m in li
                     where m.MovieName.Replace(" ", "").Length == 5
                     select m.MovieName;
            Console.WriteLine("\n8)");
            foreach (var x in q8) Console.WriteLine(x);

            // 9. display names of actor and actress where movie released in year 2017, 2009 and 2019
            var q9 = from m in li
                     where m.YOR == 2017 || m.YOR == 2009 || m.YOR == 2019
                     select new { m.Actor, m.Actress, m.YOR, m.MovieName };
            Console.WriteLine("\n9)");
            foreach (var r in q9) Console.WriteLine($"{r.MovieName}  {r.YOR}  {r.Actor}  {r.Actress}");

            // 10. display the name of movies which start with 'b' and ends with 'i'
            var q10 = from m in li
                      let name = m.MovieName.ToLower()
                      where name.StartsWith("b") && name.EndsWith("i")
                      select m.MovieName;
            Console.WriteLine("\n10)");
            foreach (var x in q10) Console.WriteLine(x);

            // 11. display name of actress who not acted with Rajini and print in descending order
            var q11 = from m in li
                      where m.Actor != "Rajini"
                      select m.Actress;
            var q11distinct = (from a in q11.Distinct()
                               orderby a descending
                               select a);
            Console.WriteLine("\n11)");
            foreach (var x in q11distinct) Console.WriteLine(x);

            // 12. display records in following format: movie name     cast (actor-actress)
            var q12 = from m in li
                      select new { m.MovieName, Cast = m.Actor + "-" + m.Actress };
            Console.WriteLine("\n12)");
            Console.WriteLine("MovieName    Cast");
            foreach (var r in q12) Console.WriteLine($"{r.MovieName}    {r.Cast}");
        }
    }
}

