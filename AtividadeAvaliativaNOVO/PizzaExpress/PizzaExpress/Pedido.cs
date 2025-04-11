using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExpress
{
    public class Pedido
    {
        public List<string> itensSelecionados { get; set; } = new List<string>();
        public int quantidade;
        public double vrUnitario;
        public double total;
    }
}
