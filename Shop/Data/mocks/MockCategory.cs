using System;
using Shop.interfaces;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                    new Category{ categoryName = "Elektro cars", desc = "modern form of transport"},
                    new Category{ categoryName = "Classic cars", desc = "Cars with engine"}
                };
            }
        }
    }
}

