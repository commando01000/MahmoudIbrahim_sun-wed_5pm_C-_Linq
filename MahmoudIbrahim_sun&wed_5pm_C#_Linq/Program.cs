using System.Security.Cryptography;
using System.Threading;
using static MahmoudIbrahim_sun_wed_5pm_C__Linq.ListGenerator;

namespace MahmoudIbrahim_sun_wed_5pm_C__Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_1
            // Linq
            // 1. Fluent Syntax
            // 2. Query Syntax
            // 1.
            //var productsList = ProductList.Where(product => product.UnitsInStock == 0);  // Fluent Syntax

            // 2.
            // var productsList = ProductList.Where((product, index) => product.UnitsInStock > 0 && product.UnitPrice > 3); // Fluent Syntax

            // 3.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Select((name, index) => new { name, index })
            //    .Where( x => x.name.Length < x.index )
            //    .Select(x => x.name);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question_2
            // Linq
            // Fluent Syntax
            // 1
            // var productsList = ProductList.OrderBy(product => product.ProductName);
            // 2
            //string[] arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = arr
            //    .OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}

            // 3
            //var productsList = ProductList.OrderByDescending(product => product.UnitsInStock);

            // 4
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //var res = Arr
            //    .OrderByDescending(name => name.Length).ThenBy(name => name)
            //    .Select((name, index) => new { name, index })
            //    .Select(x => x.name);
            #endregion

            #region Question_3
            // Linq
            // 1
            //var productsList = ProductList.Select(product => product.ProductName);

            // 2
            //var output = words.Select(word => new { org = word, low = word.ToLower(), upp = word.ToUpper() });
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var output = from word in words select word.ToLower();

            //var output = from word in words select new {  org = word, low = word.ToLower(), upp = word.ToUpper() };

            // 3
            var custom_products = ProductList.Select(product => new { name = product.ProductName, price = product.UnitPrice });

            #endregion

            foreach (var res in custom_products)
            {
                Console.WriteLine(res);
            }
        }
    }
}
