﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelibGuiClient.VelibService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Serveur")]
    [System.SerializableAttribute()]
    public partial class City : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/Serveur")]
    [System.SerializableAttribute()]
    public partial class Position : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double lngField;
        
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
        public double lat {
            get {
                return this.latField;
            }
            set {
                if ((this.latField.Equals(value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double lng {
            get {
                return this.lngField;
            }
            set {
                if ((this.lngField.Equals(value) != true)) {
                    this.lngField = value;
                    this.RaisePropertyChanged("lng");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/Serveur")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contract_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private VelibGuiClient.VelibService.Position positionField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string contract_name {
            get {
                return this.contract_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.contract_nameField, value) != true)) {
                    this.contract_nameField = value;
                    this.RaisePropertyChanged("contract_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public VelibGuiClient.VelibService.Position position {
            get {
                return this.positionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionField, value) != true)) {
                    this.positionField = value;
                    this.RaisePropertyChanged("position");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        VelibGuiClient.VelibService.City[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCities", ReplyAction="http://tempuri.org/IService/GetCitiesResponse")]
        System.Threading.Tasks.Task<VelibGuiClient.VelibService.City[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNeerestStation", ReplyAction="http://tempuri.org/IService/GetNeerestStationResponse")]
        VelibGuiClient.VelibService.Station GetNeerestStation(string city, VelibGuiClient.VelibService.Position pos, bool start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNeerestStation", ReplyAction="http://tempuri.org/IService/GetNeerestStationResponse")]
        System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station> GetNeerestStationAsync(string city, VelibGuiClient.VelibService.Position pos, bool start);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStation", ReplyAction="http://tempuri.org/IService/GetStationResponse")]
        VelibGuiClient.VelibService.Station GetStation(string city, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStation", ReplyAction="http://tempuri.org/IService/GetStationResponse")]
        System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station> GetStationAsync(string city, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStations", ReplyAction="http://tempuri.org/IService/GetStationsResponse")]
        VelibGuiClient.VelibService.Station[] GetStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStations", ReplyAction="http://tempuri.org/IService/GetStationsResponse")]
        System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station[]> GetStationsAsync(string city);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : VelibGuiClient.VelibService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<VelibGuiClient.VelibService.IService>, VelibGuiClient.VelibService.IService {
        
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
        
        public VelibGuiClient.VelibService.City[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<VelibGuiClient.VelibService.City[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public VelibGuiClient.VelibService.Station GetNeerestStation(string city, VelibGuiClient.VelibService.Position pos, bool start) {
            return base.Channel.GetNeerestStation(city, pos, start);
        }
        
        public System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station> GetNeerestStationAsync(string city, VelibGuiClient.VelibService.Position pos, bool start) {
            return base.Channel.GetNeerestStationAsync(city, pos, start);
        }
        
        public VelibGuiClient.VelibService.Station GetStation(string city, int id) {
            return base.Channel.GetStation(city, id);
        }
        
        public System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station> GetStationAsync(string city, int id) {
            return base.Channel.GetStationAsync(city, id);
        }
        
        public VelibGuiClient.VelibService.Station[] GetStations(string city) {
            return base.Channel.GetStations(city);
        }
        
        public System.Threading.Tasks.Task<VelibGuiClient.VelibService.Station[]> GetStationsAsync(string city) {
            return base.Channel.GetStationsAsync(city);
        }
    }
}
