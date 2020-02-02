﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SulsApp.Models
{
    public class Submission
    {
        public Submission()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [MaxLength(800)]
        [Required]
        public string Code { get; set; }

        [Required]
        public int AchievedResult { get; set; }

        public DateTime CreatedOn { get; set; }

        public string ProblmeId { get; set; }
        public virtual Problem Problem { get; set; }
        
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
