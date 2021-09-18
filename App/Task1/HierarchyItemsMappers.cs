using System.Collections.Generic;
using System.Linq;

namespace App.Task1
{
    public static class HierarchyItemsMappers
    {
        public static List<TEntity> ToFlattenHierarchy<TEntity>(this IEnumerable<TEntity> items) where TEntity : IHierarchy<TEntity>
        {
            var result = new List<TEntity>();

            if (items == null) return result;
            foreach (var item in items)
            {
                result.Add(item);
                result.AddRange(item.Children.ToFlattenHierarchy());
            }

            return result;
        }
        
        public static Officer FlatToHierarchy(this IEnumerable<Officer> list)
        {
            var lookup = list
                .Select(category => new Officer(category.Id)
                {
                    ParentId = category.ParentId,
                })
                .ToLookup(category => category.ParentId);

            foreach (var category in lookup.SelectMany(x => x))
                category.Children = lookup[category.Id].ToList();

            var newList = new Officer(-1)
            {
                Children = lookup[0].ToList(),
            };

            return newList;
        }
    }
}