using librarySytstem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        // Add Tables
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<BorrowAndReturn> BorrowAndReturns { get; set; }
    }
}
