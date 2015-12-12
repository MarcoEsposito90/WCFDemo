using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDemoService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "DemoService" nel codice e nel file di configurazione contemporaneamente.
    public class DemoService : IDemoService
    {
        public string getMessage(string input)
        {

            return "you said " + input;
        }
    }
}
