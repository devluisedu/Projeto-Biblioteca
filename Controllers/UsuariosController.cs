using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class UsuariosController : Controller 
    {
        public IActionResult ListaUsuarios(){
            Autenticacao.CheckLogin(this);
            //Autenticacao.verificaSeUsuarioEAdmin(this);
            Autenticacao.verificaSeUsuarioAdminExiste(this);
            
            return View(new UsuarioService().Listar());
        }
        public IActionResult editarUsuario(int id){
            Usuario u =new UsuarioService().Listar(id);

            return View(u);
        }

        [HttpPost]
        public IActionResult editarUsuario(Usuario userEditado){
            UsuarioService us= new UsuarioService();
            us.editarUsuario(userEditado);

            return RedirectToAction("ListaUsuarios");
        }



        public IActionResult RegistrarUsuarios(){
            Autenticacao.CheckLogin(this);
            //Autenticacao.verificaSeUsuarioEAdmin(this);
            Autenticacao.verificaSeUsuarioAdminExiste(this);
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarUsuarios(Usuario novoUser){
            Autenticacao.CheckLogin(this);
            //Autenticacao.verificaSeUsuarioEAdmin(this);
            Autenticacao.verificaSeUsuarioAdminExiste(this);

            novoUser.Senha = Criptografo.TextoCriptografado(novoUser.Senha);

            UsuarioService us= new UsuarioService();
            us.incluirUsuario(novoUser);

            return RedirectToAction("cadastroRealizado");
        }
        
        public  IActionResult ExcluirUsuario(int id){
            /*Usuario userEcontrado = new UsuarioService().Listar(id);
            return View(userEcontrado);*/
            return View(new UsuarioService().Listar(id));
        }

        [HttpPost]
        public IActionResult ExcluirUsuario(string decisao,int id){
            if(decisao=="EXLUIR"){
                ViewData["Mensagem"]="Exclusão do usuário "+new UsuarioService().Listar(id).Nome+" realizado com sucesso";
                new UsuarioService().excluirUsuario(id);
                return View("ListaUsuarios",new UsuarioService().Listar());
            }
            else{
                ViewData["Mensagem"]="Exclusão cancelada ";
                return View("ListaUsuarios",new UsuarioService().Listar());
            }
        }

        public IActionResult cadastroRealizado(){
            Autenticacao.CheckLogin(this);
            //Autenticacao.verificaSeUsuarioEAdmin(this);
            Autenticacao.verificaSeUsuarioAdminExiste(this);

            return View();
        }

        public IActionResult NeedAdmin(){
            Autenticacao.CheckLogin(this);
            return View();
        }
        public IActionResult Sair(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

    }
}