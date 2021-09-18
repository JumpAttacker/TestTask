using System.Collections.Generic;

namespace App.Task2
{
    public abstract class BaseStepManager : IStepManager
    {
        protected List<int> Steps { get; } = new();

        public virtual void Add(int step)
        {
            Steps.Add(step);
        }

        public virtual void RemoveLastStep()
        {
            Steps.RemoveAt(Steps.Count - 1);
        }

        public void Clear()
        {
            Steps.Clear();
        }

        public abstract void Print(int target);
    }
}