using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace People.Models
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(20), Unique]
        public string Name { get; set; }
    }
}
