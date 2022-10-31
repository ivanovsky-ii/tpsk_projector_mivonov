using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows;
namespace barbi_shop.barbi_database
{
    internal class db_connect
    {
        private static BarbeShopDBEntities context;
        public static BarbeShopDBEntities get_context()
        {
            if (context == null)
            {
                context = new BarbeShopDBEntities();
                return context;
            }
            else return context;

            
        }
    }
}
