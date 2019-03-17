using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


public class Coordinate
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "The fields are not assign values!")]
    [Range(0,10)]
    public int X { get; set; }
					
    [Required(AllowEmptyStrings =false,ErrorMessage = "The fields are not assign values!")]
    [Range(0,10)]
    public int Y { get; set; }
}