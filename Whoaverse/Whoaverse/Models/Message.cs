//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whoaverse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public Message()
        {
            this.Rank = 0D;
            this.Likes = 1;
            this.Dislikes = 0;
            this.Comments = new HashSet<Comment>();
            this.Votingtrackers = new HashSet<Votingtracker>();
        }
    
        public int Id { get; set; }
        public Nullable<short> Votes { get; set; }
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public int Type { get; set; }
        public string Linkdescription { get; set; }
        public string Title { get; set; }
        public double Rank { get; set; }
        public string MessageContent { get; set; }
        public string Subverse { get; set; }
        public short Likes { get; set; }
        public short Dislikes { get; set; }
        public string Thumbnail { get; set; }
        public Nullable<System.DateTime> LastEditDate { get; set; }
        public string FlairLabel { get; set; }
        public string FlairCss { get; set; }
    
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Votingtracker> Votingtrackers { get; set; }
        public virtual Subverse Subverses { get; set; }
    }
}
