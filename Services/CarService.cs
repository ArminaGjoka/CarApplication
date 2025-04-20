using CarApplication_Mudblazor.Models;
using CarApplication_Mudblazor.Repository;


namespace CarApplication_Mudblazor.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<Car>> GetCars()
        {
            return await _carRepository.GetCars();
        }

        public async Task<Car> GetCarById(int id)
        {
            return await _carRepository.GetCarById(id);
        }

        public async Task SaveCar(Car car)
        {
            await _carRepository.SaveCar(car);
        }

        public async Task DeleteCar(int id)
        {
            await _carRepository.DeleteCar(id);
        }
    }
}
