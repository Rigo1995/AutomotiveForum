using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutomotiveForum.Models
{
    public class MarketPlace
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string ItemsForSale { get; set; }
        public int Price{ get; set; }
        public string Description { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}