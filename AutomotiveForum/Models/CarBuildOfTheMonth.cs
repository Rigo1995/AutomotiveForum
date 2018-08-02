using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutomotiveForum.Models
{
    public class CarBuildOfTheMonth
    {
        [Key]
        public int Name { get; set; }
        public DateTime? Date { get; set; }
        public string Entry { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}