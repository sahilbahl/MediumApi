using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediumApi.Models
{
    [Table("User")]
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
    }
}