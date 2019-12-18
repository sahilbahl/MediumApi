using System.Collections.Generic;
using System.Linq;
using MediumApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MediumApi.Services
{
    public class PostService : IPostService
    {
        public IEnumerable<Post> GetPosts()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                return dbContext
                    .Posts
                    .Include(p => p.User)
                    .ToList();
            }
        }
    }
}
