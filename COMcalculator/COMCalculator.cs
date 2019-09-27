using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
namespace COMCalculator
{
    [Guid("753C2230-8188-4452-A608-58B45798B742")]
    [ComVisible(true)]
    [ProgId("simpleCOM.Claculator")] // We need to add progID which is the COM object name. 
    [ClassInterface(ClassInterfaceType.None)]
    // To prevent C# CLR from creating "IComClassExample" interface on the fly. 
    // Because that interface will be used as COM server. 
    public class COMCalculator:IComClaculator
    {
       public COMCalculator() { } // We need to have empty constructor. 

        public int add(int a, int b)
        {
            return a + b; 
        }

        public double divide(int a, int b)
        {
            return (double)a / (double)b;
        }

        public int multiply(int a, int b)
        {
            return a * b; 
        }
    }
}
