using Microsoft.EntityFrameworkCore;
using WebDiary_API.Models;

namespace WebDiary_API.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<DiaryEntry_cs> DiaryEntry_Cs { get; set; }
    }
}
