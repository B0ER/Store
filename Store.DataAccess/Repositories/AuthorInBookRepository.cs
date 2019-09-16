﻿using Store.DataAccess.AppContext;
using Store.DataAccess.Entities;
using Store.DataAccess.Repositories.Base;
using Store.DataAccess.Repositories.Interfaces;

namespace Store.DataAccess.Repositories
{
    public class AuthorInBookRepository : BaseRepository<AuthorInBook>, IAuthorInBookRepository
    {
        public AuthorInBookRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}