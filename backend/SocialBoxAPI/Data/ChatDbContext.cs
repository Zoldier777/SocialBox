using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class ChatDbContext : DbContext
    {
        public ChatDbContext (DbContextOptions<ChatDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
    }
