﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public string SkillName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Person> Person { get; set; } = new List<Person>();
    }
}
