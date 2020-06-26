using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Extensions
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class NavigationPropertyAttribute : Attribute
    {
        public NavigationPropertyAttribute()
        {
        }
    }
}