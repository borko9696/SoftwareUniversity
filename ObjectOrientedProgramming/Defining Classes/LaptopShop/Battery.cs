namespace LaptopShop
{
    using System;

    public class Battery
    {
        private int capacity;

        private string cellType;

        private double life;

        private int numberOfCells;

        public Battery(int numberOfCells, int capacity, double life)
            : this(null, numberOfCells, capacity, life)
        {
        }

        public Battery(string cellType, int numberOfCells, int capacity, double life)
        {
            this.CellType = cellType;
            this.NumberOfCells = numberOfCells;
            this.Capacity = capacity;
            this.Life = life;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative");
                }
                this.capacity = value;
            }
        }

        public string CellType
        {
            get
            {
                return this.cellType;
            }
            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    this.cellType = "Unknown";
                }
                this.cellType = value;
            }
        }

        public double Life
        {
            get
            {
                return this.life;
            }

            set
            {
                if (value < double.Epsilon)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }

                this.life = value;
            }
        }

        public int NumberOfCells
        {
            get
            {
                return this.numberOfCells;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Value cannot be zero or negative!");
                }

                this.numberOfCells = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh", this.CellType, this.NumberOfCells, this.Capacity);
        }

        public string BatteryLife()
        {
            return String.Format("{0:F1}", this.life);
        }
    }
}