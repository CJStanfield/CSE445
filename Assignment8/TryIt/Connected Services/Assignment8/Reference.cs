﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryIt.Assignment8 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Assignment8.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/search", ReplyAction="http://tempuri.org/IService1/searchResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] search(string xml, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/search", ReplyAction="http://tempuri.org/IService1/searchResponse")]
        System.Threading.Tasks.Task<object[]> searchAsync(string xml, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verification", ReplyAction="http://tempuri.org/IService1/verificationResponse")]
        string verification(string xml, string schema);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/verification", ReplyAction="http://tempuri.org/IService1/verificationResponse")]
        System.Threading.Tasks.Task<string> verificationAsync(string xml, string schema);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TryIt.Assignment8.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TryIt.Assignment8.IService1>, TryIt.Assignment8.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object[] search(string xml, string key) {
            return base.Channel.search(xml, key);
        }
        
        public System.Threading.Tasks.Task<object[]> searchAsync(string xml, string key) {
            return base.Channel.searchAsync(xml, key);
        }
        
        public string verification(string xml, string schema) {
            return base.Channel.verification(xml, schema);
        }
        
        public System.Threading.Tasks.Task<string> verificationAsync(string xml, string schema) {
            return base.Channel.verificationAsync(xml, schema);
        }
    }
}