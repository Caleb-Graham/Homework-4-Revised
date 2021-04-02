using HW4EX2B4.TightCoupling.Interfaces;
using HW4EX2B4.TightCoupling.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4EX2B4.TightCoupling.Model
{
    class Factory
    {
        public static IInventorySystem CreateInventorySystem()
        {
            return new InventorySystem();
        }












    }
}
