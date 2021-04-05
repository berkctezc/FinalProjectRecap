using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Core.DataAccess
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
