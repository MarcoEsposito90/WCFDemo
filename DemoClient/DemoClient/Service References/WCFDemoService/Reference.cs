﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoClient.WCFDemoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFDemoService.IDemoService")]
    public interface IDemoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/getMessage", ReplyAction="http://tempuri.org/IDemoService/getMessageResponse")]
        string getMessage(string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoService/getMessage", ReplyAction="http://tempuri.org/IDemoService/getMessageResponse")]
        System.Threading.Tasks.Task<string> getMessageAsync(string input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoServiceChannel : DemoClient.WCFDemoService.IDemoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoServiceClient : System.ServiceModel.ClientBase<DemoClient.WCFDemoService.IDemoService>, DemoClient.WCFDemoService.IDemoService {
        
        public DemoServiceClient() {
        }
        
        public DemoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMessage(string input) {
            return base.Channel.getMessage(input);
        }
        
        public System.Threading.Tasks.Task<string> getMessageAsync(string input) {
            return base.Channel.getMessageAsync(input);
        }
    }
}
