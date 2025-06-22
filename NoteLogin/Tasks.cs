using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLogin
{
    internal class Tasks
    {
        public int id_tasks { get; }
        public string Title { get; set; }
        public string description { get; set; }
   //     public bool IsCompleted { get; set; }
        public DateTime DATE { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public int ID_user { get; set; }
    }
}
