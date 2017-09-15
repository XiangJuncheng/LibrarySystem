using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarySytstem.Domain.Entities
{
    public class BorrowAndReturn
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public long ExpiredDays { get; set; }
        public bool IsReturn { get; set; }
    }
}
