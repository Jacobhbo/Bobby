using DatingProject.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System;

namespace DatingProject.Services
{
    public class AccountService
    {
        private readonly AppDbContext _context;

        public AccountService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Account> ValidateUserAsync(string username, string password)
        {
            return await _context.Accounts.SingleOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

        public async Task<Account> RegisterUserAsync(string username, string password)
        {
            var account = new Account { UserName = username, Password = password };
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return account;
        }

        public async Task<bool> DeleteAccountAsync(int accountId)
        {
            var account = await _context.Accounts.FindAsync(accountId);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

    }
}
