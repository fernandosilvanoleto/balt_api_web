using System.Threading.Tasks;
using balt_api_web.Data;
using balt_api_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace balt_api_web.Controllers
{
    [Route("v1")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<dynamic>> Get([FromServices] DataContext context)
        {
            var employee = new User { Id = 1, Username = "fernando", Password = "1245", Role = "employee" };
            var manager = new User { Id = 2, Username = "Rafaella", Password = "lily", Role = "manager" };
            var category = new Category { Id = 1, Title = "Informática"};
            var product = new Product { Id = 1, Category = category, Title = "PC Gamer", Price = 5815, Description = "Vem ouro dentro hehehe"};
            context.Users.Add(employee);
            context.Users.Add(manager);
            context.Categories.Add(category);
            context.Products.Add(product);
            await context.SaveChangesAsync();

            return Ok(new {
                message = "Dados configurados"
            });
        }
    }
}