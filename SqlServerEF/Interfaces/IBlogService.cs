using SqlServerEF.Models;

namespace SqlServerEF.Interfaces
{
    public interface IBlogService
    {
        Task SaveBlog(Blog blog);
    }
}
