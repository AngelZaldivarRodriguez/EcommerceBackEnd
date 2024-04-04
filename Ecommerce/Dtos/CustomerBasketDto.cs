using Core.Entitites;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();
    }
}
