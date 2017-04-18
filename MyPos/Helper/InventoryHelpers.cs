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

        //public static void UPDATE_INVENTORY(List<OrderDetail> orderDetails, ActionType action)
        //{
        //    ProductModel model = new ProductModel();
        //    foreach (var orderDetail in orderDetails)
        //    {
        //        var inventoryItem = model.Inventories.Where(o => o.ProductId == orderDetail.ProductId).FirstOrDefault();
        //        if (inventoryItem != null)
        //        {
        //            if (action == ActionType.Export)
        //            {
        //                inventoryItem.Quantity -= orderDetail.Quantity;
        //            }
        //            else
        //            {
        //                inventoryItem.Quantity += orderDetail.Quantity;
        //            }
        //        }
                
        //        //model.Inventories.Attach(inventoryItem);
        //    }
        //    model.SaveChanges();
        //}

        public static void UPDATE_INVENTORY(List<ImportDetail> orderDetails, ActionType action)
        {
            ProductModel model = new ProductModel();
            foreach (var orderDetail in orderDetails)
            {
                var inventoryItem = model.Inventories.Where(o => o.ProductId == orderDetail.ProductId).FirstOrDefault();
                if (action == ActionType.Export)
                {
                    inventoryItem.Quantity -= orderDetail.Quantity;
                }
                else
                {
                    inventoryItem.Quantity += orderDetail.Quantity;
                }
                //model.Inventories.Attach(inventoryItem);
            }
            model.SaveChanges();
        }
    }
}
