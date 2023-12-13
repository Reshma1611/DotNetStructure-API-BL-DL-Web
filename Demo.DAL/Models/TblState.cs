using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models
{
    public class TblState
    {
        [Key]
        public int Id { get; set; }
        public string StateName { get; set; }
    }
}
