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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="adbc")]
	public partial class ERMultipleChoiceModelDataContext : ModuleBaseModelDataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMCAnswer(MCAnswer instance);
    partial void UpdateMCAnswer(MCAnswer instance);
    partial void DeleteMCAnswer(MCAnswer instance);
    partial void InsertMCQuestion(MCQuestion instance);
    partial void UpdateMCQuestion(MCQuestion instance);
    partial void DeleteMCQuestion(MCQuestion instance);
    #endregion
		
		public ERMultipleChoiceModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["adbcConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ERMultipleChoiceModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERMultipleChoiceModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERMultipleChoiceModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ERMultipleChoiceModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MCAnswer> MCAnswers
		{
			get
			{
				return this.GetTable<MCAnswer>();
			}
		}
		
		public System.Data.Linq.Table<MCQuestion> MCQuestions
		{
			get
			{
				return this.GetTable<MCQuestion>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectMCAnswersByQuestionID")]
		public ISingleResult<MCAnswer> SelectMCAnswersByQuestionID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERQuestionID", DbType="Int")] System.Nullable<int> eRQuestionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eRQuestionID);
			return ((ISingleResult<MCAnswer>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectMCQuestionsByModuleName")]
		public ISingleResult<MCQuestion> SelectMCQuestionsByModuleName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ModuleName", DbType="VarChar(50)")] string moduleName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), moduleName);
			return ((ISingleResult<MCQuestion>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectMCQuestionByDescShort")]
		public ISingleResult<MCQuestion> SelectMCQuestionByDescShort([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionShort", DbType="VarChar(50)")] string descriptionShort)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), descriptionShort);
			return ((ISingleResult<MCQuestion>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MCAnswer")]
	public partial class MCAnswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MCAnswerID;
		
		private int _RelativeAnswerID;
		
		private int _QuestionID;
		
		private bool _Correct;
		
		private string _ResponseText;
		
		private EntityRef<MCQuestion> _MCQuestion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMCAnswerIDChanging(int value);
    partial void OnMCAnswerIDChanged();
    partial void OnRelativeAnswerIDChanging(int value);
    partial void OnRelativeAnswerIDChanged();
    partial void OnQuestionIDChanging(int value);
    partial void OnQuestionIDChanged();
    partial void OnCorrectChanging(bool value);
    partial void OnCorrectChanged();
    partial void OnResponseTextChanging(string value);
    partial void OnResponseTextChanged();
    #endregion
		
		public MCAnswer()
		{
			this._MCQuestion = default(EntityRef<MCQuestion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MCAnswerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MCAnswerID
		{
			get
			{
				return this._MCAnswerID;
			}
			set
			{
				if ((this._MCAnswerID != value))
				{
					this.OnMCAnswerIDChanging(value);
					this.SendPropertyChanging();
					this._MCAnswerID = value;
					this.SendPropertyChanged("MCAnswerID");
					this.OnMCAnswerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RelativeAnswerID", DbType="Int NOT NULL")]
		public int RelativeAnswerID
		{
			get
			{
				return this._RelativeAnswerID;
			}
			set
			{
				if ((this._RelativeAnswerID != value))
				{
					this.OnRelativeAnswerIDChanging(value);
					this.SendPropertyChanging();
					this._RelativeAnswerID = value;
					this.SendPropertyChanged("RelativeAnswerID");
					this.OnRelativeAnswerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="Int NOT NULL")]
		public int QuestionID
		{
			get
			{
				return this._QuestionID;
			}
			set
			{
				if ((this._QuestionID != value))
				{
					if (this._MCQuestion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._QuestionID = value;
					this.SendPropertyChanged("QuestionID");
					this.OnQuestionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Correct", DbType="Bit NOT NULL")]
		public bool Correct
		{
			get
			{
				return this._Correct;
			}
			set
			{
				if ((this._Correct != value))
				{
					this.OnCorrectChanging(value);
					this.SendPropertyChanging();
					this._Correct = value;
					this.SendPropertyChanged("Correct");
					this.OnCorrectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ResponseText", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ResponseText
		{
			get
			{
				return this._ResponseText;
			}
			set
			{
				if ((this._ResponseText != value))
				{
					this.OnResponseTextChanging(value);
					this.SendPropertyChanging();
					this._ResponseText = value;
					this.SendPropertyChanged("ResponseText");
					this.OnResponseTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MCQuestion_MCAnswer", Storage="_MCQuestion", ThisKey="QuestionID", OtherKey="MCQuestionID", IsForeignKey=true)]
		public MCQuestion MCQuestion
		{
			get
			{
				return this._MCQuestion.Entity;
			}
			set
			{
				MCQuestion previousValue = this._MCQuestion.Entity;
				if (((previousValue != value) 
							|| (this._MCQuestion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MCQuestion.Entity = null;
						previousValue.MCAnswers.Remove(this);
					}
					this._MCQuestion.Entity = value;
					if ((value != null))
					{
						value.MCAnswers.Add(this);
						this._QuestionID = value.MCQuestionID;
					}
					else
					{
						this._QuestionID = default(int);
					}
					this.SendPropertyChanged("MCQuestion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MCQuestion")]
	public partial class MCQuestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MCQuestionID;
		
		private int _ModuleID;
		
		private string _Title;
		
		private string _DescriptionLong;
		
		private string _DescriptionShort;
		
		private EntitySet<MCAnswer> _MCAnswers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMCQuestionIDChanging(int value);
    partial void OnMCQuestionIDChanged();
    partial void OnModuleIDChanging(int value);
    partial void OnModuleIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionLongChanging(string value);
    partial void OnDescriptionLongChanged();
    partial void OnDescriptionShortChanging(string value);
    partial void OnDescriptionShortChanged();
    #endregion
		
		public MCQuestion()
		{
			this._MCAnswers = new EntitySet<MCAnswer>(new Action<MCAnswer>(this.attach_MCAnswers), new Action<MCAnswer>(this.detach_MCAnswers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MCQuestionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MCQuestionID
		{
			get
			{
				return this._MCQuestionID;
			}
			set
			{
				if ((this._MCQuestionID != value))
				{
					this.OnMCQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._MCQuestionID = value;
					this.SendPropertyChanged("MCQuestionID");
					this.OnMCQuestionIDChanged();
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
					this.OnModuleIDChanging(value);
					this.SendPropertyChanging();
					this._ModuleID = value;
					this.SendPropertyChanged("ModuleID");
					this.OnModuleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionLong", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescriptionShort", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MCQuestion_MCAnswer", Storage="_MCAnswers", ThisKey="MCQuestionID", OtherKey="QuestionID")]
		public EntitySet<MCAnswer> MCAnswers
		{
			get
			{
				return this._MCAnswers;
			}
			set
			{
				this._MCAnswers.Assign(value);
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
		
		private void attach_MCAnswers(MCAnswer entity)
		{
			this.SendPropertyChanging();
			entity.MCQuestion = this;
		}
		
		private void detach_MCAnswers(MCAnswer entity)
		{
			this.SendPropertyChanging();
			entity.MCQuestion = null;
		}
	}
}
#pragma warning restore 1591
