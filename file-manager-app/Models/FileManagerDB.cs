using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace file_manager_app.Models
{
    public class FileManagerDB : DbContext
    {
        public DbSet<File> File { get; set; }
        public DbSet<Folder> Folder { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Log> Log { get; set; }
    }
}