using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Repository
{
    public interface IDemoRepository<T> : IBaseRepository<T> where T : class
    {
        DbContext _dataContext { get; set; }
        DbSet<T> _dbSet { get; set; }
    }
}
