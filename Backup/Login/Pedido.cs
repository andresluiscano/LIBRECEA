using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Pedido
    {
        public string Item { get; set; }
        public string Precio { get; set; }

        public override string ToString()
        {
            return "Item: " + Item + "  Precio: $" + Precio;
        }
    }
}
