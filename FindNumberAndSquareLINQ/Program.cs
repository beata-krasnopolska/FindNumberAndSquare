using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumberAndSquareLINQ
{
    class Program
    {
        //Program finds numbers higher than 5 form the list of given numbers and than sguare them
        static void Main(string[] args)
        {
            List<int> myList = new List<int> { 0, 11, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query1 = from number in myList
                         let sqrNo = number * number
                         where number > 5
                         select new { number, sqrNo };

            foreach (var i in query1)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
