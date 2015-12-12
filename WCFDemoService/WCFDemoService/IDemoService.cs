using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDemoService
{
    [ServiceContract]
    public interface IDemoService
    {
        [OperationContract]
        string getMessage(string input);
    }
}
