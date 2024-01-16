using System;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
	public class CarsListViewModel
	{
		public IEnumerable<Car> allCars { get; set; }

		public string currCategory { get; set; }
	}
}

