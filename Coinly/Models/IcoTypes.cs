using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Coinly.Models
{
    public class IcoTypes
    {
        public byte Id { get; set; }

        [Required]
        public string Type { get; set; }
    }
}