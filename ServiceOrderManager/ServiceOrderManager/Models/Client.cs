using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceOrderManager.Models
{
    public class Client
    {
        public int id { get; set; }
        public string clientCNPJ { get; set; }
        public string enderecoCliente { get; set; }
        public string telefone { get; set; }

    }
}
