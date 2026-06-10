using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.DTO.RequestDto
{
    public class CreatedReqDto
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public DateTime Reminder { get; set; }

        public string BackgroundColour { get; set; }

        public string Image { get; set; }

        public bool Pin { get; set; } = false;
        public int UserId {  get; set; }
    }
}
