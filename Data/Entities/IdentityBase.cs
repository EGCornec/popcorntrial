using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace PopcornMVC2.Data.Entities
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}