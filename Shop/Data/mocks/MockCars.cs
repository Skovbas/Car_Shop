using System;
using System.Linq;
using Shop.interfaces;
using Shop.Models;
using System.Collections.Generic;

namespace Shop.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {name = "Tesla",
                        shortDesc = "Fast auto",
                        longDesc = "A beautiful, fast and very quiet car from the Tesla company",
                        img = "/img/tesla.jpeg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {name = "BMW 3",
                        shortDesc = "Fast auto",
                        longDesc = "A comfortable and fast car for every day",
                        img = "/img/bmw.jpeg",
                        price = 26000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {name = "Ford Fiesta",
                        shortDesc = "Quiet and calm",
                        longDesc = "A comfortable car for every day",
                        img = "/img/ford.jpg",
                        price = 19000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}

