using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ServiceOrderManager.Models;


namespace ServiceOrderManager.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            List<Client> list = new List<Client>();
            list.Add(new Client { clientCNPJ = "11111111", enderecoCliente = "rua itaperuna", id = 1, telefone = "33333333" });
            list.Add(new Client { clientCNPJ = "22222222", enderecoCliente = "rua Malta", id = 2, telefone ="44444444" });
            return View(list);
        }
    }
}
