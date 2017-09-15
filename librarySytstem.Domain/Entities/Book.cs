using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Summary { get; set; }
        public string Author { get; set; }
        public string BookPicture { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedTime { get; set; }
        public bool BorrowState { get; set; }
    }
}
