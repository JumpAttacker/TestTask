using System.Collections.Generic;

namespace App.Task1
{
    public interface IHierarchy<T>
    {
        public List<T> Children { get; set; }
    }
}