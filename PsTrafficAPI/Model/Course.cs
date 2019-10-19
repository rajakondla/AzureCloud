using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PsTrafficAPI.Model
{
    public class Course
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Range(0, 100)]
        public int Length { get; set; }
    }
}
