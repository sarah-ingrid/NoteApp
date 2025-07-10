using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLogin
{
    internal class Note
    {
        public int ID_note { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //    public string ContentRichTextF { get; set;  }
        public int IsImportant { get; set; }// = false;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public int ID_user { get; set; }
    }
}
