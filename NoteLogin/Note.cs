using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLogin
{
    internal class Note
    {
        public int ID_note { get; }
        public string Title { get; set; }
        public string Text { get; set; }
    //    public string ContentRichTextF { get; set;  }
        public bool IsImportant { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public int ID_user { get; set; }
    }
}
