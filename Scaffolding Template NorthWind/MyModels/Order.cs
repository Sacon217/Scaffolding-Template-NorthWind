using System;
using System.Collections.Generic;
using System.Text;

namespace Scaffolding_Template_NorthWind.Models
{
    public partial class Order
    {
        public int OrderDuration
        {
            get
            {
                var resultado = 0;
                if (this.ShippedDate != null && this.OrderDate != null) 
                {
                    var diff = this.ShippedDate - this.OrderDate
                    TimeSpan tiempo = diff;
                }
                return resultado;
            }
            set 
            { 
            
            }
        }
    }
}
