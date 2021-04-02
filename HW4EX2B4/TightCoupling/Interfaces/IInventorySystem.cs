using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Interfaces
{
    public interface IInventorySystem
    {
        string sku { get; set; }
        int quantity { get; set; }

        void Reserve(string sku, int quantity);
    }
}
