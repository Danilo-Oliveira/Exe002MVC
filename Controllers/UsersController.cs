using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ex002.Models;

namespace Ex002.Controllers
{
    public class UsersController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public IActionResult Details(string nome, DateTime data, float altura, int peso)
        {
           Users users =  new Users();
           users.Nome = nome;

           users.DataNascimento = data;

           users.Altura = altura;

           users.Peso = peso;

            var imc = users.Peso / (users.Altura * users.Altura);
            
            users.Imc = imc;

           switch(data.DayOfWeek)
           {
               case DayOfWeek.Sunday:
               users.DiaSemana = "Domingo";
               break;

               case DayOfWeek.Monday:
               users.DiaSemana = "Segunda-Feira";
               break;

               case DayOfWeek.Tuesday:
               users.DiaSemana = "Terça-Feira";
               break;
               
               case DayOfWeek.Wednesday:
               users.DiaSemana = "Quarta-Feira";
               break;

               case DayOfWeek.Thursday:
               users.DiaSemana = "Quinta-Feira";
               break;

               case DayOfWeek.Friday:
               users.DiaSemana = "Sexta-Feira";
               break;

               case DayOfWeek.Saturday:
               users.DiaSemana = "Sábado";
               break;

               default:
               users.DiaSemana = "Esse dia não existe";
               break;

           }

           return View(users);
        }
    }
}