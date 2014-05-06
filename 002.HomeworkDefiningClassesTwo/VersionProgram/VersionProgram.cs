/* Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations 
 * and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a 
 * sample class and display its version at runtime. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionProgram
{
    [VersionAttribute("1.2.1.2a")]
    public class VersionProgram
    {
        static void Main()
        {
            Type type = typeof(VersionProgram);
            object[] attribure = type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in attribure)
            {
                Console.WriteLine("Version of program  is: {0} ", attr.Version);
            }
        }
    }
}


