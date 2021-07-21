using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [DisplayName("Yazar Adı")]
        public string WriterName { get; set; }
        [DisplayName("Hakkında")]
        public string WriterAbout { get; set; }
        [DisplayName("Profil Fotoğrafı")]
        public string WriterImage { get; set; }
        [DisplayName("Email")]
        public string WriterMail { get; set; }
        [DisplayName("Şifre")]
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }

    }
}
