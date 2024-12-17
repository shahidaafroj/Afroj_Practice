﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var models = new ProductModel[]
                {
                new ProductModel() {PoductModelID = 1, Name = "Classic Vest" },
                new ProductModel() {PoductModelID = 2, Name = "Cycling Cap" },
                new ProductModel() {PoductModelID = 3, Name = "Full-Finger Gloves" },
                new ProductModel() {PoductModelID = 4, Name = "Half-Finger Gloves" },
                new ProductModel() {PoductModelID = 5, Name = "HL Mountain Frame" },
                new ProductModel() {PoductModelID = 6, Name = "HL Road Frame" },
                new ProductModel() {PoductModelID = 7, Name = "HL Touring Frame" },
                new ProductModel() {PoductModelID = 8, Name = "LL Mountain Frame" },
                new ProductModel() {PoductModelID = 9, Name = "LL Road Frame" },
                new ProductModel() {PoductModelID = 10, Name = "LL Touring Frame" },
                new ProductModel() {PoductModelID = 11, Name = "Long-Sleeve Logo Jersey" },
                new ProductModel() {PoductModelID = 12, Name = "Men's Bib-Shorts" },
                new ProductModel() {PoductModelID = 13, Name = "Men's Sports Shorts" },
                new ProductModel() {PoductModelID = 14, Name = "ML Mountain Frame" },
                new ProductModel() {PoductModelID = 15, Name = "ML Mountain Frame-W" },
                new ProductModel() {PoductModelID = 16, Name = "ML Road Frame" },
                new ProductModel() {PoductModelID = 17, Name = "ML Road Frame-W" },
                new ProductModel() {PoductModelID = 18, Name = "Mountain Bike Socks" },
                new ProductModel() {PoductModelID = 19, Name = "Mountain-100" }

                };
            var Categories = new ProductCategory[]
                {
                new ProductCategory() {  ProductCategoryID= 1, Name = "Bikes" },
                new ProductCategory() {  ProductCategoryID= 2, Name = "Components" },
                new ProductCategory() {  ProductCategoryID= 3, Name = "Clothing" },
                new ProductCategory() {  ProductCategoryID= 4, Name = "Accessories" },
                new ProductCategory() {  ProductCategoryID= 5, Name = "Mountain Bikes" },
                new ProductCategory() {  ProductCategoryID= 6, Name = "Road Bikes" },
                new ProductCategory() {  ProductCategoryID= 7, Name = "Touring Bikes" },
                new ProductCategory() {  ProductCategoryID= 8, Name = "Handlebars" },
                new ProductCategory() {  ProductCategoryID= 9, Name = "Bottom Brackets" },
                new ProductCategory() {  ProductCategoryID= 10, Name = "Brakes" },
                new ProductCategory() {  ProductCategoryID= 11, Name = "Chains" },
                new ProductCategory() {  ProductCategoryID= 12, Name = "Cranksets" },
                new ProductCategory() {  ProductCategoryID= 13, Name = "Derailleurs" },
                new ProductCategory() {  ProductCategoryID= 14, Name = "Forks" },
                new ProductCategory() {  ProductCategoryID= 15, Name = "Headsets" },
                new ProductCategory() {  ProductCategoryID= 16, Name = "Mountain Frames" },
                new ProductCategory() {  ProductCategoryID= 17, Name = "Pedals" },
                new ProductCategory() {  ProductCategoryID= 18, Name = "Road Frames" },
                new ProductCategory() {  ProductCategoryID= 19, Name = "Saddles" },
                new ProductCategory() {  ProductCategoryID= 20, Name = "Touring Frames" },
                new ProductCategory() {  ProductCategoryID= 21, Name = "Wheels" },
                new ProductCategory() {  ProductCategoryID= 22, Name = "Bib-Shorts" },
                new ProductCategory() {  ProductCategoryID= 23, Name = "Caps" },
                new ProductCategory() {  ProductCategoryID= 24, Name = "Gloves" },
                new ProductCategory() {  ProductCategoryID= 25, Name = "Jerseys" },
                new ProductCategory() {  ProductCategoryID= 26, Name = "Shorts" },
                new ProductCategory() {  ProductCategoryID= 27, Name = "Socks" },
                new ProductCategory() {  ProductCategoryID= 28, Name = "Tights" },
                new ProductCategory() {  ProductCategoryID= 29, Name = "Vests" },
                new ProductCategory() {  ProductCategoryID= 30, Name = "Bike Racks" },
                new ProductCategory() {  ProductCategoryID= 31, Name = "Bike Stands" },
                new ProductCategory() {  ProductCategoryID= 32, Name = "Bottles and Cages" },
                new ProductCategory() {  ProductCategoryID= 33, Name = "Cleaners" },
                new ProductCategory() {  ProductCategoryID= 34, Name = "Fenders" },
                new ProductCategory() {  ProductCategoryID= 35, Name = "Helmets" },
                new ProductCategory() {  ProductCategoryID= 36, Name = "Hydration Packs" },
                new ProductCategory() {  ProductCategoryID= 37, Name = "Lights" },
                new ProductCategory() {  ProductCategoryID= 38, Name = "Locks" },
                new ProductCategory() {  ProductCategoryID= 39, Name = "Panniers" },
                new ProductCategory() {  ProductCategoryID= 40, Name = "Pumps" },
                new ProductCategory() {  ProductCategoryID= 41, Name = "Tires and Tubes" }
                };
            var Products = new Product[]
                {
                new Product() { ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33,  ProductCategoryID= 18, PoductModelID= 9 },
                new Product() { ProductID = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47,  ProductCategoryID= 18, PoductModelID = 9 },
                new Product() { ProductID = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62,  ProductCategoryID= 18, PoductModelID = 9 },
                new Product() { ProductID = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83,  ProductCategoryID= 18, PoductModelID = 9 },
                new Product() { ProductID = 5, Name = "LL Road Frame - Red, 60", ProductNumber = "FR-R38R-60", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 60, Weight = 1124.9,  ProductCategoryID= 18, PoductModelID = 9 },
                new Product() { ProductID = 6, Name = "LL Road Frame - Red, 62", ProductNumber = "FR-R38R-62", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 62, Weight = 1133.98,  ProductCategoryID= 18, PoductModelID = 9 },
                new Product() { ProductID = 7, Name = "ML Road Frame - Red, 44", ProductNumber = "FR-R72R-44", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 44, Weight = 1006.97,  ProductCategoryID= 18, PoductModelID = 16 },
                new Product() { ProductID = 8, Name = "ML Road Frame - Red, 48", ProductNumber = "FR-R72R-48", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 48, Weight = 1025.11,  ProductCategoryID= 18, PoductModelID = 16 },
                new Product() { ProductID = 9, Name = "ML Road Frame - Red, 52", ProductNumber = "FR-R72R-52", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 52, Weight = 1043.26,  ProductCategoryID= 18, PoductModelID = 16 },
                new Product() { ProductID = 10, Name = "ML Road Frame - Red, 58", ProductNumber = "FR-R72R-58", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 58, Weight = 1070.47,  ProductCategoryID= 18, PoductModelID = 16 },
                new Product() { ProductID = 11, Name = "ML Road Frame - Red, 60", ProductNumber = "FR-R72R-60", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 60, Weight = 1079.54,  ProductCategoryID= 18, PoductModelID = 16 },
                new Product() { ProductID = 12, Name = "HL Mountain Frame - Silver, 44", ProductNumber = "FR-M94S-44", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 44, Weight = 1251.91,  ProductCategoryID= 16, PoductModelID = 5 },
                new Product() { ProductID = 13, Name = "HL Mountain Frame - Silver, 48", ProductNumber = "FR-M94S-52", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 48, Weight = 1270.05,  ProductCategoryID= 16, PoductModelID = 5 },
                new Product() { ProductID = 14, Name = "HL Mountain Frame - Black, 44", ProductNumber = "FR-M94B-44", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 44, Weight = 1251.91,  ProductCategoryID= 16, PoductModelID = 5 },
                new Product() { ProductID = 15, Name = "HL Mountain Frame - Black, 48", ProductNumber = "FR-M94B-48", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 48, Weight = 1270.05,  ProductCategoryID= 16, PoductModelID = 5 },
                new Product() { ProductID = 16, Name = "Road-150 Red, 62", ProductNumber = "BK-R93R-62", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 62, Weight = 6803.85,  ProductCategoryID= 6, PoductModelID = 25 },
                new Product() { ProductID = 17, Name = "Road-150 Red, 44", ProductNumber = "BK-R93R-44", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 44, Weight = 6245.93,  ProductCategoryID= 6, PoductModelID = 25 },
                new Product() { ProductID = 18, Name = "Road-150 Red, 48", ProductNumber = "BK-R93R-48", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 48, Weight = 6409.23,  ProductCategoryID= 6, PoductModelID = 25 },
                new Product() { ProductID = 19, Name = "Road-150 Red, 52", ProductNumber = "BK-R93R-52", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 52, Weight = 6540.77,  ProductCategoryID= 6, PoductModelID = 25 },
                new Product() { ProductID = 20, Name = "Road-150 Red, 56", ProductNumber = "BK-R93R-56", Color = "Red", StandardCost = 2171.2942, ListPrice = 3578.27, Size = 56, Weight = 6658.7,  ProductCategoryID= 6, PoductModelID = 25 },
                new Product() { ProductID = 21, Name = "Road-450 Red, 58", ProductNumber = "BK-R68R-58", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 58, Weight = 8069.37,  ProductCategoryID= 6, PoductModelID = 28 },
                new Product() { ProductID = 22, Name = "Road-450 Red, 60", ProductNumber = "BK-R68R-60", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 60, Weight = 8119.26,  ProductCategoryID= 6, PoductModelID = 28 },
                new Product() { ProductID = 23, Name = "Road-450 Red, 44", ProductNumber = "BK-R68R-44", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 44, Weight = 7606.7,  ProductCategoryID= 6, PoductModelID = 28 },
                new Product() { ProductID = 24, Name = "Road-450 Red, 48", ProductNumber = "BK-R68R-48", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 48, Weight = 7770,  ProductCategoryID= 6, PoductModelID = 28 },
                new Product() { ProductID = 25, Name = "Road-450 Red, 52", ProductNumber = "BK-R68R-52", Color = "Red", StandardCost = 884.7083, ListPrice = 1457.99, Size = 52, Weight = 7901.54,  ProductCategoryID= 6, PoductModelID = 28 },
                new Product() { ProductID = 26, Name = "Road-650 Red, 58", ProductNumber = "BK-R50R-58", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 58, Weight = 8976.55,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 27, Name = "Road-650 Red, 60", ProductNumber = "BK-R50R-60", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 60, Weight = 9026.44,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 28, Name = "Road-650 Red, 62", ProductNumber = "BK-R50R-62", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 62, Weight = 9071.8,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 29, Name = "Road-650 Red, 44", ProductNumber = "BK-R50R-44", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 44, Weight = 8513.88,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 30, Name = "Road-650 Red, 48", ProductNumber = "BK-R50R-48", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 48, Weight = 8677.18,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 31, Name = "Road-650 Red, 52", ProductNumber = "BK-R50R-52", Color = "Red", StandardCost = 486.7066, ListPrice = 782.99, Size = 52, Weight = 8808.72,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 32, Name = "Road-650 Black, 58", ProductNumber = "BK-R50B-58", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 58, Weight = 8976.55,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 33, Name = "Road-650 Black, 60", ProductNumber = "BK-R50B-60", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 60, Weight = 9026.44,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 34, Name = "Road-650 Black, 62", ProductNumber = "BK-R50B-62", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 62, Weight = 9071.8,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 35, Name = "Road-650 Black, 44", ProductNumber = "BK-R50B-44", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 44, Weight = 8513.88,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 36, Name = "Road-650 Black, 48", ProductNumber = "BK-R50B-48", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 48, Weight = 8677.18,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 37, Name = "Road-650 Black, 52", ProductNumber = "BK-R50B-52", Color = "Black", StandardCost = 486.7066, ListPrice = 782.99, Size = 52, Weight = 8808.72,  ProductCategoryID= 6, PoductModelID = 3 },
                new Product() { ProductID = 38, Name = "Mountain-100 Silver, 38", ProductNumber = "BK-M82S-38", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 38, Weight = 9230.56,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 39, Name = "Mountain-100 Silver, 42", ProductNumber = "BK-M82S-42", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 42, Weight = 9421.06,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 40, Name = "Mountain-100 Silver, 44", ProductNumber = "BK-M82S-44", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 44, Weight = 9584.36,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 41, Name = "Mountain-100 Silver, 48", ProductNumber = "BK-M82S-48", Color = "Silver", StandardCost = 1912.1544, ListPrice = 3399.99, Size = 48, Weight = 9715.9,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 42, Name = "Mountain-100 Black, 38", ProductNumber = "BK-M82B-38", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 38, Weight = 9230.56,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 43, Name = "Mountain-100 Black, 42", ProductNumber = "BK-M82B-42", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 42, Weight = 9421.06,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 44, Name = "Mountain-100 Black, 44", ProductNumber = "BK-M82B-44", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 44, Weight = 9584.36,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 45, Name = "Mountain-100 Black, 48", ProductNumber = "BK-M82B-48", Color = "Black", StandardCost = 1898.0944, ListPrice = 3374.99, Size = 48, Weight = 9715.9,  ProductCategoryID= 5, PoductModelID = 19 },
                new Product() { ProductID = 46, Name = "Mountain-300 Black, 38", ProductNumber = "BK-M47B-38", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 38, Weight = 11498.51,  ProductCategoryID= 5, PoductModelID = 21 },
                new Product() { ProductID = 47, Name = "Mountain-300 Black, 40", ProductNumber = "BK-M47B-40", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 40, Weight = 11689.01,  ProductCategoryID= 5, PoductModelID = 21 },
                new Product() { ProductID = 48, Name = "Mountain-300 Black, 44", ProductNumber = "BK-M47B-44", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 44, Weight = 11852.31,  ProductCategoryID= 5, PoductModelID = 21 },
                new Product() { ProductID = 49, Name = "Mountain-300 Black, 48", ProductNumber = "BK-M47B-48", Color = "Black", StandardCost = 598.4354, ListPrice = 1079.99, Size = 48, Weight = 11983.85,  ProductCategoryID= 5, PoductModelID = 21 },
                new Product() { ProductID = 50, Name = "Road-250 Red, 44", ProductNumber = "BK-R89R-44", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 44, Weight = 6699.52,  ProductCategoryID= 6, PoductModelID = 26 },
                new Product() { ProductID = 51, Name = "Road-250 Red, 48", ProductNumber = "BK-R89R-48", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 48, Weight = 6862.82,  ProductCategoryID= 6, PoductModelID = 26 },
                new Product() { ProductID = 52, Name = "Road-250 Red, 52", ProductNumber = "BK-R89R-52", Color = "Red", StandardCost = 1518.7864, ListPrice = 2443.35, Size = 52, Weight = 6994.36,  ProductCategoryID= 6, PoductModelID = 26 },
                new Product() { ProductID = 53, Name = "ML Mountain Frame - Black, 38", ProductNumber = "FR-M63B-38", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 38, Weight = 1238.3,  ProductCategoryID= 16, PoductModelID = 15 },
                new Product() { ProductID = 54, Name = "ML Mountain Frame - Black, 40", ProductNumber = "FR-M63B-40", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 40, Weight = 1256.44,  ProductCategoryID= 16, PoductModelID = 14 },
                new Product() { ProductID = 55, Name = "ML Mountain Frame - Black, 44", ProductNumber = "FR-M63B-44", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 44, Weight = 1274.59,  ProductCategoryID= 16, PoductModelID = 14 },
                new Product() { ProductID = 56, Name = "ML Mountain Frame - Black, 48", ProductNumber = "FR-M63B-48", Color = "Black", StandardCost = 185.8193, ListPrice = 348.76, Size = 48, Weight = 1292.73,  ProductCategoryID= 16, PoductModelID = 14 }
                };
            var myQuery = Products.Select(p => new { p.ProductID, prodName = p.Name, p.ProductNumber, p.Color, p.StandardCost, p.ListPrice, p.Size, p.Weight, p.ProductCategoryID, p.PoductModelID })
                .Join(Categories, pd => pd.ProductCategoryID, c => c.ProductCategoryID, (pd, c) => new { pd.ProductID, pd.prodName, c.Name, pd.ProductNumber, pd.Color, pd.StandardCost, pd.ListPrice, pd.Size, pd.Weight, pd.ProductCategoryID, pd.PoductModelID })
                .Join(models, pc => pc.PoductModelID, m => m.PoductModelID, (pc, m) => new { Name = pc.prodName, Category = pc.Name, Model = m.Name, Number = pc.ProductNumber, Color = pc.Color, Cost = pc.StandardCost, Price = pc.ListPrice, pc.Size, pc.Weight })
                .GroupBy(gbm => gbm.Model);

            foreach (var aProdModelGroup in myQuery)
            {
                int i = 1;
                string underline = "";
                Console.WriteLine(aProdModelGroup.First().Model + ":");
                for (int j = 0; j < aProdModelGroup.First().Model.Length; j++)
                {
                    underline += "-";
                }
                Console.WriteLine(underline);
                foreach (var aProd in aProdModelGroup)
                {
                    Console.WriteLine(i.ToString() + ":" + aProd.Name + "\t" + aProd.Category + "\t" + aProd.Model + "\t" + aProd.Number + "\t" + aProd.Color + "\t" + aProd.Cost + aProd.Price + "\t" + aProd.Size + "\t" + aProd.Weight);
                    i += 1;
                }
                Console.WriteLine("=========Alhamdulillah==========");
                Console.WriteLine();
                Console.WriteLine();
                }
            Console.ReadKey();
        }
    }
}
