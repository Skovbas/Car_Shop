using System;
using Shop.interfaces;
using Shop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        IEnumerable<Category> ICarsCategory.AllCategories => appDBContent.Category;
    }
}

