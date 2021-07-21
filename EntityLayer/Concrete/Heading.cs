using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        
        [DisplayName("Başlık")]
        public string HeadingName { get; set; }
        [DisplayName("Tarih")]
        public DateTime HeadingDate { get; set; }
        public bool HeadingStatus { get; set; }

        [DisplayName("Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [DisplayName("Yazar")]
        public int WriterId { get; set; }
        public virtual Writer Writer{ get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
