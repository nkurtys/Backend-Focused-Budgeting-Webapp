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
public class ContactController : ControllerBase
{
    private const string ConnectionString = "Host=127.0.0.1;Port=5432;Database=mydb;Username=myuser;Password=mypassword";

    [HttpPost]
    public IActionResult Post([FromBody]ContactForm form)
    {
        try
        {
            using var db = new AppDbContext();

            // Create
            db.Users.Add(new User { Name = "Alice", Age = 25 });
            db.SaveChanges();



            // Update
            var alice = db.Users.First(u => u.Name == "Alice");
            alice.Age = 26;
            db.SaveChanges();



            cmd.ExecuteNonQuery();

            return Ok(new { status = "Success" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { status = "Error", message = ex.Message });
        }
    }
}

public class ContactForm
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress] public string Email { get; set; }
}


// Delete
db.Users.Remove(alice);
db.SaveChanges();

// Read
var users = db.Users.ToList();
foreach (var user in users)
{
    Console.WriteLine($"{user.Id} - {user.Name} - {user.Age}");
}
