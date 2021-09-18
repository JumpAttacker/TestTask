using System.Collections.Generic;

namespace App.Task1
{
    public interface IOfficerBuilder
    {
        public List<Officer> Build();
        public void AddOfficer(int id, int parentId);
    }
}