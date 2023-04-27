using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50), Required(ErrorMessage = "Bu Alan Boş Bırakılamaz..")]
        public string Name { get; set; }

        [StringLength(50), Required(ErrorMessage = "Bu Alan Boş Bırakılamaz..")]
        public string SurName { get; set; }

        public DateTime Age { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }
    }
}
