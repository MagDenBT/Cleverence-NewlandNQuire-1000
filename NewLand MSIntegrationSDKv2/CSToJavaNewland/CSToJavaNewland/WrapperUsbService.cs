using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Example.Bridgelib;


namespace NewlandJavaLibs
{
    [Service(Exported = true, Name = "magdenbt.com.driver.newlandnls_nquire1000")]
    public class WrapperUsbService : StandartUsbService
    {
       
    }
}