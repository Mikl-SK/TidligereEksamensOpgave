using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TidligereEksamensOpgave.Models
{
    public class AuctionItenBidModel
    {
        [Required]
        public int ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public int RatingPrice { get; set; }
        [Required]
        public int BidPrice { get; set; }
        [Required]
        [MinLength(4)]
        public string BidCustomName { get; set; }
        [Required]
        [Range(10000000, 99999999, ErrorMessage = "Has to be 8 joined numbers")]
        public int BidCustomPhone { get; set; }
        public DateTime? BidTimestamp { get; set; }
    }
}