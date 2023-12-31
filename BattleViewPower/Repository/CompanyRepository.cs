﻿using BattleViewPower.Contacts;
using BattleViewPower.Context;
using BattleViewPower.Models;
using Dapper;

namespace BattleViewPower.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DapperContext _context;

        public CompanyRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            var query = "SELECT * FROM companies";

            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<Company>(query);
                return companies.ToList();
            }
        }

        public Task<IEnumerable<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        //public Task<IEnumerable<User>> GetUser()
        //{
        //    var query = "SELECT * FROM users";

        //    using (var connection = _context.CreateConnection())
        //    {
        //        var users = await connection.QueryAsync<User>(query);
        //        return users.ToList();
        //    }
        //}
    }
}
