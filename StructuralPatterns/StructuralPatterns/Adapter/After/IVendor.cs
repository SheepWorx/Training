using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter.After
{
    public interface IVendor
    {
        string QueryItem(string identifier);
        BasketItem RequestItem(BasketItem item);
        bool CancelItem(BasketItem item);
        bool ConfirmItem(BasketItem item);
    }
}
