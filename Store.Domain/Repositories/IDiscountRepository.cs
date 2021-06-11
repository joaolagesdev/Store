using Store.Domain.Entities;

namespace Store.Domain.Repositories
{
    public interface IDiscountRepository
    {
         Discount GetDiscount(string code);
    }
}