using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GhasDemoApi
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("{username}")]
        public IActionResult GetUser(string username)
        {
            var conn = new SqlConnection("Server=localhost;Database=Demo;Trusted_Connection=True;");
            conn.Open();


            // ❌ SQL Injection
            var query = $"SELECT * FROM Users WHERE Username = '{username}'";
            var cmd = new SqlCommand(query, conn);


            var reader = cmd.ExecuteReader();
            return Ok("User fetched");
        }
    }
}
