using Microsoft.AspNetCore.Mvc;
using Models;
using User.api.Data;
using User.api.Interfaces;
using System.Threading.Tasks;

namespace User.api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public sealed class HelloWorldController : Controller, IHelloWorld
    {
        public Provider provider = new Provider();

        [HttpGet]
        public  async Task<ViewResult> ListAsync()
        {
            return  View( await provider.GetListAsync());
        }
       
        [HttpGet]
        public async Task<ViewResult> CreateAsync()
        {
            var user = new CreateUserParameters() { Job = "teacher", Name = "MAX" , Id = 4, Salary = 1032 };
            return View(await provider.CreateAsync(user));
        }

        [HttpPost]
        // GET: HelloWorld/update?id=2
        public async Task<ActionResult> UpdateAsync(int id)
        {
            if (id >0 && id<Provider.Mylist.Count)
            {
                Provider.Mylist[id].Name = " changed by user";
            }

            return View(await provider.GetListAsync());
        }

        [HttpDelete]
        // Delete: HelloWorld/Delete?id=2
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (id > 0 && id < Provider.Mylist.Count)
            {
                Provider.Mylist.RemoveAt(id);
            }

            return View( await provider.GetListAsync());
        }
    }
}
