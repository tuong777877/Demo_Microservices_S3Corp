using StoreCar_Microservice.Entities;
using StoreCar_Microservice.Model;
using StoreCar_Microservice.Repository.Constracts;

namespace StoreCar_Microservice.Repository.Implements
{
    public class CategoryCarRepository : ICategoryCarRepository
    {
        private readonly CarStoreContext _context;
        public CategoryCarRepository(CarStoreContext context)
        {
            _context = context;
        }
        public List<CategoryCarVM> GetAll()
        {
            var catecar = _context.CateCars.Select(cc => new CategoryCarVM
            {
                Id = cc.Id,
                Name = cc.Name,
            });
            return catecar.ToList();
        }
        public CategoryCarVM GetById(int id)
        {
            var catecar = _context.CateCars.SingleOrDefault(cc => cc.Id == id);
            if (catecar != null)
            {
                return new CategoryCarVM
                {
                    Id = catecar.Id,
                    Name = catecar.Name,
                };
            }
            return null;
        }
        public CategoryCarVM Add(CategoryCarModel model)
        {
            var catecar = new CategoryCar
            {
                Name = model.Name,
            };
            _context.Add(catecar);
            _context.SaveChanges();
            return new CategoryCarVM
            {
                Id = catecar.Id,
                Name = catecar.Name,
            };
        }
        public void Update(CategoryCarVM model)
        {
            var catecar = _context.CateCars.SingleOrDefault(cc => cc.Id == model.Id);
            if (catecar != null)
            {
                model.Name = model.Name;
                _context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var catecar = _context.CateCars.SingleOrDefault(cc => cc.Id == id);
            if (catecar != null)
            {
                _context.Remove(catecar);
                _context.SaveChanges();
            }
        }
    }
}
