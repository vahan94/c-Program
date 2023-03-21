using System;

namespace GeometryLibrary

// Question 1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double circleArea = Geometry.CalculateCircleArea(5);
            double triangleArea = Geometry.CalculateTriangleArea(3, 4, 5);

            Console.WriteLine(circleArea);
            Console.WriteLine(triangleArea);
        }
    }
    
    // Question 2
    
    // SELECT Products.ProductName, Categories.CategoryName
    // FROM Products
    // LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
    // LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID
    // ORDER BY Products.ProductName;
    //
    // В этом запросе используется оператор LEFT JOIN для объединения таблицы Products с таблицами ProductCategory и Categories.
    // Этот оператор возвращает все записи из таблицы Products, 
    // даже если нет соответствующих записей в таблицах ProductCategory или Categories.
    // Если у продукта нет категорий, то его имя все равно будет выведено в результате запроса благодаря оператору LEFT JOIN.
}