using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutomotiveForum.Models
{
    public class Forum
    {
        [Key]
        public int TopicId { get; set; }
        public DateTime Date { get { return DateTime.Now; } }
        public string Topic { get; set; }
        public int PostLike { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}