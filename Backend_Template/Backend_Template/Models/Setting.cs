using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Template.Models
{
    public class Setting
    {
        public int Id { get; set; }

        public string HeaderLogo { get; set; }

        public string FotorTitle { get; set; }

        public string FooterSubtitle { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Twitter { get; set; }

        public string Facebook { get; set; }

        public string Linkedin { get; set; }

        public string Google { get; set; }
    }
}
