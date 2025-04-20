using CarApplication_Mudblazor.Data;
using CarApplication_Mudblazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CarApplication_Mudblazor.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CarRepository(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task<List<Car>> GetCars()
        {
            return await _dbContext.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int id)
        {
            return await _dbContext.Cars.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task SaveCar(Car car)
        {
            if (car.Id == 0)
            {
                _dbContext.Cars.Add(car);
            }
            else
            {
                _dbContext.Cars.Update(car);
            }
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCar(int id)
        {
            var car = await _dbContext.Cars.SingleOrDefaultAsync(x => x.Id == id);
            if (car != null)
            {
                _dbContext.Cars.Remove(car);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}


