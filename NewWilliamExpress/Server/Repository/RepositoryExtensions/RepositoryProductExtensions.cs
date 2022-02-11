using System;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;
using WilliamExpress.Shared.Domain;

namespace WilliamExpress.Server.Repository.RepositoryExtensions
{
    public static class RepositoryItemExtensions
    {
        public static IQueryable<Item> Search(this IQueryable<Item> items, string searchTearm)
        {
            if (string.IsNullOrWhiteSpace(searchTearm))
                return items;

            var lowerCaseSearchTerm = searchTearm.Trim().ToLower();

            return items.Where(p => p.Itemname.ToLower().Contains(lowerCaseSearchTerm));
        }
        public static IQueryable<Item> Sort(this IQueryable<Item> items, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
                return items.OrderBy(e => e.Itemname);

            var orderParams = orderByQueryString.Trim().Split(',');
            var propertyInfos = typeof(Item).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            foreach (var param in orderParams)
            {
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                var direction = param.EndsWith(" desc") ? "descending" : "ascending";
                orderQueryBuilder.Append($"{objectProperty.Name} {direction}, ");
            }

            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');
            if (string.IsNullOrWhiteSpace(orderQuery))
                return items.OrderBy(e => e.Itemname);

            return items.OrderBy(orderQuery);
        }
    }
}
