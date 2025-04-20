using CarApplication_Mudblazor.Models;


namespace CarApplication_Mudblazor.Services
{
    public interface ICarService
    {
        Task<List<Car>> GetCars();
        Task<Car> GetCarById(int id);
        Task SaveCar(Car car);
        Task DeleteCar(int id);
    }
}
