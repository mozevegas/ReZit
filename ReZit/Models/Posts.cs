using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReZit.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? UpVotes { get; set; }
        public int? DownVotes { get; set; }
        public DateTime? PostedAt { get; set; } = DateTime.Now;
        
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}