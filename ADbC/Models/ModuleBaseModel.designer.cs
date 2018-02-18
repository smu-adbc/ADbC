﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADbC.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ADBC")]
	public partial class ModuleBaseModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertkeysModuleIntroSection(keysModuleIntroSection instance);
    partial void UpdatekeysModuleIntroSection(keysModuleIntroSection instance);
    partial void DeletekeysModuleIntroSection(keysModuleIntroSection instance);
    partial void InsertkeysModule(keysModule instance);
    partial void UpdatekeysModule(keysModule instance);
    partial void DeletekeysModule(keysModule instance);
    partial void InsertkeysModuleIntroContent(keysModuleIntroContent instance);
    partial void UpdatekeysModuleIntroContent(keysModuleIntroContent instance);
    partial void DeletekeysModuleIntroContent(keysModuleIntroContent instance);
    #endregion
		
		public ModuleBaseModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ADBCConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ModuleBaseModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModuleBaseModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModuleBaseModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ModuleBaseModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<keysModuleIntroSection> keysModuleIntroSections
		{
			get
			{
				return this.GetTable<keysModuleIntroSection>();
			}
		}
		
		public System.Data.Linq.Table<keysModule> keysModules
		{
			get
			{
				return this.GetTable<keysModule>();
			}
		}
		
		public System.Data.Linq.Table<keysModuleIntroContent> keysModuleIntroContents
		{
			get
			{
				return this.GetTable<keysModuleIntroContent>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectModuleByName")]
		public ISingleResult<keysModule> SelectModuleByName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ModuleName", DbType="VarChar(1)")] string moduleName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), moduleName);
			return ((ISingleResult<keysModule>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectModuleIntroSectionsByModuleID")]
		public ISingleResult<keysModuleIntroSection> SelectModuleIntroSectionsByModuleID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ModuleID", DbType="Int")] System.Nullable<int> moduleID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), moduleID);
			return ((ISingleResult<keysModuleIntroSection>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectModuleIntroContentByModuleID")]
		public ISingleResult<keysModuleIntroContent> SelectModuleIntroContentByModuleID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ModuleID", DbType="Int")] System.Nullable<int> moduleID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), moduleID);
			return ((ISingleResult<keysModuleIntroContent>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysModuleIntroSection")]
	public partial class keysModuleIntroSection : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ModuleIntroSectionID;
		
		private int _ModuleID;
		
		private string _SectionTitle;
		
		private int _SectionOrder;
		
		private bool _OpenOnStart;
		
		private EntitySet<keysModuleIntroContent> _keysModuleIntroContents;
		
		private EntityRef<keysModule> _keysModule;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModuleIntroSectionIDChanging(int value);
    partial void OnModuleIntroSectionIDChanged();
    partial void OnModuleIDChanging(int value);
    partial void OnModuleIDChanged();
    partial void OnSectionTitleChanging(string value);
    partial void OnSectionTitleChanged();
    partial void OnSectionOrderChanging(int value);
    partial void OnSectionOrderChanged();
    partial void OnOpenOnStartChanging(bool value);
    partial void OnOpenOnStartChanged();
    #endregion
		
		public keysModuleIntroSection()
		{
			this._keysModuleIntroContents = new EntitySet<keysModuleIntroContent>(new Action<keysModuleIntroContent>(this.attach_keysModuleIntroContents), new Action<keysModuleIntroContent>(this.detach_keysModuleIntroContents));
			this._keysModule = default(EntityRef<keysModule>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleIntroSectionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ModuleIntroSectionID
		{
			get
			{
				return this._ModuleIntroSectionID;
			}
			set
			{
				if ((this._ModuleIntroSectionID != value))
				{
					this.OnModuleIntroSectionIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleIntroSectionID = value;
					this.SendPropertyChanged("ModuleIntroSectionID");
					this.OnModuleIntroSectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleID", DbType="Int NOT NULL")]
		public int ModuleID
		{
			get
			{
				return this._ModuleID;
			}
			set
			{
				if ((this._ModuleID != value))
				{
					if (this._keysModule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleID = value;
					this.SendPropertyChanged("ModuleID");
					this.OnModuleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionTitle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string SectionTitle
		{
			get
			{
				return this._SectionTitle;
			}
			set
			{
				if ((this._SectionTitle != value))
				{
					this.OnSectionTitleChanging(value);
					this.SendPropertyChanging();
					this._SectionTitle = value;
					this.SendPropertyChanged("SectionTitle");
					this.OnSectionTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SectionOrder", DbType="Int NOT NULL")]
		public int SectionOrder
		{
			get
			{
				return this._SectionOrder;
			}
			set
			{
				if ((this._SectionOrder != value))
				{
					this.OnSectionOrderChanging(value);
					this.SendPropertyChanging();
					this._SectionOrder = value;
					this.SendPropertyChanged("SectionOrder");
					this.OnSectionOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OpenOnStart", DbType="Bit NOT NULL")]
		public bool OpenOnStart
		{
			get
			{
				return this._OpenOnStart;
			}
			set
			{
				if ((this._OpenOnStart != value))
				{
					this.OnOpenOnStartChanging(value);
					this.SendPropertyChanging();
					this._OpenOnStart = value;
					this.SendPropertyChanged("OpenOnStart");
					this.OnOpenOnStartChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysModuleIntroSection_keysModuleIntroContent", Storage="_keysModuleIntroContents", ThisKey="ModuleIntroSectionID", OtherKey="ModuleIntroSectionID")]
		public EntitySet<keysModuleIntroContent> keysModuleIntroContents
		{
			get
			{
				return this._keysModuleIntroContents;
			}
			set
			{
				this._keysModuleIntroContents.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysModule_keysModuleIntroSection", Storage="_keysModule", ThisKey="ModuleID", OtherKey="ModuleID", IsForeignKey=true)]
		public keysModule keysModule
		{
			get
			{
				return this._keysModule.Entity;
			}
			set
			{
				keysModule previousValue = this._keysModule.Entity;
				if (((previousValue != value) 
							|| (this._keysModule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._keysModule.Entity = null;
						previousValue.keysModuleIntroSections.Remove(this);
					}
					this._keysModule.Entity = value;
					if ((value != null))
					{
						value.keysModuleIntroSections.Add(this);
						this._ModuleID = value.ModuleID;
					}
					else
					{
						this._ModuleID = default(int);
					}
					this.SendPropertyChanged("keysModule");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_keysModuleIntroContents(keysModuleIntroContent entity)
		{
			this.SendPropertyChanging();
			entity.keysModuleIntroSection = this;
		}
		
		private void detach_keysModuleIntroContents(keysModuleIntroContent entity)
		{
			this.SendPropertyChanging();
			entity.keysModuleIntroSection = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysModule")]
	public partial class keysModule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ModuleID;
		
		private string _ModuleName;
		
		private bool _HasIntroModal;
		
		private EntitySet<keysModuleIntroSection> _keysModuleIntroSections;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModuleIDChanging(int value);
    partial void OnModuleIDChanged();
    partial void OnModuleNameChanging(string value);
    partial void OnModuleNameChanged();
    partial void OnHasIntroModalChanging(bool value);
    partial void OnHasIntroModalChanged();
    #endregion
		
		public keysModule()
		{
			this._keysModuleIntroSections = new EntitySet<keysModuleIntroSection>(new Action<keysModuleIntroSection>(this.attach_keysModuleIntroSections), new Action<keysModuleIntroSection>(this.detach_keysModuleIntroSections));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ModuleID
		{
			get
			{
				return this._ModuleID;
			}
			set
			{
				if ((this._ModuleID != value))
				{
					this.OnModuleIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleID = value;
					this.SendPropertyChanged("ModuleID");
					this.OnModuleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ModuleName
		{
			get
			{
				return this._ModuleName;
			}
			set
			{
				if ((this._ModuleName != value))
				{
					this.OnModuleNameChanging(value);
					this.SendPropertyChanging();
					this._ModuleName = value;
					this.SendPropertyChanged("ModuleName");
					this.OnModuleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HasIntroModal", DbType="Bit NOT NULL")]
		public bool HasIntroModal
		{
			get
			{
				return this._HasIntroModal;
			}
			set
			{
				if ((this._HasIntroModal != value))
				{
					this.OnHasIntroModalChanging(value);
					this.SendPropertyChanging();
					this._HasIntroModal = value;
					this.SendPropertyChanged("HasIntroModal");
					this.OnHasIntroModalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysModule_keysModuleIntroSection", Storage="_keysModuleIntroSections", ThisKey="ModuleID", OtherKey="ModuleID")]
		public EntitySet<keysModuleIntroSection> keysModuleIntroSections
		{
			get
			{
				return this._keysModuleIntroSections;
			}
			set
			{
				this._keysModuleIntroSections.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_keysModuleIntroSections(keysModuleIntroSection entity)
		{
			this.SendPropertyChanging();
			entity.keysModule = this;
		}
		
		private void detach_keysModuleIntroSections(keysModuleIntroSection entity)
		{
			this.SendPropertyChanging();
			entity.keysModule = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysModuleIntroContent")]
	public partial class keysModuleIntroContent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ModuleIntroContentID;
		
		private int _ModuleIntroSectionID;
		
		private bool _IsImage;
		
		private string _Content;
		
		private int _ContentOrder;
		
		private EntityRef<keysModuleIntroSection> _keysModuleIntroSection;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnModuleIntroContentIDChanging(int value);
    partial void OnModuleIntroContentIDChanged();
    partial void OnModuleIntroSectionIDChanging(int value);
    partial void OnModuleIntroSectionIDChanged();
    partial void OnIsImageChanging(bool value);
    partial void OnIsImageChanged();
    partial void OnContentChanging(string value);
    partial void OnContentChanged();
    partial void OnContentOrderChanging(int value);
    partial void OnContentOrderChanged();
    #endregion
		
		public keysModuleIntroContent()
		{
			this._keysModuleIntroSection = default(EntityRef<keysModuleIntroSection>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleIntroContentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ModuleIntroContentID
		{
			get
			{
				return this._ModuleIntroContentID;
			}
			set
			{
				if ((this._ModuleIntroContentID != value))
				{
					this.OnModuleIntroContentIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleIntroContentID = value;
					this.SendPropertyChanged("ModuleIntroContentID");
					this.OnModuleIntroContentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleIntroSectionID", DbType="Int NOT NULL")]
		public int ModuleIntroSectionID
		{
			get
			{
				return this._ModuleIntroSectionID;
			}
			set
			{
				if ((this._ModuleIntroSectionID != value))
				{
					if (this._keysModuleIntroSection.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnModuleIntroSectionIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleIntroSectionID = value;
					this.SendPropertyChanged("ModuleIntroSectionID");
					this.OnModuleIntroSectionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsImage", DbType="Bit NOT NULL")]
		public bool IsImage
		{
			get
			{
				return this._IsImage;
			}
			set
			{
				if ((this._IsImage != value))
				{
					this.OnIsImageChanging(value);
					this.SendPropertyChanging();
					this._IsImage = value;
					this.SendPropertyChanged("IsImage");
					this.OnIsImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._Content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContentOrder", DbType="Int NOT NULL")]
		public int ContentOrder
		{
			get
			{
				return this._ContentOrder;
			}
			set
			{
				if ((this._ContentOrder != value))
				{
					this.OnContentOrderChanging(value);
					this.SendPropertyChanging();
					this._ContentOrder = value;
					this.SendPropertyChanged("ContentOrder");
					this.OnContentOrderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysModuleIntroSection_keysModuleIntroContent", Storage="_keysModuleIntroSection", ThisKey="ModuleIntroSectionID", OtherKey="ModuleIntroSectionID", IsForeignKey=true)]
		public keysModuleIntroSection keysModuleIntroSection
		{
			get
			{
				return this._keysModuleIntroSection.Entity;
			}
			set
			{
				keysModuleIntroSection previousValue = this._keysModuleIntroSection.Entity;
				if (((previousValue != value) 
							|| (this._keysModuleIntroSection.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._keysModuleIntroSection.Entity = null;
						previousValue.keysModuleIntroContents.Remove(this);
					}
					this._keysModuleIntroSection.Entity = value;
					if ((value != null))
					{
						value.keysModuleIntroContents.Add(this);
						this._ModuleIntroSectionID = value.ModuleIntroSectionID;
					}
					else
					{
						this._ModuleIntroSectionID = default(int);
					}
					this.SendPropertyChanged("keysModuleIntroSection");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591