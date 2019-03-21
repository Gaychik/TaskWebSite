using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Task.Models;

namespace Task.DataAnnotation
{
    public class CompareSizeAttribute:ValidationAttribute
    {
        int Coordinate;
        public CompareSizeAttribute(int currentCoordinate)
        {
            Coordinate = currentCoordinate;
        }
        public override bool IsValid(object obj)
        {
            return Coordinate <= (int)obj;
        }
       
       
    }
}