﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp
{
    [Table("Students")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Group { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string DateOfBirthday { get; set; }
    }
}
