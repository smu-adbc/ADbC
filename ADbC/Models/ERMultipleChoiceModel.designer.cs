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
	public partial class ERMultipleChoiceModelDataContext : ModuleBaseModelDataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertkeysERAnswer(keysERAnswer instance);
    partial void UpdatekeysERAnswer(keysERAnswer instance);
    partial void DeletekeysERAnswer(keysERAnswer instance);
    partial void InsertkeysERQuestion(keysERQuestion instance);
    partial void UpdatekeysERQuestion(keysERQuestion instance);
    partial void DeletekeysERQuestion(keysERQuestion instance);
    #endregion
		
		public ERMultipleChoiceModelDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ADBCConnectionString2"].ConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<keysERAnswer> keysERAnswers
		{
			get
			{
				return this.GetTable<keysERAnswer>();
			}
		}
		
		public System.Data.Linq.Table<keysERQuestion> keysERQuestions
		{
			get
			{
				return this.GetTable<keysERQuestion>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectERAnswersByQuestionID")]
		public ISingleResult<keysERAnswer> SelectERAnswersByQuestionID([global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERQuestionID", DbType="Int")] System.Nullable<int> eRQuestionID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), eRQuestionID);
			return ((ISingleResult<keysERAnswer>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SelectERQuestionByDescShort")]
		public ISingleResult<keysERQuestion> SelectERQuestionByDescShort([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescriptionShort", DbType="VarChar(1)")] string descriptionShort)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), descriptionShort);
			return ((ISingleResult<keysERQuestion>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysERAnswer")]
	public partial class keysERAnswer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ERAnswerID;
		
		private int _RelativeAnswerID;
		
		private int _QuestionID;
		
		private bool _Correct;
		
		private string _DialogText;
		
		private EntityRef<keysERQuestion> _keysERQuestion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnERAnswerIDChanging(int value);
    partial void OnERAnswerIDChanged();
    partial void OnRelativeAnswerIDChanging(int value);
    partial void OnRelativeAnswerIDChanged();
    partial void OnQuestionIDChanging(int value);
    partial void OnQuestionIDChanged();
    partial void OnCorrectChanging(bool value);
    partial void OnCorrectChanged();
    partial void OnDialogTextChanging(string value);
    partial void OnDialogTextChanged();
    #endregion
		
		public keysERAnswer()
		{
			this._keysERQuestion = default(EntityRef<keysERQuestion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERAnswerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ERAnswerID
		{
			get
			{
				return this._ERAnswerID;
			}
			set
			{
				if ((this._ERAnswerID != value))
				{
					this.OnERAnswerIDChanging(value);
					this.SendPropertyChanging();
					this._ERAnswerID = value;
					this.SendPropertyChanged("ERAnswerID");
					this.OnERAnswerIDChanged();
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
					if (this._keysERQuestion.HasLoadedOrAssignedValue)
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DialogText", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string DialogText
		{
			get
			{
				return this._DialogText;
			}
			set
			{
				if ((this._DialogText != value))
				{
					this.OnDialogTextChanging(value);
					this.SendPropertyChanging();
					this._DialogText = value;
					this.SendPropertyChanged("DialogText");
					this.OnDialogTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysERQuestion_keysERAnswer", Storage="_keysERQuestion", ThisKey="QuestionID", OtherKey="ERQuestionID", IsForeignKey=true)]
		public keysERQuestion keysERQuestion
		{
			get
			{
				return this._keysERQuestion.Entity;
			}
			set
			{
				keysERQuestion previousValue = this._keysERQuestion.Entity;
				if (((previousValue != value) 
							|| (this._keysERQuestion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._keysERQuestion.Entity = null;
						previousValue.keysERAnswers.Remove(this);
					}
					this._keysERQuestion.Entity = value;
					if ((value != null))
					{
						value.keysERAnswers.Add(this);
						this._QuestionID = value.ERQuestionID;
					}
					else
					{
						this._QuestionID = default(int);
					}
					this.SendPropertyChanged("keysERQuestion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.keysERQuestion")]
	public partial class keysERQuestion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ERQuestionID;
		
		private string _Title;
		
		private string _DescriptionLong;
		
		private string _DescriptionShort;
		
		private EntitySet<keysERAnswer> _keysERAnswers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnERQuestionIDChanging(int value);
    partial void OnERQuestionIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionLongChanging(string value);
    partial void OnDescriptionLongChanged();
    partial void OnDescriptionShortChanging(string value);
    partial void OnDescriptionShortChanged();
    #endregion
		
		public keysERQuestion()
		{
			this._keysERAnswers = new EntitySet<keysERAnswer>(new Action<keysERAnswer>(this.attach_keysERAnswers), new Action<keysERAnswer>(this.detach_keysERAnswers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ERQuestionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ERQuestionID
		{
			get
			{
				return this._ERQuestionID;
			}
			set
			{
				if ((this._ERQuestionID != value))
				{
					this.OnERQuestionIDChanging(value);
					this.SendPropertyChanging();
					this._ERQuestionID = value;
					this.SendPropertyChanged("ERQuestionID");
					this.OnERQuestionIDChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="keysERQuestion_keysERAnswer", Storage="_keysERAnswers", ThisKey="ERQuestionID", OtherKey="QuestionID")]
		public EntitySet<keysERAnswer> keysERAnswers
		{
			get
			{
				return this._keysERAnswers;
			}
			set
			{
				this._keysERAnswers.Assign(value);
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
		
		private void attach_keysERAnswers(keysERAnswer entity)
		{
			this.SendPropertyChanging();
			entity.keysERQuestion = this;
		}
		
		private void detach_keysERAnswers(keysERAnswer entity)
		{
			this.SendPropertyChanging();
			entity.keysERQuestion = null;
		}
	}
}
#pragma warning restore 1591