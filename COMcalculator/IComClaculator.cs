using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
// U have to run VS in adminstrator inorder to sign a file.

namespace COMCalculator
{
    [Guid("95B733B8-06AD-4BFD-B52C-629981AD01F6")] // To create Guid,from VS ,Tools -> Create GUID.  
    [ComVisible(true)] // Make the interface visialbe to COM
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)] // Here we annotate that our interface implements IDispatch interface. So it become COM object.
   /*
    * There are two interfaces that COM needs from u to implement : 
            1. IUnkown is the basic interface for all COM interfaces.
            2. IDispatch (inherits IUnkown)  exposes an interface for objects, methods and properties to programming tools and other applications that support Automation.
      Since we implement IDispatch so we implement both.   
    */
    public interface IComClaculator
    {
        [DispId(1)]
        /*Called COM dispatch identifier, for each property/method of 
         the interface you want to expose, u need to add [DispId(increment_number_here)],
         so COM clients can use the method with [DispId(increment_number_here)] annotation.
        */
        int add(int a, int b);
        [DispId(2)]
        int multiply(int a, int b);
        [DispId(3)]
        double divide(int a, int b);
    }
}
