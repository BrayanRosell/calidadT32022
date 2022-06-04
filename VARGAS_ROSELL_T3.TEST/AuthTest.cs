using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VARGAS_ROSELL_T3.WEB.Controllers;
using VARGAS_ROSELL_T3.WEB.Repositorio;
using VARGAS_ROSELL_T3.WEB.Service;

namespace VARGAS_ROSELL_T3.TEST
{
   
    [TestFixture]
    public class AuthTest
    {
        [Test]

        public void LoginGet()
        {
            var _usuario = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();


            var controller = new AuthController(_usuario.Object, _cookieAuthService.Object);
            var view = controller.Login() as ViewResult;

            Assert.IsNotNull(view);

        }
        [Test]

        public void LoginPost()
        {
            var _usuario = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();


            var controller = new AuthController(_usuario.Object, _cookieAuthService.Object);
            var view = controller.Login("Brayan", "aaaaaaaa") as ViewResult;

            Assert.IsNotNull(view);

        }
        [Test]

        public void RegistrarGet()
        {
            var _usuario = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();


            var controller = new AuthController(_usuario.Object, _cookieAuthService.Object);
            var view = controller.Registrar() as ViewResult;

            Assert.IsNotNull(view);

        }
        [Test]

        public void RegistrarPost()
        {
            var _usuario = new Mock<IUsuarioRepository>();
            var _cookieAuthService = new Mock<ICookieAuthService>();


            var controller = new AuthController(_usuario.Object, _cookieAuthService.Object);
            var view = controller.Registrar("Brayan", "Santa apolonia", "925648731", "brarosell56@gmail.com", "Brayan", "aaaaaaaa") as RedirectToActionResult;

            Assert.IsNotNull(view);

        }
    }
}
