﻿namespace InterestCalculator
{
    using System;

    public delegate decimal CalculateInterest(decimal sum, double interst, int yers);

    internal class InterestCalculator
    {
        private decimal sum;
        private double interest;
        private int years;
        private decimal interestCalculation;
        private CalculateInterest typeOfCalculation;

        public InterestCalculator(decimal sum, double interest, int years, CalculateInterest interstCalculation)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.interestCalculation = interstCalculation(sum, interest, years);
            this.typeOfCalculation = new CalculateInterest(interstCalculation);
        }

        public CalculateInterest TypeOfInterest
        {
            get { return this.TypeOfInterest; }
            set { this.typeOfCalculation = value; }
        }

        public decimal Sum
        {
            get { return this.sum; }
            set { this.sum = value; }
        }

        public double Interest
        {
            get 
            { 
                return this.interest; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sum can't be negative!");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest can't be negative!");
                }

                this.years = value;
            }
        }

        public decimal InterestCalculation
        {
            get
            {
                this.interestCalculation = this.typeOfCalculation(this.Sum, this.Interest, this.Years);
                return this.interestCalculation;
            }
        }

        public override string ToString()
        {
            return this.InterestCalculation.ToString("F4");
        }
    }
}