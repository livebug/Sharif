
using Microsoft.EntityFrameworkCore;

namespace API_01_AreaCode.Models;
public class AreaCodeContext:DbContext
{
    public AreaCodeContext(DbContextOptions<AreaCodeContext> options)
            : base(options)
    {
    }

    public DbSet<AreaCodeItem> TodoItems { get; set; }
}
