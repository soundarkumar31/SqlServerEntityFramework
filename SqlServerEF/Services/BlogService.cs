using SqlServerEF.Data;
using SqlServerEF.Interfaces;
using SqlServerEF.Models;

namespace SqlServerEF.Services
{
    public class BlogService : IBlogService
    {
        private readonly SqlServerEFContext _context;

        public BlogService(SqlServerEFContext context)
        {
            _context = context;
        }
        public async Task SaveBlog(Blog blog)
        {
            _context.Blog.Add(blog);
            await _context.SaveChangesAsync();
        }
    }
}
