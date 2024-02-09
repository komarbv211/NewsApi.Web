﻿using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Entities
{
    public class Authors : IEntity
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string? Pseudonym { get; set; }
    }
}
