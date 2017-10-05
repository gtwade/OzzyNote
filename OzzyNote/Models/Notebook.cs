using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OzzyNote.Models
{
    public class Notebook
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class NotebookDBContext : DbContext
    {
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}