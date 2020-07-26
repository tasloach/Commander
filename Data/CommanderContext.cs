using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    /// <summary>
    /// A class that inherits from <see cref="DbContext"/> for communicating with the database.
    /// </summary>
    public class CommanderContext : DbContext
    {
        /// <inheritdoc cref="DbContext"/>
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
    }
}