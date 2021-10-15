using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bsr_dotnet_ef6_webapi.Dal.Models;

namespace bsr_dotnet_ef6_webapi.Dal
{
  public class BloggingContext : DbContext
  {
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public BloggingContext(DbContextOptions options) : base(options)
    {
    }
  }
}
