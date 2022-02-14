using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_survey.Models
{
    public class Ninja
    {
        [Required]
        public string name { get; set; }

        [Required]
        public string location { get; set; }

        [Required]
        public string language { get; set; }

        public string comment { get; set; }
    }
}
