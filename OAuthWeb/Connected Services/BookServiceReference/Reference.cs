﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuthWeb.BookServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/RestAngularWCF.Domain.Entity")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceReference.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        void AddBook(OAuthWeb.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(OAuthWeb.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBookOptions", ReplyAction="http://tempuri.org/IBookService/AddBookOptionsResponse")]
        void AddBookOptions(OAuthWeb.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBookOptions", ReplyAction="http://tempuri.org/IBookService/AddBookOptionsResponse")]
        System.Threading.Tasks.Task AddBookOptionsAsync(OAuthWeb.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        void DeleteBook(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBook", ReplyAction="http://tempuri.org/IBookService/DeleteBookResponse")]
        System.Threading.Tasks.Task DeleteBookAsync(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookOptions", ReplyAction="http://tempuri.org/IBookService/DeleteBookOptionsResponse")]
        void DeleteBookOptions(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookOptions", ReplyAction="http://tempuri.org/IBookService/DeleteBookOptionsResponse")]
        System.Threading.Tasks.Task DeleteBookOptionsAsync(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        OAuthWeb.BookServiceReference.Book[] GetBook();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        System.Threading.Tasks.Task<OAuthWeb.BookServiceReference.Book[]> GetBookAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookDetails", ReplyAction="http://tempuri.org/IBookService/GetBookDetailsResponse")]
        OAuthWeb.BookServiceReference.Book GetBookDetails(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookDetails", ReplyAction="http://tempuri.org/IBookService/GetBookDetailsResponse")]
        System.Threading.Tasks.Task<OAuthWeb.BookServiceReference.Book> GetBookDetailsAsync(string bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        void UpdateBook(OAuthWeb.BookServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBook", ReplyAction="http://tempuri.org/IBookService/UpdateBookResponse")]
        System.Threading.Tasks.Task UpdateBookAsync(OAuthWeb.BookServiceReference.Book book);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : OAuthWeb.BookServiceReference.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<OAuthWeb.BookServiceReference.IBookService>, OAuthWeb.BookServiceReference.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBook(OAuthWeb.BookServiceReference.Book book) {
            base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(OAuthWeb.BookServiceReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public void AddBookOptions(OAuthWeb.BookServiceReference.Book book) {
            base.Channel.AddBookOptions(book);
        }
        
        public System.Threading.Tasks.Task AddBookOptionsAsync(OAuthWeb.BookServiceReference.Book book) {
            return base.Channel.AddBookOptionsAsync(book);
        }
        
        public void DeleteBook(string bookId) {
            base.Channel.DeleteBook(bookId);
        }
        
        public System.Threading.Tasks.Task DeleteBookAsync(string bookId) {
            return base.Channel.DeleteBookAsync(bookId);
        }
        
        public void DeleteBookOptions(string bookId) {
            base.Channel.DeleteBookOptions(bookId);
        }
        
        public System.Threading.Tasks.Task DeleteBookOptionsAsync(string bookId) {
            return base.Channel.DeleteBookOptionsAsync(bookId);
        }
        
        public OAuthWeb.BookServiceReference.Book[] GetBook() {
            return base.Channel.GetBook();
        }
        
        public System.Threading.Tasks.Task<OAuthWeb.BookServiceReference.Book[]> GetBookAsync() {
            return base.Channel.GetBookAsync();
        }
        
        public OAuthWeb.BookServiceReference.Book GetBookDetails(string bookId) {
            return base.Channel.GetBookDetails(bookId);
        }
        
        public System.Threading.Tasks.Task<OAuthWeb.BookServiceReference.Book> GetBookDetailsAsync(string bookId) {
            return base.Channel.GetBookDetailsAsync(bookId);
        }
        
        public void UpdateBook(OAuthWeb.BookServiceReference.Book book) {
            base.Channel.UpdateBook(book);
        }
        
        public System.Threading.Tasks.Task UpdateBookAsync(OAuthWeb.BookServiceReference.Book book) {
            return base.Channel.UpdateBookAsync(book);
        }
    }
}