using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace OzzyNote.Models
{
    [Table("page")]
    public class Page
    {
        public int id { get; set; }
        public string name { get; set; }
        public int notebookId { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
    }
}