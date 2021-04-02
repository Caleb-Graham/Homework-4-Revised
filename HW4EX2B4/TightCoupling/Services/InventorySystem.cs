using HW4EX2B4.TightCoupling.Interfaces;
using System;

namespace HW4EX2B4.TightCoupling.Services
{
    public class InventorySystem: IInventorySystem
    {
        public string sku { get; set; }
        public int quantity { get; set; }
        public void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}