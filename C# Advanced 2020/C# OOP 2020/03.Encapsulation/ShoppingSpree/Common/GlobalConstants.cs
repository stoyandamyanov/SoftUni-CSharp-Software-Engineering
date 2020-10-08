using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Common
{
    public static class GlobalConstants
    {
        public static string InvalidNameExceptionMessage = "Name cannot be empty";

        public static string InvalidCostInputExceptionMessage = "Money cannot be negative";

        public static string InsufficientMoneyExceptionMessage = "{0} can't afford {1}";

        public static decimal MIN_COST = 0m;
    }
}
