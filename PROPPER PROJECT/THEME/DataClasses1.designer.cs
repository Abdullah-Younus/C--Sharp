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

namespace THEME
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Telephone")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertinfoation(infoation instance);
    partial void Updateinfoation(infoation instance);
    partial void Deleteinfoation(infoation instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::THEME.Properties.Settings.Default.TelephoneConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<infoation> infoations
		{
			get
			{
				return this.GetTable<infoation>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.infoation")]
	public partial class infoation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _TelephoneNO;
		
		private string _Addres;
		
		private string _City;
		
		private string _Mode_of_connection;
		
		private string _type_of_conntion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnTelephoneNOChanging(string value);
    partial void OnTelephoneNOChanged();
    partial void OnAddresChanging(string value);
    partial void OnAddresChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnMode_of_connectionChanging(string value);
    partial void OnMode_of_connectionChanged();
    partial void Ontype_of_conntionChanging(string value);
    partial void Ontype_of_conntionChanged();
    #endregion
		
		public infoation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephoneNO", DbType="VarChar(50)")]
		public string TelephoneNO
		{
			get
			{
				return this._TelephoneNO;
			}
			set
			{
				if ((this._TelephoneNO != value))
				{
					this.OnTelephoneNOChanging(value);
					this.SendPropertyChanging();
					this._TelephoneNO = value;
					this.SendPropertyChanged("TelephoneNO");
					this.OnTelephoneNOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Addres", DbType="VarChar(50)")]
		public string Addres
		{
			get
			{
				return this._Addres;
			}
			set
			{
				if ((this._Addres != value))
				{
					this.OnAddresChanging(value);
					this.SendPropertyChanging();
					this._Addres = value;
					this.SendPropertyChanged("Addres");
					this.OnAddresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mode_of_connection", DbType="VarChar(50)")]
		public string Mode_of_connection
		{
			get
			{
				return this._Mode_of_connection;
			}
			set
			{
				if ((this._Mode_of_connection != value))
				{
					this.OnMode_of_connectionChanging(value);
					this.SendPropertyChanging();
					this._Mode_of_connection = value;
					this.SendPropertyChanged("Mode_of_connection");
					this.OnMode_of_connectionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_type_of_conntion", DbType="VarChar(50)")]
		public string type_of_conntion
		{
			get
			{
				return this._type_of_conntion;
			}
			set
			{
				if ((this._type_of_conntion != value))
				{
					this.Ontype_of_conntionChanging(value);
					this.SendPropertyChanging();
					this._type_of_conntion = value;
					this.SendPropertyChanged("type_of_conntion");
					this.Ontype_of_conntionChanged();
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
