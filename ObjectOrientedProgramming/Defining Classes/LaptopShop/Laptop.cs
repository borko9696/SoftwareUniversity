namespace LaptopShop
{
    using System;
    using System.Text;

    public class Laptop
    {
        private string batteryInfo;

        private string batteryLife;

        private string graphicsCard;

        private string hdd;

        private string manufacturer;

        private string model;

        private decimal price;

        private string processor;

        private string ram;

        private string screen;

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, Battery battery, decimal price)
            : this(model, null, null, null, null, null, null, battery, price)
        {
        }

        public Laptop(string model, string manufacturer, decimal price)
            : this(model, manufacturer, null, null, null, null, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, decimal price)
            : this(model, null, null, memory, null, disk, null, null, price)
        {
        }

        public Laptop(string model, string memory, string disk, Battery battery, decimal price)
            : this(model, null, null, memory, null, disk, null, battery, price)
        {
        }

        public Laptop(
            string model,
            string manufacturer,
            string processor,
            string ram,
            string graphicsCard,
            string hdd,
            string screen,
            Battery battery,
            decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RAM = ram;
            this.GraphicsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.BatteryInfo = battery != null ? battery.ToString() : null;
            this.BatteryLife = battery != null ? battery.BatteryLife() : null;
            this.Price = price;
        }

        public string BatteryInfo
        {
            get
            {
                return this.batteryInfo;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.batteryInfo = value;
            }
        }

        public string BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.batteryLife = value;
            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.graphicsCard = value;
            }
        }

        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.hdd = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Model must have a value!");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be a negative number!");
                }

                this.price = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.processor = value;
            }
        }

        public string RAM
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.ram = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null)
                {
                    if (value.Trim() == string.Empty)
                    {
                        throw new ArgumentException("Value must be either null or non-empty string!");
                    }
                }
                this.screen = value;
            }
        }

        public override string ToString()
        {
             var sb = new StringBuilder();
            sb.Append(string.Format("{0,-15}{1}\n", "Model: ", this.Model));
            if (this.BatteryInfo != null && this.RAM == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }
            else if (this.Manufacturer != null && this.Processor == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Manufacturer: ", this.Manufacturer));
            }
            else if (this.RAM != null && this.BatteryInfo == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.RAM));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.HDD));
            }
            else if (this.RAM != null && this.BatteryInfo != null && this.Manufacturer == null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.RAM));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.HDD));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }
            else if (this.Manufacturer != null && this.Processor != null)
            {
                sb.Append(string.Format("{0,-15}{1}\n", "Manufacturer: ", this.Manufacturer));
                sb.Append(string.Format("{0,-15}{1}\n", "Processor: ", this.Processor));
                sb.Append(string.Format("{0,-15}{1}\n", "Memory: ", this.RAM));
                sb.Append(string.Format("{0,-15}{1}\n", "Graphics card: ", this.GraphicsCard));
                sb.Append(string.Format("{0,-15}{1}\n", "Disk: ", this.HDD));
                sb.Append(string.Format("{0,-15}{1}\n", "Screen: ", this.Screen));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery: ", this.BatteryInfo));
                sb.Append(string.Format("{0,-15}{1}\n", "Battery life: ", this.BatteryLife));
            }

            sb.Append(string.Format("{0,-15}{1}lv\n", "Price: ", this.Price));
            return sb.ToString();
        
        }


    }
}