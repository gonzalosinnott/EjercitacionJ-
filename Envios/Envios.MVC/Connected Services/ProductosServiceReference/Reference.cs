﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vista.MVC.ProductosServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Productos", Namespace="http://schemas.datacontract.org/2004/07/ServiceBackEnd.Entities.Clases")]
    [System.SerializableAttribute()]
    public partial class Productos : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductoDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductoMarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductoNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProductoPrecioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductoStockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available {
            get {
                return this.AvailableField;
            }
            set {
                if ((this.AvailableField.Equals(value) != true)) {
                    this.AvailableField = value;
                    this.RaisePropertyChanged("Available");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductoDescription {
            get {
                return this.ProductoDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoDescriptionField, value) != true)) {
                    this.ProductoDescriptionField = value;
                    this.RaisePropertyChanged("ProductoDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductoId {
            get {
                return this.ProductoIdField;
            }
            set {
                if ((this.ProductoIdField.Equals(value) != true)) {
                    this.ProductoIdField = value;
                    this.RaisePropertyChanged("ProductoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductoMarca {
            get {
                return this.ProductoMarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoMarcaField, value) != true)) {
                    this.ProductoMarcaField = value;
                    this.RaisePropertyChanged("ProductoMarca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductoName {
            get {
                return this.ProductoNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoNameField, value) != true)) {
                    this.ProductoNameField = value;
                    this.RaisePropertyChanged("ProductoName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProductoPrecio {
            get {
                return this.ProductoPrecioField;
            }
            set {
                if ((this.ProductoPrecioField.Equals(value) != true)) {
                    this.ProductoPrecioField = value;
                    this.RaisePropertyChanged("ProductoPrecio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductoStock {
            get {
                return this.ProductoStockField;
            }
            set {
                if ((this.ProductoStockField.Equals(value) != true)) {
                    this.ProductoStockField = value;
                    this.RaisePropertyChanged("ProductoStock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProductosServiceReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProductsConsoleTest", ReplyAction="http://tempuri.org/IService/GetAllProductsConsoleTestResponse")]
        string GetAllProductsConsoleTest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProductsConsoleTest", ReplyAction="http://tempuri.org/IService/GetAllProductsConsoleTestResponse")]
        System.Threading.Tasks.Task<string> GetAllProductsConsoleTestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProducts", ReplyAction="http://tempuri.org/IService/GetAllProductsResponse")]
        Vista.MVC.ProductosServiceReference.Productos[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProducts", ReplyAction="http://tempuri.org/IService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.Productos[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductById", ReplyAction="http://tempuri.org/IService/GetProductByIdResponse")]
        Vista.MVC.ProductosServiceReference.Productos GetProductById(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductById", ReplyAction="http://tempuri.org/IService/GetProductByIdResponse")]
        System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.Productos> GetProductByIdAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProduct", ReplyAction="http://tempuri.org/IService/AddProductResponse")]
        string AddProduct(Vista.MVC.ProductosServiceReference.Productos producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddProduct", ReplyAction="http://tempuri.org/IService/AddProductResponse")]
        System.Threading.Tasks.Task<string> AddProductAsync(Vista.MVC.ProductosServiceReference.Productos producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteProduct", ReplyAction="http://tempuri.org/IService/DeleteProductResponse")]
        string DeleteProduct(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DeleteProduct", ReplyAction="http://tempuri.org/IService/DeleteProductResponse")]
        System.Threading.Tasks.Task<string> DeleteProductAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateProduct", ReplyAction="http://tempuri.org/IService/UpdateProductResponse")]
        string UpdateProduct(Vista.MVC.ProductosServiceReference.Productos producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpdateProduct", ReplyAction="http://tempuri.org/IService/UpdateProductResponse")]
        System.Threading.Tasks.Task<string> UpdateProductAsync(Vista.MVC.ProductosServiceReference.Productos producto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        Vista.MVC.ProductosServiceReference.CompositeType GetDataUsingDataContract(Vista.MVC.ProductosServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.CompositeType> GetDataUsingDataContractAsync(Vista.MVC.ProductosServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Vista.MVC.ProductosServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Vista.MVC.ProductosServiceReference.IService>, Vista.MVC.ProductosServiceReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetAllProductsConsoleTest() {
            return base.Channel.GetAllProductsConsoleTest();
        }
        
        public System.Threading.Tasks.Task<string> GetAllProductsConsoleTestAsync() {
            return base.Channel.GetAllProductsConsoleTestAsync();
        }
        
        public Vista.MVC.ProductosServiceReference.Productos[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.Productos[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public Vista.MVC.ProductosServiceReference.Productos GetProductById(int value) {
            return base.Channel.GetProductById(value);
        }
        
        public System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.Productos> GetProductByIdAsync(int value) {
            return base.Channel.GetProductByIdAsync(value);
        }
        
        public string AddProduct(Vista.MVC.ProductosServiceReference.Productos producto) {
            return base.Channel.AddProduct(producto);
        }
        
        public System.Threading.Tasks.Task<string> AddProductAsync(Vista.MVC.ProductosServiceReference.Productos producto) {
            return base.Channel.AddProductAsync(producto);
        }
        
        public string DeleteProduct(int value) {
            return base.Channel.DeleteProduct(value);
        }
        
        public System.Threading.Tasks.Task<string> DeleteProductAsync(int value) {
            return base.Channel.DeleteProductAsync(value);
        }
        
        public string UpdateProduct(Vista.MVC.ProductosServiceReference.Productos producto) {
            return base.Channel.UpdateProduct(producto);
        }
        
        public System.Threading.Tasks.Task<string> UpdateProductAsync(Vista.MVC.ProductosServiceReference.Productos producto) {
            return base.Channel.UpdateProductAsync(producto);
        }
        
        public Vista.MVC.ProductosServiceReference.CompositeType GetDataUsingDataContract(Vista.MVC.ProductosServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Vista.MVC.ProductosServiceReference.CompositeType> GetDataUsingDataContractAsync(Vista.MVC.ProductosServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
