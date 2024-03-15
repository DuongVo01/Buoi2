using System.Collections.Generic;
using VoTrungDuong_2180604816.Models; // Thay thế bằng namespace thực tế của bạn
namespace VoTrungDuong_2180604816.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
