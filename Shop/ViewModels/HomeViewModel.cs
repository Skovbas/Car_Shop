using Shop.Models;
using System;
using System.Collections.Generic;

namespace Shop.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Car> favCars { get; set; }
	}
}