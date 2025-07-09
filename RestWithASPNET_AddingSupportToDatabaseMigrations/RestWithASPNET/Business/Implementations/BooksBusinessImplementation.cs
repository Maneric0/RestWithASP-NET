using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Repository;
using System;

namespace RestWithASPNET.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {
        private readonly IBooksRepository _repository;

        public BooksBusinessImplementation(IBooksRepository repository)
        {
            _repository = repository;
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
