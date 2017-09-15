using librarySytstem.Domain.Abstract;
using librarySytstem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Concrete
{
    public class BookRepository : IBookRepository
    {

        private EFDbContext context = new EFDbContext();

        public IQueryable<Book> Books
        {
            get { return context.Books; }
        }
    }
}
