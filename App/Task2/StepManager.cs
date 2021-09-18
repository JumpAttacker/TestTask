using System;
using System.Text;

namespace App.Task2
{
    public class StepManager : BaseStepManager
    {
        public override void Print(int target)
        {
            var str = new StringBuilder();
            str.Append($"{target} = ");
            str.AppendJoin('+', Steps);
            Console.WriteLine(str);
        }
    }
}