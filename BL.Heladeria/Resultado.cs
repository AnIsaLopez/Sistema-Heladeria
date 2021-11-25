using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Heladeria
{

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

        internal static IList<Producto> Tolist()
        {
            throw new NotImplementedException();
        }
    }
}
