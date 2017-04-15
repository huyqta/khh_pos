using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace MyPos.Helper
{
    public static class InventoryHelpers
    {
        public enum ActionType { Import, Export };

        public static void UPDATE_INVENTORY(List<OrderDetail> orderDetails, ActionType action)
        {
            ProductModel model = new ProductModel();
            foreach (var orderDetail in orderDetails)
            {
                var inventoryItem = model.Inventories.Where(o => o.ProductId == orderDetail.ProductId).FirstOrDefault();
                if (action == ActionType.Export)
                {
                    inventoryItem.Quantity -= orderDetail.Quanlity;
                }
                else
                {
                    inventoryItem.Quantity += orderDetail.Quanlity;
                }
                //model.Inventories.Attach(inventoryItem);
            }
            model.SaveChanges();
        }
    }
}
