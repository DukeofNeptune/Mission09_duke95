using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_duke95.Models
{
    //Set up EF class using the IBookstoreRepository
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
    
    
}
