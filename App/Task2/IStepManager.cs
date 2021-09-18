namespace App.Task2
{
    public interface IStepManager
    {
        void Add(int step);
        void RemoveLastStep();
        void Clear();
        void Print(int target);
    }
}