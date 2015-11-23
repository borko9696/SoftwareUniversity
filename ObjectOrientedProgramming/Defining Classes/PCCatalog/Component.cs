namespace PCCatalog
{
    using System;

    internal class Component
    {
        private string details;

        private string name;

        private decimal price;

        public Component(string name, decimal price)
            : this(name, null, price)
        {
        }

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            private set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }

                this.details = value;
            }
        }

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
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be a negative number!");
                }

                this.price = value;
            }
        }
    }
}