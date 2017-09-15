using librarySytstem.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Abstract
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
