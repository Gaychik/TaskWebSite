using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Task.DataAnnotation;

namespace Task.Models
{
   
    public class Matrix
    {
       
        [Required]
        [Range(0, 10)]
        public int X { get ;  set ;  }
        public int Y { get ;  set;  }

        public int[,] mas;
       
        [Range(0, 10)]
       
        public int Height{ get; set; }
        [Required]
        
        [Range(0, 10)]
        public int Width { get; set; }
    }
}