﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Client.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IServer", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;
        
        private System.Threading.SendOrPostCallback RegisterOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginDesignerOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoginAdminOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddDesignInDLOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddShoeOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetOrdersListOperationCompleted;
        
        private System.Threading.SendOrPostCallback SetStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback ShowShoeStatusOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = global::Client.Properties.Settings.Default.Client_localhost_Service1;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;
        
        /// <remarks/>
        public event RegisterCompletedEventHandler RegisterCompleted;
        
        /// <remarks/>
        public event LoginDesignerCompletedEventHandler LoginDesignerCompleted;
        
        /// <remarks/>
        public event LoginAdminCompletedEventHandler LoginAdminCompleted;
        
        /// <remarks/>
        public event AddDesignInDLCompletedEventHandler AddDesignInDLCompleted;
        
        /// <remarks/>
        public event AddShoeCompletedEventHandler AddShoeCompleted;
        
        /// <remarks/>
        public event GetOrdersListCompletedEventHandler GetOrdersListCompleted;
        
        /// <remarks/>
        public event SetStatusCompletedEventHandler SetStatusCompleted;
        
        /// <remarks/>
        public event ShowShoeStatusCompletedEventHandler ShowShoeStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified) {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified) {
            this.GetDataAsync(value, valueSpecified, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/GetDataUsingDataContract", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] CompositeType composite) {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState) {
            if ((this.GetDataUsingDataContractOperationCompleted == null)) {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }
        
        private void OnGetDataUsingDataContractOperationCompleted(object arg) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/Register", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Register([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pass) {
            this.Invoke("Register", new object[] {
                        name,
                        pass});
        }
        
        /// <remarks/>
        public void RegisterAsync(string name, string pass) {
            this.RegisterAsync(name, pass, null);
        }
        
        /// <remarks/>
        public void RegisterAsync(string name, string pass, object userState) {
            if ((this.RegisterOperationCompleted == null)) {
                this.RegisterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterOperationCompleted);
            }
            this.InvokeAsync("Register", new object[] {
                        name,
                        pass}, this.RegisterOperationCompleted, userState);
        }
        
        private void OnRegisterOperationCompleted(object arg) {
            if ((this.RegisterCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/LoginDesigner", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LoginDesigner([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pass, out bool LoginDesignerResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LoginDesignerResultSpecified) {
            object[] results = this.Invoke("LoginDesigner", new object[] {
                        name,
                        pass});
            LoginDesignerResult = ((bool)(results[0]));
            LoginDesignerResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void LoginDesignerAsync(string name, string pass) {
            this.LoginDesignerAsync(name, pass, null);
        }
        
        /// <remarks/>
        public void LoginDesignerAsync(string name, string pass, object userState) {
            if ((this.LoginDesignerOperationCompleted == null)) {
                this.LoginDesignerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginDesignerOperationCompleted);
            }
            this.InvokeAsync("LoginDesigner", new object[] {
                        name,
                        pass}, this.LoginDesignerOperationCompleted, userState);
        }
        
        private void OnLoginDesignerOperationCompleted(object arg) {
            if ((this.LoginDesignerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginDesignerCompleted(this, new LoginDesignerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/LoginAdmin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LoginAdmin([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string name, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pass, out bool LoginAdminResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LoginAdminResultSpecified) {
            object[] results = this.Invoke("LoginAdmin", new object[] {
                        name,
                        pass});
            LoginAdminResult = ((bool)(results[0]));
            LoginAdminResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void LoginAdminAsync(string name, string pass) {
            this.LoginAdminAsync(name, pass, null);
        }
        
        /// <remarks/>
        public void LoginAdminAsync(string name, string pass, object userState) {
            if ((this.LoginAdminOperationCompleted == null)) {
                this.LoginAdminOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginAdminOperationCompleted);
            }
            this.InvokeAsync("LoginAdmin", new object[] {
                        name,
                        pass}, this.LoginAdminOperationCompleted, userState);
        }
        
        private void OnLoginAdminOperationCompleted(object arg) {
            if ((this.LoginAdminCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginAdminCompleted(this, new LoginAdminCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/AddDesignInDL", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddDesignInDL([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Image img) {
            this.Invoke("AddDesignInDL", new object[] {
                        img});
        }
        
        /// <remarks/>
        public void AddDesignInDLAsync(Image img) {
            this.AddDesignInDLAsync(img, null);
        }
        
        /// <remarks/>
        public void AddDesignInDLAsync(Image img, object userState) {
            if ((this.AddDesignInDLOperationCompleted == null)) {
                this.AddDesignInDLOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddDesignInDLOperationCompleted);
            }
            this.InvokeAsync("AddDesignInDL", new object[] {
                        img}, this.AddDesignInDLOperationCompleted, userState);
        }
        
        private void OnAddDesignInDLOperationCompleted(object arg) {
            if ((this.AddDesignInDLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddDesignInDLCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/AddShoe", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddShoe([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string m, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string s, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string b, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string l) {
            this.Invoke("AddShoe", new object[] {
                        m,
                        s,
                        b,
                        l});
        }
        
        /// <remarks/>
        public void AddShoeAsync(string m, string s, string b, string l) {
            this.AddShoeAsync(m, s, b, l, null);
        }
        
        /// <remarks/>
        public void AddShoeAsync(string m, string s, string b, string l, object userState) {
            if ((this.AddShoeOperationCompleted == null)) {
                this.AddShoeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddShoeOperationCompleted);
            }
            this.InvokeAsync("AddShoe", new object[] {
                        m,
                        s,
                        b,
                        l}, this.AddShoeOperationCompleted, userState);
        }
        
        private void OnAddShoeOperationCompleted(object arg) {
            if ((this.AddShoeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddShoeCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/GetOrdersList", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/Server")]
        public Shoe[] GetOrdersList() {
            object[] results = this.Invoke("GetOrdersList", new object[0]);
            return ((Shoe[])(results[0]));
        }
        
        /// <remarks/>
        public void GetOrdersListAsync() {
            this.GetOrdersListAsync(null);
        }
        
        /// <remarks/>
        public void GetOrdersListAsync(object userState) {
            if ((this.GetOrdersListOperationCompleted == null)) {
                this.GetOrdersListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOrdersListOperationCompleted);
            }
            this.InvokeAsync("GetOrdersList", new object[0], this.GetOrdersListOperationCompleted, userState);
        }
        
        private void OnGetOrdersListOperationCompleted(object arg) {
            if ((this.GetOrdersListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetOrdersListCompleted(this, new GetOrdersListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/SetStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SetStatus([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string m, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string s, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string b, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string l) {
            this.Invoke("SetStatus", new object[] {
                        m,
                        s,
                        b,
                        l});
        }
        
        /// <remarks/>
        public void SetStatusAsync(string m, string s, string b, string l) {
            this.SetStatusAsync(m, s, b, l, null);
        }
        
        /// <remarks/>
        public void SetStatusAsync(string m, string s, string b, string l, object userState) {
            if ((this.SetStatusOperationCompleted == null)) {
                this.SetStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSetStatusOperationCompleted);
            }
            this.InvokeAsync("SetStatus", new object[] {
                        m,
                        s,
                        b,
                        l}, this.SetStatusOperationCompleted, userState);
        }
        
        private void OnSetStatusOperationCompleted(object arg) {
            if ((this.SetStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SetStatusCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServer/ShowShoeStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ShowShoeStatus([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string m, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string s, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string b, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string l) {
            object[] results = this.Invoke("ShowShoeStatus", new object[] {
                        m,
                        s,
                        b,
                        l});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ShowShoeStatusAsync(string m, string s, string b, string l) {
            this.ShowShoeStatusAsync(m, s, b, l, null);
        }
        
        /// <remarks/>
        public void ShowShoeStatusAsync(string m, string s, string b, string l, object userState) {
            if ((this.ShowShoeStatusOperationCompleted == null)) {
                this.ShowShoeStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnShowShoeStatusOperationCompleted);
            }
            this.InvokeAsync("ShowShoeStatus", new object[] {
                        m,
                        s,
                        b,
                        l}, this.ShowShoeStatusOperationCompleted, userState);
        }
        
        private void OnShowShoeStatusOperationCompleted(object arg) {
            if ((this.ShowShoeStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ShowShoeStatusCompleted(this, new ShowShoeStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Server")]
    public partial class CompositeType {
        
        private bool boolValueField;
        
        private bool boolValueFieldSpecified;
        
        private string stringValueField;
        
        /// <remarks/>
        public bool BoolValue {
            get {
                return this.boolValueField;
            }
            set {
                this.boolValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified {
            get {
                return this.boolValueFieldSpecified;
            }
            set {
                this.boolValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StringValue {
            get {
                return this.stringValueField;
            }
            set {
                this.stringValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Server")]
    public partial class Shoe {
        
        private string brandField;
        
        private string lacesField;
        
        private string mainColorField;
        
        private string sideColorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Brand {
            get {
                return this.brandField;
            }
            set {
                this.brandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Laces {
            get {
                return this.lacesField;
            }
            set {
                this.lacesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string MainColor {
            get {
                return this.mainColorField;
            }
            set {
                this.mainColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string SideColor {
            get {
                return this.sideColorField;
            }
            set {
                this.sideColorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    public partial class Image {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlQualifiedName factoryTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        public System.Xml.XmlQualifiedName FactoryType {
            get {
                return this.factoryTypeField;
            }
            set {
                this.factoryTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CompositeType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void RegisterCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void LoginDesignerCompletedEventHandler(object sender, LoginDesignerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginDesignerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginDesignerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool LoginDesignerResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool LoginDesignerResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void LoginAdminCompletedEventHandler(object sender, LoginAdminCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginAdminCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoginAdminCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool LoginAdminResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool LoginAdminResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void AddDesignInDLCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void AddShoeCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void GetOrdersListCompletedEventHandler(object sender, GetOrdersListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetOrdersListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetOrdersListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Shoe[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Shoe[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void SetStatusCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void ShowShoeStatusCompletedEventHandler(object sender, ShowShoeStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ShowShoeStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ShowShoeStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591