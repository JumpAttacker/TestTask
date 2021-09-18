using System;
using System.Collections.Generic;
using System.Text;

namespace App.Task1
{
    public class OutputFormatter
    {
        public void Print(IEnumerable<int> array)
        {
            var strBuilder = new StringBuilder();

            Console.WriteLine(strBuilder.AppendJoin(", ", array));
        }
    }
}