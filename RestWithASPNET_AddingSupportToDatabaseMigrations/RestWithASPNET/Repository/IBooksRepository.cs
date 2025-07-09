﻿using RestWithASPNET.Model;

namespace RestWithASPNET.Repository
{
    public interface IBooksRepository
    {
        Book Create(Book book);

        Book FindById(long id);

        List<Book> FindAll();

        Book Update(Book book);

        void Delete(long id);

        bool Exists(long id);
    }
}
