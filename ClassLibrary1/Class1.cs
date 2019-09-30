using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;

namespace ClassLibrary1
{
    public class Class1
    {
        public Class1()
        {
            string s1 = ResourceLoader.GetForViewIndependentUse("ClassLibrary1/Resources").GetString("Dummy1");

        }
    }
}
