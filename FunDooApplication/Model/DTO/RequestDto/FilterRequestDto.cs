using System;
using System.Collections.Generic;
using System.Text;

namespace Model.DTO.RequestDto
{
    public class FilterRequestDto
    {
        public bool? IsArchived { get; set; }
        public bool? IsTrashed { get; set; }
    }
}
