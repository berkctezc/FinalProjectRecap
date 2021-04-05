using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int categoryId);
        void Add(Color color);
        void Delete(Color color);
        void Update(Color color);
    }
}
