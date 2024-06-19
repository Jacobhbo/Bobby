using Microsoft.EntityFrameworkCore;


namespace DatingProject.Data
{
    public class ProfileService
    {
        private readonly AppDbContext _context;

        public ProfileService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProfileAsync(Profile profile)
        {
            _context.Profiles.Add(profile);
            await _context.SaveChangesAsync();
        }


        public async Task<List<Profile>> GetProfilesAsync()
        {
            return await _context.Profiles.ToListAsync();
        }
    }
}
