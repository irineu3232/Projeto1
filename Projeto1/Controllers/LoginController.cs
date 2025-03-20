using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;
using System.ComponentModel.DataAnnotations;

namespace Projeto1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _usuarioRepositorio.ObterUsuario(email);
            if(usuario != null && usuario.Senha == senha)
            {
                //Autenticação bem-sucedida
                // return RedirectToAction("Index","Home"); a caso esteja errado ter como trocar rapido.
                // ele retorna se tiver certo da página Login e redireciona para a pagina Home ("Login",depois "Home")
                return RedirectToAction("Login", "Home");
            }
            ModelState.AddModelError("", "Email ou senhas inválidos.");
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            if(ModelState.IsValid)
            {
                _usuarioRepositorio.AdicionarUsuario(usuario);
                return RedirectToAction("Login");
            }
            return View(usuario);
        }
    }
}
