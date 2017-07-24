using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejer014;

namespace ejer014Test
{
    [TestClass]
    public class EntradaControllerIntegracionTest
    {
        private IEntradaController entradaController;
        private EntradaDTO entradaDTO;
        [TestInitialize]
        public void Initialize()
        {
            long l = 1L;
            entradaDTO = new EntradaDTO();
            entradaDTO.id = l;

            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();
            unityContainer.RegisterType<IEntradaController, EntradaController>();

            entradaController = unityContainer.Resolve<IEntradaController>();
        }
        [TestMethod]
        public void CreateMethod()
        {
            EntradaDTO entradaDTO = new EntradaDTO();
            entradaController.Create(entradaDTO);
        }
        [TestMethod]
        public void ReadMethod()
        {
            entradaController.Read(entradaDTO.id);
        }
        [TestMethod]
        public void ReadAllMethod()
        {
            entradaController.Read(entradaDTO.id);
        }
        [TestMethod]
        public void UpdateMethod()
        {
            entradaController.Update(entradaDTO);
        }
        [TestMethod]
        public void DeleteMethod()
        {
            entradaController.Delete(entradaDTO.id);
        }
    }
}
