using System;
using System.Collections.Generic;

namespace Training.Task6.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Path_image { get; set;  }
    }
}
