﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Sahibinden.Models
{
    internal abstract class Entity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Entity()
        {
            
        }

        protected Entity(string name)
        {
            Name = name;
        }
    }
}
