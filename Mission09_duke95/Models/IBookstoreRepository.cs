using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_duke95.Models
{
    //Create IBookstoreRepository
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
