﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace NCrawler.Demo
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ZetaCrawlerEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ZetaCrawlerEntities object using the connection string found in the 'ZetaCrawlerEntities' section of the application configuration file.
        /// </summary>
        public ZetaCrawlerEntities() : base("name=ZetaCrawlerEntities", "ZetaCrawlerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ZetaCrawlerEntities object.
        /// </summary>
        public ZetaCrawlerEntities(string connectionString) : base(connectionString, "ZetaCrawlerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ZetaCrawlerEntities object.
        /// </summary>
        public ZetaCrawlerEntities(EntityConnection connection) : base(connection, "ZetaCrawlerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Test> Tests
        {
            get
            {
                if ((_Tests == null))
                {
                    _Tests = base.CreateObjectSet<Test>("Tests");
                }
                return _Tests;
            }
        }
        private ObjectSet<Test> _Tests;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Item> Items
        {
            get
            {
                if ((_Items == null))
                {
                    _Items = base.CreateObjectSet<Item>("Items");
                }
                return _Items;
            }
        }
        private ObjectSet<Item> _Items;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Mp3ZingItem> Mp3ZingItem
        {
            get
            {
                if ((_Mp3ZingItem == null))
                {
                    _Mp3ZingItem = base.CreateObjectSet<Mp3ZingItem>("Mp3ZingItem");
                }
                return _Mp3ZingItem;
            }
        }
        private ObjectSet<Mp3ZingItem> _Mp3ZingItem;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tests EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTests(Test test)
        {
            base.AddObject("Tests", test);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Items EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToItems(Item item)
        {
            base.AddObject("Items", item);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Mp3ZingItem EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMp3ZingItem(Mp3ZingItem mp3ZingItem)
        {
            base.AddObject("Mp3ZingItem", mp3ZingItem);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ZetaCrawlerModel", Name="Item")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Item : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Item object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Item CreateItem(global::System.Int32 id)
        {
            Item item = new Item();
            item.Id = id;
            return item;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Url
        {
            get
            {
                return _Url;
            }
            set
            {
                OnUrlChanging(value);
                ReportPropertyChanging("Url");
                _Url = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Url");
                OnUrlChanged();
            }
        }
        private global::System.String _Url;
        partial void OnUrlChanging(global::System.String value);
        partial void OnUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContentEncoding
        {
            get
            {
                return _ContentEncoding;
            }
            set
            {
                OnContentEncodingChanging(value);
                ReportPropertyChanging("ContentEncoding");
                _ContentEncoding = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContentEncoding");
                OnContentEncodingChanged();
            }
        }
        private global::System.String _ContentEncoding;
        partial void OnContentEncodingChanging(global::System.String value);
        partial void OnContentEncodingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContentType
        {
            get
            {
                return _ContentType;
            }
            set
            {
                OnContentTypeChanging(value);
                ReportPropertyChanging("ContentType");
                _ContentType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContentType");
                OnContentTypeChanged();
            }
        }
        private global::System.String _ContentType;
        partial void OnContentTypeChanging(global::System.String value);
        partial void OnContentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Length
        {
            get
            {
                return _Length;
            }
            set
            {
                OnLengthChanging(value);
                ReportPropertyChanging("Length");
                _Length = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Length");
                OnLengthChanged();
            }
        }
        private Nullable<global::System.Int32> _Length;
        partial void OnLengthChanging(Nullable<global::System.Int32> value);
        partial void OnLengthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Depth
        {
            get
            {
                return _Depth;
            }
            set
            {
                OnDepthChanging(value);
                ReportPropertyChanging("Depth");
                _Depth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Depth");
                OnDepthChanged();
            }
        }
        private Nullable<global::System.Int32> _Depth;
        partial void OnDepthChanging(Nullable<global::System.Int32> value);
        partial void OnDepthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NgayPhatHanh
        {
            get
            {
                return _NgayPhatHanh;
            }
            set
            {
                OnNgayPhatHanhChanging(value);
                ReportPropertyChanging("NgayPhatHanh");
                _NgayPhatHanh = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NgayPhatHanh");
                OnNgayPhatHanhChanged();
            }
        }
        private global::System.String _NgayPhatHanh;
        partial void OnNgayPhatHanhChanging(global::System.String value);
        partial void OnNgayPhatHanhChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                OnSubjectChanging(value);
                ReportPropertyChanging("Subject");
                _Subject = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Subject");
                OnSubjectChanged();
            }
        }
        private global::System.String _Subject;
        partial void OnSubjectChanging(global::System.String value);
        partial void OnSubjectChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ZetaCrawlerModel", Name="Mp3ZingItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Mp3ZingItem : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Mp3ZingItem object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Mp3ZingItem CreateMp3ZingItem(global::System.Int32 id)
        {
            Mp3ZingItem mp3ZingItem = new Mp3ZingItem();
            mp3ZingItem.Id = id;
            return mp3ZingItem;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Url
        {
            get
            {
                return _Url;
            }
            set
            {
                OnUrlChanging(value);
                ReportPropertyChanging("Url");
                _Url = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Url");
                OnUrlChanged();
            }
        }
        private global::System.String _Url;
        partial void OnUrlChanging(global::System.String value);
        partial void OnUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContentEncoding
        {
            get
            {
                return _ContentEncoding;
            }
            set
            {
                OnContentEncodingChanging(value);
                ReportPropertyChanging("ContentEncoding");
                _ContentEncoding = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContentEncoding");
                OnContentEncodingChanged();
            }
        }
        private global::System.String _ContentEncoding;
        partial void OnContentEncodingChanging(global::System.String value);
        partial void OnContentEncodingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContentType
        {
            get
            {
                return _ContentType;
            }
            set
            {
                OnContentTypeChanging(value);
                ReportPropertyChanging("ContentType");
                _ContentType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContentType");
                OnContentTypeChanged();
            }
        }
        private global::System.String _ContentType;
        partial void OnContentTypeChanging(global::System.String value);
        partial void OnContentTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Length
        {
            get
            {
                return _Length;
            }
            set
            {
                OnLengthChanging(value);
                ReportPropertyChanging("Length");
                _Length = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Length");
                OnLengthChanged();
            }
        }
        private Nullable<global::System.Int32> _Length;
        partial void OnLengthChanging(Nullable<global::System.Int32> value);
        partial void OnLengthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Depth
        {
            get
            {
                return _Depth;
            }
            set
            {
                OnDepthChanging(value);
                ReportPropertyChanging("Depth");
                _Depth = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Depth");
                OnDepthChanged();
            }
        }
        private Nullable<global::System.Int32> _Depth;
        partial void OnDepthChanging(Nullable<global::System.Int32> value);
        partial void OnDepthChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NgayPhatHanh
        {
            get
            {
                return _NgayPhatHanh;
            }
            set
            {
                OnNgayPhatHanhChanging(value);
                ReportPropertyChanging("NgayPhatHanh");
                _NgayPhatHanh = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NgayPhatHanh");
                OnNgayPhatHanhChanged();
            }
        }
        private global::System.String _NgayPhatHanh;
        partial void OnNgayPhatHanhChanging(global::System.String value);
        partial void OnNgayPhatHanhChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                OnSubjectChanging(value);
                ReportPropertyChanging("Subject");
                _Subject = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Subject");
                OnSubjectChanged();
            }
        }
        private global::System.String _Subject;
        partial void OnSubjectChanging(global::System.String value);
        partial void OnSubjectChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ZetaCrawlerModel", Name="Test")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Test : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Test object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        public static Test CreateTest(global::System.Guid id)
        {
            Test test = new Test();
            test.Id = id;
            return test;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Test1
        {
            get
            {
                return _Test1;
            }
            set
            {
                OnTest1Changing(value);
                ReportPropertyChanging("Test1");
                _Test1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Test1");
                OnTest1Changed();
            }
        }
        private global::System.String _Test1;
        partial void OnTest1Changing(global::System.String value);
        partial void OnTest1Changed();

        #endregion
    
    }

    #endregion
    
}