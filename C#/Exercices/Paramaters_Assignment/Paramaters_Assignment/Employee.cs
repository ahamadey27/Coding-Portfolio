using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramaters_Assignment
{
    public class Employee<T>
    {
        public List<T> things { get; set; } //Add a property to the Employee class called “things” and
                                            //have its data type be a generic list
                                            //matching the generic type of the class
    }
}
