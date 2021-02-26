using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Models;

public class RepositoryContext: DbContext
{
    public RepositoryContext()
    {

    }
    public RepositoryContext(DbContextOptions<RepositoryContext> contextOptions) : base(contextOptions)
    {

    }
    public DbSet<Customer> Customer { get; set; }
}