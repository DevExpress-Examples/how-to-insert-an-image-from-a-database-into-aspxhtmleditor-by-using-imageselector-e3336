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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ArtsDB")]
public partial class ArtsDataClassDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertArt(Art instance);
  partial void UpdateArt(Art instance);
  partial void DeleteArt(Art instance);
  #endregion
	
	public ArtsDataClassDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ArtsDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public ArtsDataClassDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ArtsDataClassDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ArtsDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ArtsDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Art> Arts
	{
		get
		{
			return this.GetTable<Art>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Arts")]
public partial class Art : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private System.Nullable<System.DateTime> _LastWriteTime;
	
	private string _Name;
	
	private int _ID;
	
	private System.Nullable<int> _ParentID;
	
	private System.Nullable<bool> _IsFolder;
	
	private System.Data.Linq.Binary _Data;
	
	private System.Nullable<int> _OptimisticLockField;
	
	private System.Nullable<int> _GCRecord;
	
	private System.Data.Linq.Binary _SSMA_TimeStamp;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLastWriteTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLastWriteTimeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnParentIDChanging(System.Nullable<int> value);
    partial void OnParentIDChanged();
    partial void OnIsFolderChanging(System.Nullable<bool> value);
    partial void OnIsFolderChanged();
    partial void OnDataChanging(System.Data.Linq.Binary value);
    partial void OnDataChanged();
    partial void OnOptimisticLockFieldChanging(System.Nullable<int> value);
    partial void OnOptimisticLockFieldChanged();
    partial void OnGCRecordChanging(System.Nullable<int> value);
    partial void OnGCRecordChanged();
    partial void OnSSMA_TimeStampChanging(System.Data.Linq.Binary value);
    partial void OnSSMA_TimeStampChanged();
    #endregion
	
	public Art()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastWriteTime", DbType="DateTime", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<System.DateTime> LastWriteTime
	{
		get
		{
			return this._LastWriteTime;
		}
		set
		{
			if ((this._LastWriteTime != value))
			{
				this.OnLastWriteTimeChanging(value);
				this.SendPropertyChanging();
				this._LastWriteTime = value;
				this.SendPropertyChanged("LastWriteTime");
				this.OnLastWriteTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100)", UpdateCheck=UpdateCheck.Never)]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentID", DbType="Int", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<int> ParentID
	{
		get
		{
			return this._ParentID;
		}
		set
		{
			if ((this._ParentID != value))
			{
				this.OnParentIDChanging(value);
				this.SendPropertyChanging();
				this._ParentID = value;
				this.SendPropertyChanged("ParentID");
				this.OnParentIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsFolder", DbType="Bit", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<bool> IsFolder
	{
		get
		{
			return this._IsFolder;
		}
		set
		{
			if ((this._IsFolder != value))
			{
				this.OnIsFolderChanging(value);
				this.SendPropertyChanging();
				this._IsFolder = value;
				this.SendPropertyChanged("IsFolder");
				this.OnIsFolderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="VarBinary(MAX)", CanBeNull=true, UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary Data
	{
		get
		{
			return this._Data;
		}
		set
		{
			if ((this._Data != value))
			{
				this.OnDataChanging(value);
				this.SendPropertyChanging();
				this._Data = value;
				this.SendPropertyChanged("Data");
				this.OnDataChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OptimisticLockField", DbType="Int", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<int> OptimisticLockField
	{
		get
		{
			return this._OptimisticLockField;
		}
		set
		{
			if ((this._OptimisticLockField != value))
			{
				this.OnOptimisticLockFieldChanging(value);
				this.SendPropertyChanging();
				this._OptimisticLockField = value;
				this.SendPropertyChanged("OptimisticLockField");
				this.OnOptimisticLockFieldChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GCRecord", DbType="Int", UpdateCheck=UpdateCheck.Never)]
	public System.Nullable<int> GCRecord
	{
		get
		{
			return this._GCRecord;
		}
		set
		{
			if ((this._GCRecord != value))
			{
				this.OnGCRecordChanging(value);
				this.SendPropertyChanging();
				this._GCRecord = value;
				this.SendPropertyChanged("GCRecord");
				this.OnGCRecordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SSMA_TimeStamp", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
	public System.Data.Linq.Binary SSMA_TimeStamp
	{
		get
		{
			return this._SSMA_TimeStamp;
		}
		set
		{
			if ((this._SSMA_TimeStamp != value))
			{
				this.OnSSMA_TimeStampChanging(value);
				this.SendPropertyChanging();
				this._SSMA_TimeStamp = value;
				this.SendPropertyChanged("SSMA_TimeStamp");
				this.OnSSMA_TimeStampChanged();
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
#pragma warning restore 1591