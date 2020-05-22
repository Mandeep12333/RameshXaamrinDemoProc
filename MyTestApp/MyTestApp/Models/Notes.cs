using System;
using SQLite;

namespace MyTestApp.Models
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        //public Notes()
        //{

        //}
    }
}
