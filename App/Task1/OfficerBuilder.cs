using System.Collections.Generic;
using System.Linq;

namespace App.Task1
{
    public class OfficerBuilder : IOfficerBuilder
    {
        private List<Officer> Officers { get; } = new();

        public List<Officer> Build()
        {
            var flatList = Officers.FlatToHierarchy();
            var result = flatList.Children.ToFlattenHierarchy();
            result.Reverse();
            return result;
        }


        public void AddOfficer(int id, int parentId)
        {
            var officer = Officers.FirstOrDefault(x => x.Id == id);
            if (officer == null)
            {
                officer = new Officer(id)
                {
                    ParentId = parentId
                };

                Officers.Add(officer);
            }
            else if (parentId > 0)
            {
                officer.ParentId = parentId;
            }
        }
    }
}