using ContosoSalad.Models;
using ContosoSalad.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoSalad.Controllers;

[ApiController]
[Route("[controller]")]
public class SaladController : ControllerBase
{
    public SaladController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Salad>> GetAll() =>
        SaladService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Salad> Get(int id)
    {
        var salad = SaladService.Get(id);

        if(salad == null)
            return NotFound();

        return salad;
    }

    // // POST action
    // [HttpPost]
    // public IActionResult Create(Salad salad)
    // {            
    // }
    
    // // PUT action
    // [HttpPut("{id}")]
    // public IActionResult Update(int id, Salad salad)
    // {
    // }

    // // DELETE action
    // [HttpDelete("{id}")]
    // public IActionResult Delete(int id)
    // {
    // }
}