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

namespace AvitaPharmacy
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Avita")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMedicineTable(MedicineTable instance);
    partial void UpdateMedicineTable(MedicineTable instance);
    partial void DeleteMedicineTable(MedicineTable instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertSalesReport(SalesReport instance);
    partial void UpdateSalesReport(SalesReport instance);
    partial void DeleteSalesReport(SalesReport instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::AvitaPharmacy.Properties.Settings.Default.AvitaConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<MedicineTable> MedicineTables
		{
			get
			{
				return this.GetTable<MedicineTable>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<SalesReport> SalesReports
		{
			get
			{
				return this.GetTable<SalesReport>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MedicineTable")]
	public partial class MedicineTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MedicineID;
		
		private string _Medicine_Name;
		
		private string _Category;
		
		private System.Nullable<int> _Quantity;
		
		private string _Manufacturer;
		
		private System.Nullable<System.DateTime> _Entry_Date;
		
		private System.Nullable<System.DateTime> _Production_Date;
		
		private System.Nullable<System.DateTime> _Expiring_Date;
		
		private System.Nullable<double> _Selling_Price;
		
		private System.Nullable<double> _Buying_Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedicineIDChanging(string value);
    partial void OnMedicineIDChanged();
    partial void OnMedicine_NameChanging(string value);
    partial void OnMedicine_NameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnEntry_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnEntry_DateChanged();
    partial void OnProduction_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnProduction_DateChanged();
    partial void OnExpiring_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnExpiring_DateChanged();
    partial void OnSelling_PriceChanging(System.Nullable<double> value);
    partial void OnSelling_PriceChanged();
    partial void OnBuying_PriceChanging(System.Nullable<double> value);
    partial void OnBuying_PriceChanged();
    #endregion
		
		public MedicineTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineID", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MedicineID
		{
			get
			{
				return this._MedicineID;
			}
			set
			{
				if ((this._MedicineID != value))
				{
					this.OnMedicineIDChanging(value);
					this.SendPropertyChanging();
					this._MedicineID = value;
					this.SendPropertyChanged("MedicineID");
					this.OnMedicineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine_Name", DbType="VarChar(40)")]
		public string Medicine_Name
		{
			get
			{
				return this._Medicine_Name;
			}
			set
			{
				if ((this._Medicine_Name != value))
				{
					this.OnMedicine_NameChanging(value);
					this.SendPropertyChanging();
					this._Medicine_Name = value;
					this.SendPropertyChanged("Medicine_Name");
					this.OnMedicine_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(40)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="VarChar(30)")]
		public string Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}
			set
			{
				if ((this._Manufacturer != value))
				{
					this.OnManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Manufacturer = value;
					this.SendPropertyChanged("Manufacturer");
					this.OnManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Entry_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Entry_Date
		{
			get
			{
				return this._Entry_Date;
			}
			set
			{
				if ((this._Entry_Date != value))
				{
					this.OnEntry_DateChanging(value);
					this.SendPropertyChanging();
					this._Entry_Date = value;
					this.SendPropertyChanged("Entry_Date");
					this.OnEntry_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Production_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Production_Date
		{
			get
			{
				return this._Production_Date;
			}
			set
			{
				if ((this._Production_Date != value))
				{
					this.OnProduction_DateChanging(value);
					this.SendPropertyChanging();
					this._Production_Date = value;
					this.SendPropertyChanged("Production_Date");
					this.OnProduction_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expiring_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Expiring_Date
		{
			get
			{
				return this._Expiring_Date;
			}
			set
			{
				if ((this._Expiring_Date != value))
				{
					this.OnExpiring_DateChanging(value);
					this.SendPropertyChanging();
					this._Expiring_Date = value;
					this.SendPropertyChanged("Expiring_Date");
					this.OnExpiring_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Selling_Price", DbType="Float")]
		public System.Nullable<double> Selling_Price
		{
			get
			{
				return this._Selling_Price;
			}
			set
			{
				if ((this._Selling_Price != value))
				{
					this.OnSelling_PriceChanging(value);
					this.SendPropertyChanging();
					this._Selling_Price = value;
					this.SendPropertyChanged("Selling_Price");
					this.OnSelling_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Buying_Price", DbType="Float")]
		public System.Nullable<double> Buying_Price
		{
			get
			{
				return this._Buying_Price;
			}
			set
			{
				if ((this._Buying_Price != value))
				{
					this.OnBuying_PriceChanging(value);
					this.SendPropertyChanging();
					this._Buying_Price = value;
					this.SendPropertyChanged("Buying_Price");
					this.OnBuying_PriceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _First_Name;
		
		private string _Last_Name;
		
		private string _User_Type;
		
		private string _Password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnFirst_NameChanging(string value);
    partial void OnFirst_NameChanged();
    partial void OnLast_NameChanging(string value);
    partial void OnLast_NameChanged();
    partial void OnUser_TypeChanging(string value);
    partial void OnUser_TypeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="VarChar(25) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_First_Name", DbType="VarChar(30)")]
		public string First_Name
		{
			get
			{
				return this._First_Name;
			}
			set
			{
				if ((this._First_Name != value))
				{
					this.OnFirst_NameChanging(value);
					this.SendPropertyChanging();
					this._First_Name = value;
					this.SendPropertyChanged("First_Name");
					this.OnFirst_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Last_Name", DbType="VarChar(30)")]
		public string Last_Name
		{
			get
			{
				return this._Last_Name;
			}
			set
			{
				if ((this._Last_Name != value))
				{
					this.OnLast_NameChanging(value);
					this.SendPropertyChanging();
					this._Last_Name = value;
					this.SendPropertyChanged("Last_Name");
					this.OnLast_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_Type", DbType="VarChar(15)")]
		public string User_Type
		{
			get
			{
				return this._User_Type;
			}
			set
			{
				if ((this._User_Type != value))
				{
					this.OnUser_TypeChanging(value);
					this.SendPropertyChanging();
					this._User_Type = value;
					this.SendPropertyChanged("User_Type");
					this.OnUser_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(32)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SalesReport")]
	public partial class SalesReport : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Buyer;
		
		private string _Seller;
		
		private string _Medicine_Name;
		
		private string _Category;
		
		private string _Manufacturer;
		
		private System.Nullable<System.DateTime> _Production_Date;
		
		private System.Nullable<System.DateTime> _Expiring_Date;
		
		private System.Nullable<int> _Quantity;
		
		private System.Nullable<double> _Selling_Price;
		
		private System.Nullable<double> _Buying_Price;
		
		private System.Nullable<double> _Profit_Gained;
		
		private System.Nullable<System.DateTime> _Date_Of_Sale;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnBuyerChanging(string value);
    partial void OnBuyerChanged();
    partial void OnSellerChanging(string value);
    partial void OnSellerChanged();
    partial void OnMedicine_NameChanging(string value);
    partial void OnMedicine_NameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnProduction_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnProduction_DateChanged();
    partial void OnExpiring_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnExpiring_DateChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    partial void OnSelling_PriceChanging(System.Nullable<double> value);
    partial void OnSelling_PriceChanged();
    partial void OnBuying_PriceChanging(System.Nullable<double> value);
    partial void OnBuying_PriceChanged();
    partial void OnProfit_GainedChanging(System.Nullable<double> value);
    partial void OnProfit_GainedChanged();
    partial void OnDate_Of_SaleChanging(System.Nullable<System.DateTime> value);
    partial void OnDate_Of_SaleChanged();
    #endregion
		
		public SalesReport()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Buyer", DbType="VarChar(70)")]
		public string Buyer
		{
			get
			{
				return this._Buyer;
			}
			set
			{
				if ((this._Buyer != value))
				{
					this.OnBuyerChanging(value);
					this.SendPropertyChanging();
					this._Buyer = value;
					this.SendPropertyChanged("Buyer");
					this.OnBuyerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seller", DbType="VarChar(20)")]
		public string Seller
		{
			get
			{
				return this._Seller;
			}
			set
			{
				if ((this._Seller != value))
				{
					this.OnSellerChanging(value);
					this.SendPropertyChanging();
					this._Seller = value;
					this.SendPropertyChanged("Seller");
					this.OnSellerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine_Name", DbType="VarChar(40)")]
		public string Medicine_Name
		{
			get
			{
				return this._Medicine_Name;
			}
			set
			{
				if ((this._Medicine_Name != value))
				{
					this.OnMedicine_NameChanging(value);
					this.SendPropertyChanging();
					this._Medicine_Name = value;
					this.SendPropertyChanged("Medicine_Name");
					this.OnMedicine_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="VarChar(40)")]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="VarChar(30)")]
		public string Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}
			set
			{
				if ((this._Manufacturer != value))
				{
					this.OnManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Manufacturer = value;
					this.SendPropertyChanged("Manufacturer");
					this.OnManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Production_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Production_Date
		{
			get
			{
				return this._Production_Date;
			}
			set
			{
				if ((this._Production_Date != value))
				{
					this.OnProduction_DateChanging(value);
					this.SendPropertyChanging();
					this._Production_Date = value;
					this.SendPropertyChanged("Production_Date");
					this.OnProduction_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expiring_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Expiring_Date
		{
			get
			{
				return this._Expiring_Date;
			}
			set
			{
				if ((this._Expiring_Date != value))
				{
					this.OnExpiring_DateChanging(value);
					this.SendPropertyChanging();
					this._Expiring_Date = value;
					this.SendPropertyChanged("Expiring_Date");
					this.OnExpiring_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
		public System.Nullable<int> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Selling_Price", DbType="Float")]
		public System.Nullable<double> Selling_Price
		{
			get
			{
				return this._Selling_Price;
			}
			set
			{
				if ((this._Selling_Price != value))
				{
					this.OnSelling_PriceChanging(value);
					this.SendPropertyChanging();
					this._Selling_Price = value;
					this.SendPropertyChanged("Selling_Price");
					this.OnSelling_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Buying_Price", DbType="Float")]
		public System.Nullable<double> Buying_Price
		{
			get
			{
				return this._Buying_Price;
			}
			set
			{
				if ((this._Buying_Price != value))
				{
					this.OnBuying_PriceChanging(value);
					this.SendPropertyChanging();
					this._Buying_Price = value;
					this.SendPropertyChanged("Buying_Price");
					this.OnBuying_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Profit_Gained", DbType="Float")]
		public System.Nullable<double> Profit_Gained
		{
			get
			{
				return this._Profit_Gained;
			}
			set
			{
				if ((this._Profit_Gained != value))
				{
					this.OnProfit_GainedChanging(value);
					this.SendPropertyChanging();
					this._Profit_Gained = value;
					this.SendPropertyChanged("Profit_Gained");
					this.OnProfit_GainedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Of_Sale", DbType="Date")]
		public System.Nullable<System.DateTime> Date_Of_Sale
		{
			get
			{
				return this._Date_Of_Sale;
			}
			set
			{
				if ((this._Date_Of_Sale != value))
				{
					this.OnDate_Of_SaleChanging(value);
					this.SendPropertyChanging();
					this._Date_Of_Sale = value;
					this.SendPropertyChanged("Date_Of_Sale");
					this.OnDate_Of_SaleChanged();
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
