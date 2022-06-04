using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VARGAS_ROSELL_T3.WEB.Controllers;
using VARGAS_ROSELL_T3.WEB.Models;
using VARGAS_ROSELL_T3.WEB.Repositorio;
using VARGAS_ROSELL_T3.WEB.Service;

namespace VARGAS_ROSELL_T3.TEST
{
    [TestFixture]
    public class VeterinariaTest
    {
        [Test]
        public void IndexGet()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new VeterinariaController(_context.Object, _cookieAuthService.Object);
            var view = controller.Index() as ViewResult;

            Assert.IsNotNull(view);
        }
        
        [Test]
        public void RegistrarGet()
        {
            var _context = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();
            _cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            var controller = new VeterinariaController(_context.Object, _cookieAuthService.Object);
            var view = controller.Registrar() as ViewResult;

            Assert.IsNotNull(view);
        }
        public void RegistrarPost()
        {
            //var _context = new Mock<IUsuarioRepository>();
            //var _cookieAuthService = new Mock<ICookieAuthService>();
            //_cookieAuthService.Setup(o => o.LoggedUser()).Returns(new Usuario());
            //var controller = new VeterinariaController(_context.Object, _cookieAuthService.Object);

            //var view = controller.Registrar("Nombre", "2021 - 09 - 07 00:00:00.000", "Tamanio", "DatosParticulares") as ViewResult;

            //Assert.IsNotNull(view);
        }
    }
}
