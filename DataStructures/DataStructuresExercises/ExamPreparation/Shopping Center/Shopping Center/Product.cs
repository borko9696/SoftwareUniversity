﻿//namespace Shopping_Center
//{
//    #region

//    using System;

//    #endregion

//    public class Product : IComparable<Product>
//    {
//        public string Name { get; set; }

//        public decimal Price { get; set; }

//        public string Producer { get; set; }

//        public int CompareTo(Product other)
//        {
//            if (this == other)
//            {
//                return 0;
//            }

//            int result = this.Name.CompareTo(other.Name);

//            if (result == 0)
//            {
//                result = this.Producer.CompareTo(other.Producer);
//            }

//            if (result == 0)
//            {
//                result = this.Price.CompareTo(other.Price);
//            }

//            return result;
//        }
//    }
//}