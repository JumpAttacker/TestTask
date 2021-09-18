using System.Collections.Generic;

namespace App.Task1
{
    public class Officer : IHierarchy<Officer>
    {
        public Officer(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public List<Officer> Children { get; set; } = new();
    }
}