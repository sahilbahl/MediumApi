using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediumApi.Models
{
    [Table("post")]
    public class Post
    {
        public Guid PostId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOnInUtc { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
