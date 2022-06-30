using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Template.Models
{
    public class Design
    {
        public int Id { get; set; }

        public string Image { get; set; }

        [StringLength(maximumLength:30)]
        public string Title { get; set; }
        [StringLength(maximumLength: 150)]
        public string SubTitle { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile Photo { get; set; }
    }
}
