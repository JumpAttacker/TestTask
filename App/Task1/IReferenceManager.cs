using System.Collections.Generic;

namespace App.Task1
{
    public interface IReferenceManager
    {
        public IStringParser StringParser { get; set; }
        public List<int> FindPath(string input);
    }
}