using BattleViewPower.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace BattleViewPower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly IConfiguration _config;
        public SuperHeroController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllSuperHeros()
        {
            using var connection = new NpgsqlConnection(_config.GetConnectionString("connectionString"));
            connection.Open();
            var company = await connection.QueryAsync<SuperHero>("select * from superheros");
            return Ok(company);
        }
    }
}
