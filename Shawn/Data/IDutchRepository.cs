using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shawn.Data.Entities;

namespace Shawn.Data
{
  public interface IDutchRepository
  {
    IEnumerable<Product> GetAllProducts();
    IEnumerable<Product> GetProductsByCategory(string category);

    IEnumerable<Order> GetAllOrders(bool includeItems);
    Order GetOrderById(int id);

    bool SaveAll();
    void AddEntity(object model);
  }
}