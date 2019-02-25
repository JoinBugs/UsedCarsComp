using System;
using System.Collections.Generic;
using UsedCarsComp.Models;

namespace UsedCarsComp.DAL
{
    public interface ICarRepository : IDisposable
    {
        List<Car> GetCars();
        Car GetCarByID(int id);
        bool InsertCar(Car car);
        bool DeleteCar(int id);
        bool UpdateCar(Car car);
    }
}