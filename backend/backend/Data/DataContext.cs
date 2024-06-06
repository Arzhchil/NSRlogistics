using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    /// <summary>
    /// Контект базы данных
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Models.File> File { get; set; } = null!;
        public DbSet<GraphData> GraphData {  get; set; } = null!;
    }
}
