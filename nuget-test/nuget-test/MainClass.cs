using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nuget_test
{
    public class MainClass : IMainClass
    {

        //create package
        //https://docs.microsoft.com/en-us/nuget/guides/create-net-standard-packages-vs2015
        //publish the package
        //https://docs.microsoft.com/en-us/nuget/create-packages/publish-a-package


        public string GetHelloWorld()
        {
            return "hello world";
        }
    }
}
