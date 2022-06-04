using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VARGAS_ROSELL_T3.WEB.BaseDatos;
using VARGAS_ROSELL_T3.WEB.Models;
using VARGAS_ROSELL_T3.WEB.Service;

namespace VARGAS_ROSELL_T3.WEB.Repositorio
{
    public interface IUsuarioRepository
    {

        public Usuario ObtenerUsuarioLogin(Claim claim);
        public Usuario EncontrarUsuario(String user, String password);
        public void AgregarUsuario(string Nombre, string Direccion, string Telefono, string Email, string Username, string Password);
        public Dictionary<int, String> IndicesPorId();
        public List<Animal> ListaAnimales();
        public List<Sexo> ListaSexos();
        public List<Especie> ListaEspecies();
        public List<Raza> ListaRazas();
        void RegistrarAnimal(string Nombre, DateTime FechaNacimiento, int Idsexo, int Idespecie, int Idraza, string Tamanio, string DatosParticulares, HttpContext httpContext);


    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private VeterinariaContext _context;
        private readonly ICookieAuthService _cookieAuthService;
        public UsuarioRepository(VeterinariaContext context, ICookieAuthService _cookieAuthService)
        {
            _context = context;
            this._cookieAuthService = _cookieAuthService;
        }

        public Usuario EncontrarUsuario(string user, string password)
        {
            var Usuario = _context._Usuarios.FirstOrDefault(o => o.Username == user && o.Password == password);
            return Usuario;
        }

        public void AgregarUsuario(string Nombre, string Direccion, string Telefono, string Email, string Username, string Password)
        {
            Usuario nuevo = new Usuario();
            
            nuevo.Nombre = Nombre;
            nuevo.Direccion = Direccion;
            nuevo.Telefono = Telefono;
            nuevo.Email = Email;
            nuevo.Username = Username;
            nuevo.Password = Password;
            _context._Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public Dictionary<int, string> IndicesPorId()
        {
            Dictionary<int, string> indices = new Dictionary<int, string>();
            var usuarios = _context._Usuarios.ToList();

            foreach (var item in usuarios)
            {
                indices.Add(item.IdUsuario, item.Nombre);
            }

            return indices;
        }

        public Usuario ObtenerUsuarioLogin(Claim claim)
        {
            var user = _context._Usuarios.FirstOrDefault(o => o.Username == claim.Value);
            return user;
        }

        public List<Animal> ListaAnimales()
        {
           return _context._Animales.Include(o => o.Especies)
                .Include(o => o.Sexos)
                .Include(o => o.Razas)
                .Include(o => o.Usuarios).ToList();
        }

        public List<Sexo> ListaSexos()
        {
            return _context._sexo.ToList();
        }

        public List<Especie> ListaEspecies()
        {
            return _context._especie.ToList();
        }

        public List<Raza> ListaRazas()
        {
           return _context._raza.ToList();
        }

        public void RegistrarAnimal(string Nombre, DateTime FechaNacimiento, int Idsexo, int Idespecie, int Idraza, string Tamanio, string DatosParticulares, HttpContext httpContext)
        {
            _cookieAuthService.SetHttpContext(httpContext);
            Animal animal = new Animal();
            animal.FechaRegistro = DateTime.Now;
            animal.Nombre = Nombre;
            animal.FechaNacimiento = FechaNacimiento;
            animal.Tamanio = Tamanio;
            animal.DatosParticulares = DatosParticulares;
            animal.IdSexo = Idsexo;
            animal.IdEspecie = Idespecie;
            animal.IdRaza = Idraza;
            animal.IdUsuario = _cookieAuthService.LoggedUser().IdUsuario;
            _context.Add(animal);
            _context.SaveChanges();
        }
    }
}
