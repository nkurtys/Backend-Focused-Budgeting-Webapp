namespace Project.API.Internal.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Data.DbContext;
using Data.Entities;
/*docker run --name my-postgres -e POSTGRES_USER=myuser -e POSTGRES_PASSWORD=mypassword -e POSTGRES_DB=mydb -p 5432:5432 -d postgres*/




[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    // DatabaseContext as variable
    private readonly AppDbContext _context;

    // Controller Constructor
    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    // Class Function POST

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody]User user)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return Ok(user);
    }
}



/*// Delete
db.Users.Remove(alice);
db.SaveChanges();

// Read
User users = db.Users.ToList();
foreach (var user in users)
{
    Console.WriteLine($"{user.Id} - {user.Name} - {user.Age}");
}*/
