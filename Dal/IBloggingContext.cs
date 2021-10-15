using System;
using bsr_dotnet_ef6_webapi.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace bsr_dotnet_ef6_webapi.Dal
{
  public interface IBloggingContext {
    DbSet<Blog> Blogs { get; set; }
    DbSet<Post> Posts { get; set; }
    int SaveChanges();
  }
}
