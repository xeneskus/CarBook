using CarBook.Domain.Entities;

namespace CarBook.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarID(int carID);
        void ChangeCarFeatureAvailableToFalse(int id);
        void ChangeCarFeatureAvailableToTrue(int id);
        void CreateCarFeatureByCar(CarFeature carFeature);
    }
}
