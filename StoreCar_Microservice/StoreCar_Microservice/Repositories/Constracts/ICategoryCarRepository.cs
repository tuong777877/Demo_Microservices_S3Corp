using StoreCar_Microservice.Model;

namespace StoreCar_Microservice.Repository.Constracts
{
    public interface ICategoryCarRepository
    {
        List<CategoryCarVM> GetAll();
        CategoryCarVM GetById(int id);
        CategoryCarVM Add(CategoryCarModel model);
        void Update(CategoryCarVM model);
        void Delete(int id);
    }
}
