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
	public partial class ERNotationModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertkeysERNotation(keysERNotation instance);
    partial void UpdatekeysERNotation(keysERNotation instance);
    partial void DeletekeysERNotation(keysERNotation instance);
    partial void InsertkeysERRelationship(keysERRelationship instance);
    partial void UpdatekeysERRelationship(keysERRelationship instance);
    partial void DeletekeysERRelationship(keysERRelationship instance);
    #endregion
		
		public ERNotationModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ADBCConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ERNotationModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERNotationModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERNotationModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERNotationModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<keysERNotation> keysERNotations
		{
			get
			{
				return this.GetTable<keysERNotation>();
			}
		}
		
		public System.Data.Linq.Table<keysERRelationship> keysERRelationships
		{
			get
			{
				return this.GetTable<keysERRelationship>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectERNotations")]
		public ISingleResult<keysERNotation> SelectERNotations()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<keysERNotation>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectERRelationships")]
		public ISingleResult<keysERRelationship> SelectERRelationships()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<keysERRelationship>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysERNotation")]
	public partial class keysERNotation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ERNotationID;
		
		private string _DescriptionShort;
		
		private string _DescriptionLong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnERNotationIDChanging(int value);
    partial void OnERNotationIDChanged();
    partial void OnDescriptionShortChanging(string value);
    partial void OnDescriptionShortChanged();
    partial void OnDescriptionLongChanging(string value);
    partial void OnDescriptionLongChanged();
    #endregion
		
		public keysERNotation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERNotationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ERNotationID
		{
			get
			{
				return this._ERNotationID;
			}
			set
			{
				if ((this._ERNotationID != value))
				{
					this.OnERNotationIDChanging(value);
					this.SendPropertyChanging();
					this._ERNotationID = value;
					this.SendPropertyChanged("ERNotationID");
					this.OnERNotationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionShort", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string DescriptionShort
		{
			get
			{
				return this._DescriptionShort;
			}
			set
			{
				if ((this._DescriptionShort != value))
				{
					this.OnDescriptionShortChanging(value);
					this.SendPropertyChanging();
					this._DescriptionShort = value;
					this.SendPropertyChanged("DescriptionShort");
					this.OnDescriptionShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionLong", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string DescriptionLong
		{
			get
			{
				return this._DescriptionLong;
			}
			set
			{
				if ((this._DescriptionLong != value))
				{
					this.OnDescriptionLongChanging(value);
					this.SendPropertyChanging();
					this._DescriptionLong = value;
					this.SendPropertyChanged("DescriptionLong");
					this.OnDescriptionLongChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysERRelationship")]
	public partial class keysERRelationship : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ERRelationshipID;
		
		private string _DescriptionShort;
		
		private string _DescriptionLong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnERRelationshipIDChanging(int value);
    partial void OnERRelationshipIDChanged();
    partial void OnDescriptionShortChanging(string value);
    partial void OnDescriptionShortChanged();
    partial void OnDescriptionLongChanging(string value);
    partial void OnDescriptionLongChanged();
    #endregion
		
		public keysERRelationship()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERRelationshipID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ERRelationshipID
		{
			get
			{
				return this._ERRelationshipID;
			}
			set
			{
				if ((this._ERRelationshipID != value))
				{
					this.OnERRelationshipIDChanging(value);
					this.SendPropertyChanging();
					this._ERRelationshipID = value;
					this.SendPropertyChanged("ERRelationshipID");
					this.OnERRelationshipIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionShort", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string DescriptionShort
		{
			get
			{
				return this._DescriptionShort;
			}
			set
			{
				if ((this._DescriptionShort != value))
				{
					this.OnDescriptionShortChanging(value);
					this.SendPropertyChanging();
					this._DescriptionShort = value;
					this.SendPropertyChanged("DescriptionShort");
					this.OnDescriptionShortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionLong", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string DescriptionLong
		{
			get
			{
				return this._DescriptionLong;
			}
			set
			{
				if ((this._DescriptionLong != value))
				{
					this.OnDescriptionLongChanging(value);
					this.SendPropertyChanging();
					this._DescriptionLong = value;
					this.SendPropertyChanged("DescriptionLong");
					this.OnDescriptionLongChanged();
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
