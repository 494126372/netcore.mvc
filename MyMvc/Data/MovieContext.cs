using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyMvc.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }
        // 若要启用延迟加载，可以创建导航属性 virtual（Blog.Post 和 Post.Blog）。
        public virtual DbSet<MyMvc.Models.Movie> Movie { get; set; }
    }
}
