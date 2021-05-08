using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public DateTime? Date { get; set; }
    }
}