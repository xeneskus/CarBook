﻿using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CarBook.Persistence.Repositories.CarRepositories;

public class CarRepository : ICarRepository
{
    private readonly CarBookContext _context;
    public CarRepository(CarBookContext context)
    {
        _context = context;
    }
    public int GetCarCount()
    {
        var value = _context.Cars.Count();
        return value;
    }

    public List<Car> GetCarsListWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).ToList();
        return values;
    }

    public List<Car> GetCarsWithPricings()
    {
        var values = _context.Cars.Include(x => x.Brand).Include(y => y.CarPricings).ThenInclude(z => z.Pricing).ToList();
        return values;
    }

    public List<Car> GetLast5CarsWithBrands()
    {
        var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x => x.CarID).Take(5).ToList();
        return values;
    }
}
