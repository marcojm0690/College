using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace College.Models
{
    public class Notes
    {
        public int NotesId { get; set; }

        public int StudentId { get; set; }
        public int ClassId { get; set; }

        public bool IsAproved { get; set; }

    }
}
