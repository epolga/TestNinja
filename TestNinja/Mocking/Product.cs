using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public class Product
    {
        public float ListPrice { get; set; }

        public float GetPrice(Customer customer)
        {
            if (customer.IsGold)
                return ListPrice * 0.7f;

            return ListPrice;
        }
    }

    public class Customer
    {
        public bool IsGold { get; set; }
    }
}
