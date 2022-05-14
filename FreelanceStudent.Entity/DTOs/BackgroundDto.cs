using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelanceStudent.Entity.DTOs
{
    public class BackgroundDto
    {
        public int BackgroundId { get; set; }

        public string ImageUrl { get; set; }

        public string Github { get; set; }

        public string LinkedIn { get; set; }

        public string University { get; set; }

        public IEnumerable<string> JobExperiences { get; set; }

        public string Department { get; set; }

        public IEnumerable<string> ForeignLanguage { get; set; }

        public IEnumerable<string> ProgrammingLanguage { get; set; }
    }
}
