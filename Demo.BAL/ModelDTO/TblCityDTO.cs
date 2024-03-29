﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BAL.ModelDTO
{
    public class TblCityDTO
    {
        public int Id { get; set; }

        [Required]        
        public int StateId { get; set; }       

        [Required]
        public string CityName { get; set; }
    }
}
