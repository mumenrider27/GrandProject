using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductNameInvalid = "Invalid product name";
        public static string MaintenanceTime = "System under maintenance";
        public static string ProductsListed = "Products have been listed";
        public static string ProductCountOfCategoryError = "Maximum product number that can be added per category is 10";
        public static string ProductNameAlreadyExists = "A product with the same name already exists";
    }
}
