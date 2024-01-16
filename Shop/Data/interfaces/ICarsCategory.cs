using System;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.interfaces
{
	public interface ICarsCategory
	{
		IEnumerable<Category> AllCategories { get; }
	}
}

