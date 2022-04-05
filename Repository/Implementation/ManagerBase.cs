using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Implementation
{
    public class ManagerBase<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        public ManagerBase(DbContext context) : base(context)
        {

        }
    }
}
