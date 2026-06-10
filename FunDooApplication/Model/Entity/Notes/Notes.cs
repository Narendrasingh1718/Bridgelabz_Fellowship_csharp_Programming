using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entity.Notes
{
    public class Notes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime Reminder { get; set; }

        [MaxLength(50)]
        public string BackgroundColour { get; set; }

        public string Image { get; set; }

        public bool Pin { get; set; } = false;

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime? Edited { get; set; }

        public bool Trash { get; set; } = false;

        public bool Archive { get; set; } = false;

        // RELATIONSHIP 
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User.User User{ get; set; }


    }
}