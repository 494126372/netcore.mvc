using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMvc.Models;


namespace MyMvc.Controllers
{
    public class WelcomeController : Controller
    {
        
        public string   Index(){
           return "this is index !";
        }
        public string  Index1(string name,int age=10){
            return $" hello {name} , my age is { age } ";
        }
    }
}