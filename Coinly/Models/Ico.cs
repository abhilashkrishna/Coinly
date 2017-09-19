using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Coinly.Models
{
    public class Ico
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Industry { get; set; }
        public string Description { get; set; }
        public byte Rating { get; set; }
        public IcoTypes IcoTypes { get; set; }
        public byte IcoTypeId { get; set; }
    }
}