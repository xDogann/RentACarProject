﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        
        public int Id { get; set; }
        public int CarId { get; set; }
        public string? ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
