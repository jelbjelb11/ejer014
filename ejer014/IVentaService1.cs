using System.Collections.Generic;

namespace ejer014
{
    public interface IVentaService1
    {
        void Create(Venta venta);
        void Delete(long id);
        VentaDTO Read(long id);
        IList<VentaDTO> ReadAll();
        void Update(Venta venta);
    }
}