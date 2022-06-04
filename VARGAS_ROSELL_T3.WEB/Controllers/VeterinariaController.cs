using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VARGAS_ROSELL_T3.WEB.BaseDatos;
using VARGAS_ROSELL_T3.WEB.Models;
using VARGAS_ROSELL_T3.WEB.Repositorio;
using VARGAS_ROSELL_T3.WEB.Service;

namespace VARGAS_ROSELL_T3.WEB.Controllers
{
    [Authorize]
    public class VeterinariaController : Controller
    {
       
       
        private readonly IUsuarioRepository _usuario;
        private readonly ICookieAuthService _cookieAuthService;
        public VeterinariaController(  IUsuarioRepository _usuario, ICookieAuthService _cookieAuthService)
        {
            
            this._usuario = _usuario;
            this._cookieAuthService = _cookieAuthService;
            _cookieAuthService.SetHttpContext(HttpContext);
        }
        [HttpGet]
        public IActionResult Index()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.Animal = _usuario.ListaAnimales();
            return View();
        }
        [HttpGet]
        public IActionResult Registrar()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            ViewBag.Sexo = _usuario.ListaSexos();
            ViewBag.Especie = _usuario.ListaEspecies();
            ViewBag.Raza = _usuario.ListaRazas();
            return View();

        }
        [HttpPost]
        public IActionResult Registrar(string Nombre, DateTime FechaNacimiento, int Idsexo, int Idespecie, int Idraza, string Tamanio, string DatosParticulares)
        {
            
            _cookieAuthService.SetHttpContext(HttpContext);
            _usuario.RegistrarAnimal( Nombre,  FechaNacimiento,  Idsexo,  Idespecie,  Idraza,  Tamanio,  DatosParticulares, HttpContext);
            return RedirectToAction ("Index");
        }
        private Usuario LoggedUser()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var claim = _cookieAuthService.ObtenerClaim();
            var user = _usuario.ObtenerUsuarioLogin(claim);
            return user;
        }
    }
}
