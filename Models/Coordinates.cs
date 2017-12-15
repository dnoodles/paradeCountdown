using System;
using System.ComponentModel.DataAnnotations;

namespace SantaTracker.Models
{
    public class Coordinates
    {        
        [Key]
        public int ID { get; set; }
        public string tid { get; set; }
        public string acc {get;set;}
        public string lat {get;set;}
        public string lon {get; set;}
        public string cos {get; set;}
        public string vel {get;set;}
        public DateTime time {get;set;}
    }
}