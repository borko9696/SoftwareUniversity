namespace Shopping_Center
{
    #region

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Wintellect.PowerCollections;

    #endregion

   public class ShoppingCenterMain
    {
        static void Main(string[] args)
        {
            var shopingCenter = new ShoppingCenterStructure();
            
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var input = Console.ReadLine();
                var result = shopingCenter.ParseCommand(input).Trim();
                Console.WriteLine(result);
            }
        }
    }

    public class ShoppingCenterStructure
    {
        private readonly OrderedDictionary<string, OrderedBag<Product>> productByName;

        private readonly Dictionary<string, OrderedBag<Product>> productByNameAndProducer;

        private readonly OrderedDictionary<decimal, OrderedBag<Product>> productByPrice;

        private readonly Dictionary<string, OrderedBag<Product>> productByProducer;

        public ShoppingCenterStructure()
        {
            this.productByProducer = new Dictionary<string, OrderedBag<Product>>();
            this.productByNameAndProducer = new Dictionary<string, OrderedBag<Product>>();
            this.productByName = new OrderedDictionary<string, OrderedBag<Product>>();
            this.productByPrice = new OrderedDictionary<decimal, OrderedBag<Product>>();
        }

        public string ParseCommand(string command)
        {
            int indexOfFirstSpace = command.IndexOf(' ');
            string method = command.Substring(0, indexOfFirstSpace);
            string parameterValues = command.Substring(indexOfFirstSpace + 1);
            string[] parameters = parameterValues.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            switch (method)
            {
                case "AddProduct":
                    return AddProduct(parameters[0], parameters[1], parameters[2]);
                case "DeleteProducts":
                    if (parameters.Length == 1)
                    {
                        return DeleteProductsByProducer(parameters[0]);
                    }
                    else
                    {
                        return DeleteProductsByNameAndProducer(parameters[0], parameters[1]);
                    }
                case "FindProductsByName":
                    return FindProductsByName(parameters[0]);
                case "FindProductsByPriceRange":
                    return FindProductsByPriceRange(parameters[0], parameters[1]);
                case "FindProductsByProducer":
                    return FindProductsByProducer(parameters[0]);
                default:
                    return "Opalq";
            }
        }

        private string AddProduct(string name, string price, string producer)
        {
            var product = new Product { Name = name, Producer = producer, Price = decimal.Parse(price) };
            if (!this.productByProducer.ContainsKey(producer))
            {
                this.productByProducer[producer] = new OrderedBag<Product>();
            }

            this.productByProducer[producer].Add(product);

            var nameAndProducer = name + "!" + producer;
            if (!this.productByNameAndProducer.ContainsKey(nameAndProducer))
            {
                this.productByNameAndProducer[nameAndProducer] = new OrderedBag<Product>();
            }

            this.productByNameAndProducer[nameAndProducer].Add(product);

            if (!this.productByName.ContainsKey(name))
            {
                this.productByName[name] = new OrderedBag<Product>();
            }

            this.productByName[name].Add(product);

            if (!this.productByPrice.ContainsKey(product.Price))
            {
                this.productByPrice[product.Price] = new OrderedBag<Product>();
            }

            this.productByPrice[product.Price].Add(product);

            return "Product added";
        }

        private string DeleteProductsByNameAndProducer(string name, string producer)
        {
            var nameAndProducer = name + "!" + producer;
            if (!this.productByNameAndProducer.ContainsKey(nameAndProducer))
            {
                return "No products found";
            }

            var productsByNameAndProducer = this.productByNameAndProducer[nameAndProducer];

            foreach (var product in productsByNameAndProducer) 
            {
                this.productByName[product.Name].Remove(product);

                this.productByPrice[product.Price].Remove(product);

                this.productByProducer[product.Producer].Remove(product);
            }

            this.productByNameAndProducer.Remove(nameAndProducer);

            return string.Format("{0} products deleted", productsByNameAndProducer.Count);
        }

        private string DeleteProductsByProducer(string producer)
        {
            if (!this.productByProducer.ContainsKey(producer))
            {
                return "No products found";
            }

            var productsByProduceFinds = this.productByProducer[producer];

            foreach (var product in productsByProduceFinds)
            {
                this.productByName[product.Name].Remove(product);

                var nameAndProducer = product.Name + "!" + product.Producer;
                this.productByNameAndProducer[nameAndProducer].Remove(product);

                this.productByPrice[product.Price].Remove(product);
            }

            this.productByProducer.Remove(producer);

            return string.Format("{0} products deleted", productsByProduceFinds.Count);
        }

        private string FindProductsByName(string name)
        {
            if (!this.productByName.ContainsKey(name) || !this.productByName[name].Any())
            {
                return "No products found";
            }

            var bagByName = this.productByName[name];

            return this.Print(bagByName);
        }

        private string FindProductsByPriceRange(string from, string to)
        {
            var start = decimal.Parse(from);
            var end = decimal.Parse(to);
            var bagInRange = this.productByPrice.Range(start, true, end, true);

            var orderBag = new OrderedBag<Product>();
            foreach (var bagWithProducts in bagInRange)
            {
                foreach (var product in bagWithProducts.Value)
                {
                    orderBag.Add(product);
                }
            }
            if (!orderBag.Any())
            {
                return "No products found";
            }

            return this.Print(orderBag);
        }

        private string FindProductsByProducer(string prodcer)
        {
            if (!this.productByProducer.ContainsKey(prodcer))
            {
                return "No products found";
            }

            var bagByProducer = this.productByProducer[prodcer];

            return this.Print(bagByProducer);
        }

        private string Print(IEnumerable<Product> bagProducts)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var product in bagProducts)
            {
                sb.AppendFormat("{{{0};{1};{2:0.00}}}", product.Name, product.Producer, product.Price).AppendLine();
            }

            return sb.ToString();
        }
    }

    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public string Producer { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(Product other)
        {
            if (this == other)
            {
                return 0;
            }
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Producer.CompareTo(other.Producer);
            }
            if (result == 0)
            {
                result = this.Price.CompareTo(other.Price);
            }
            return result;
        }
    }
}