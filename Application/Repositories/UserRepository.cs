using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using iText.StyledXmlParser.Jsoup.Parser;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        private readonly AnimalsContext _context;

        public UserRepository(AnimalsContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByRefreshTokenAsync(string refreshToken)
        {
            return await _context.Users
                    .Include(u => u.Rols)
                    .Include(u => u.RefreshTokens)
                    .FirstOrDefaultAsync(u => u.RefreshTokens.Any(t => t.Token == refreshToken));
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            return await _context.Users
                    .Include(u => u.Rols)
                    .Include(u => u.RefreshTokens)
                    .FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());
        }
    }
}