using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Model.Entity.Notes;

namespace Model.Entity.User
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public String LastName { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        [MaxLength(200)]
        public String Password { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; }=DateTime.Now;
        public bool IsActice { get; set; } = true;
        public ICollection<Notes.Notes> Notes { get; set; }
    }
}
