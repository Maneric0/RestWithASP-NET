﻿using RestWithASPNET.Model;

namespace RestWithASPNET.Business
{
    public interface IBooksBusiness
    {
        Book Create(Book book);

        Book FindById(long id);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long id);
    }
}
