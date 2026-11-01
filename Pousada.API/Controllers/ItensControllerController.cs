using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pousada.API.Models;

namespace Pousada.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensControllerController : ControllerBase
    {
        private static readonly List<Item> _itens
        {
            id = 1, nome = "Agua Mineral 500ml", preco = 5.00m, descricao: "Agua sem gas",
            id = 2, nome = "Refrigerante Lata", preco = 8.50m, descricao: "Lata 350ml",
            id = 3, nome = "Pacote de Biscoito Artesanal", preco = 12m, descricao: "Biscoito amanteigado caseiro",


        }
      

    }
}
