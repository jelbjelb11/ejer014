using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer014
{
    public interface IVentaController
    {
        void Create(VentaDTO ventaDTO);
        VentaDTO Read(long id);
        //VentaDTO Leer(VentaDTO ventaDTO);
        IList<VentaDTO> ReadAll();
        void Update(VentaDTO ventaDTO);
        void Delete(long id);

    }
}
