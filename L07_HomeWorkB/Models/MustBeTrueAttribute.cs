using System;
using System.ComponentModel.DataAnnotations;

namespace L07_HomeWorkB.Models
{
    internal class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value is bool && (bool)value;
        }
    }
}