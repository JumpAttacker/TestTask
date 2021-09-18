using System.Collections.Generic;
using System.Linq;

namespace App.Task2
{
    public class TestCaseTwo
    {
        private readonly List<int> _list;
        private readonly IStepManager _stepManager;

        public TestCaseTwo(List<int> list)
        {
            _list = list;
            _stepManager = new StepManager();
        }

        public bool Validate(int target)
        {
            var sort = _list.OrderBy(i => i).ToArray();
            if (sort.All(z => z > target)) return false;

            for (var i = 0; i < sort.Length; i++)
            {
                var sum = target;
                _stepManager.Clear();
                ;
                for (var i2 = 0; i2 < sort.Length; i2++)
                {
                    if (i == i2) continue;

                    sum -= sort[i2];
                    _stepManager.Add(sort[i2]);
                    switch (sum)
                    {
                        case 0:
                            _stepManager.Print(target);
                            return true;
                        case < 0:
                            sum += sort[i2];
                            _stepManager.RemoveLastStep();
                            break;
                    }
                }
            }

            return false;
        }
    }
}