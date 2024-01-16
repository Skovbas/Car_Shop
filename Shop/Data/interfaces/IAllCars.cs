using System;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.interfaces
{
	public interface IAllCars
	{
		IEnumerable<Car> Cars { get; }
		IEnumerable<Car> getFavCars { get;}
		Car getObjectCar(int carId);
	}
}

