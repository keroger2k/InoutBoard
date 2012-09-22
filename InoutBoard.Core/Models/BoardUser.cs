using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InoutBoard.Core.Models
{
    public class BoardUser : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        [StringLength(200)]
        public string Note { get; set; }
    }
}