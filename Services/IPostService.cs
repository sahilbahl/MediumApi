using System.Collections.Generic;
using MediumApi.Models;

namespace MediumApi.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetPosts();
    }
}