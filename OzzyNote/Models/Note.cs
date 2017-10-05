using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzzyNote.Models
{
    [Table("note")]
    public class Note
    {
        public int id { get; set; }
        public string note { get; set; }
        public int pageId { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}