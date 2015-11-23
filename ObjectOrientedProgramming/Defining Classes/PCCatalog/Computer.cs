namespace PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Computer
    {
        private string name;

        private decimal price;

        public Computer(string name)
            : this(name, new Dictionary<string, Component>())
        {
        }

        public Computer(string name, Dictionary<string, Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.Price = 0.00m;
        }

        public Dictionary<string, Component> Components { get; private set; }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Name must have a value!");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                if (this.Components.Count == 0)
                {
                    this.price = 0.00m;
                }
                else
                {
                    this.price = 0.00m;
                    foreach (var component in this.Components)
                    {
                        this.price += component.Value.Price;
                    }
                }

                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public void DisplayInfo()
        {
            var sb = new StringBuilder();
            sb.Append(string.Format("Name: {0}\n", this.Name));
            if (this.Components.Count == 0)
            {
                sb.Append("Add components to PC configuration!\n");
            }
            else
            {
                foreach (var component in this.Components)
                {
                    sb.Append(
                        string.Format(
                            "{0}: {1}, {2}\nPrice: {3:C}\n",
                            component.Key,
                            component.Value.Name,
                            component.Value.Details ?? string.Empty,
                            component.Value.Price));
                }
            }

            sb.Append(string.Format("Total price: {0:C}\n", this.Price));
            Console.WriteLine(sb.ToString());
        }
    }
}