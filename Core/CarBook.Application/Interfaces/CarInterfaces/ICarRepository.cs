using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces;

public interface ICarRepository
{
    List<Car> GetCarsListWithBrands();
    List<Car> GetLast5CarsWithBrands();
    int GetCarCount();
}
