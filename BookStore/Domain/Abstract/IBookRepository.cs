using Domain.Entities;
using System.Collections.Generic;
namespace Domain.Abstract
{
    public interface IBookRepository
    {       
        IEnumerable<Book> Books { get; }
        void SaveBook(Book book);
    }
}
