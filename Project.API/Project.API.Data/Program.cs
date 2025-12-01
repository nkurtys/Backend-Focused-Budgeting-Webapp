using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Npgsql;
/*docker run --name my-postgres -e POSTGRES_USER=myuser -e POSTGRES_PASSWORD=mypassword -e POSTGRES_DB=mydb -p 5432:5432 -d postgres*/



namespace Project.API.Data
{
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
                using var conn = new NpgsqlConnection(ConnectionString);
                conn.Open();

                string sql = "INSERT INTO contacts (name, email, message) VALUES (@name, @email, @message)";
                using var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", form.Name);
                cmd.Parameters.AddWithValue("email", form.Email);

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
}

