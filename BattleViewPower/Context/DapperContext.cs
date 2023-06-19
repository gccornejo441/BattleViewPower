using BattleViewPower.Models;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;
using System.Data.Common;

namespace BattleViewPower.Context
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("connectionString");
        }

        public IDbConnection CreateConnection() => new NpgsqlConnection(_connectionString);
    }
}
