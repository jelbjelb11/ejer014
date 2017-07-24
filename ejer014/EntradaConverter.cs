using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public class EntradaConverter : IEntradaConverter
    {
        public Entrada DTOToEntity(EntradaDTO ventaDTO)
        {
            Entrada resultado = new Entrada();
            resultado.id = ventaDTO.id;
            return resultado;
        }

        public EntradaDTO EntityToDTO(Entrada venta)
        {
            EntradaDTO resultado = new EntradaDTO();
            resultado.id = venta.id;
            return resultado;
        }
    }
}
