﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Domain.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public DateTime SendDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }
    }
}
