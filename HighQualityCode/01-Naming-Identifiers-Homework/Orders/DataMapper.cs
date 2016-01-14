namespace Orders
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Orders.Models;

    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.CategoriesFileName = categoriesFileName;
            this.ProductsFileName = productsFileName;
            this.OrdersFileName = ordersFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public string CategoriesFileName { get; private set; }

        public string ProductsFileName { get; private set; }

        public string OrdersFileName { get; private set; }

        public IEnumerable<Categories> GetAllCategories()
        {
            var category = this.ReadFileLines(this.categoriesFileName, true);
            return category
                .Select(c => c.Split(','))
                .Select(c => new Categories
                {
                    Id = int.Parse(c[0]),
                    Name = c[1],
                    Description = c[2]
                });
        }

        public IEnumerable<Products> GetAllProducts()
        {
            var products = this.ReadFileLines(this.productsFileName, true);
            return products
                .Select(p => p.Split(','))
                .Select(p => new Products
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    CategoryId = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<Models.Orders> GetAllOrders()
        {
            var orders = this.ReadFileLines(this.ordersFileName, true);
            return orders
                .Select(p => p.Split(','))
                .Select(p => new Models.Orders
                {
                    Id = int.Parse(p[0]),
                    ProductId = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> ReadFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
