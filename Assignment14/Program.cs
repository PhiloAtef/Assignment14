using Day_01_G03;

namespace Assignment14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators


            #region Question 1
            //var outOfStockProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            //Console.WriteLine("Products that are out of stock:");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product);
            //}  
            #endregion

            #region Question 2
            //var inStockAndExpensiveProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            //Console.WriteLine("Products that are in stock and cost more than $3:");
            //foreach (var product in inStockAndExpensiveProducts)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion

            #region Question 3
            //string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = arr.Select((name, index) => new { Name = name, Value = index }).Where(x => x.Name.Length < x.Value).Select(x => x.Value);

            //Console.WriteLine("Digits whose name is shorter than their value:");
            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region Question 1
            //var sortedProducts = ListGenerator.ProductsList.OrderBy(p => p.ProductName);

            //Console.WriteLine("Products sorted by name:");
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region Question 2
            //string[] Arr2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Arr2Sorted = Arr2.OrderBy(item => item.ToLower()).ToList();
            //foreach (var item in Arr2Sorted)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 3
            //var sortByStock = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock).ToList();
            //foreach (var item in sortByStock)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 4
            //string[] Arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Arr3Sorted = Arr3.OrderBy(item => item.Length).ThenBy(item => item).ToList();
            //foreach (var item in Arr3Sorted)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var wordsSorted = words.OrderBy(item => item.Length).ThenBy(item => item.ToLower()).ToList();
            //foreach (var item in wordsSorted)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 6
            //var sortCategoryPriceDesc = ListGenerator.ProductsList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
            //foreach (var item in sortCategoryPriceDesc)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 7
            //string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Arr4Sorted = Arr4.OrderByDescending(p => p.Length).ThenByDescending(p => p.ToLower());
            //foreach (var item in Arr4Sorted)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Question 8
            //string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Arr5Reversed = Arr5.Where(item => item[1].Equals('i')).Reverse();
            //foreach (var item in Arr5Reversed)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #endregion

        }
    }
}
