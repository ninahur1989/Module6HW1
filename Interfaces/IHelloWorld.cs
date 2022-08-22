using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace User.api.Interfaces
{
    public interface IHelloWorld
    {
        public Task<ViewResult> CreateAsync();
        public Task<ViewResult> ListAsync();
        public Task<ActionResult> UpdateAsync(int id);
        public Task<ActionResult> DeleteAsync(int id);
    }
}
