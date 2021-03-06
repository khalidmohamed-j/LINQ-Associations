#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ_Assocations
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Birds")]
	public partial class BirdsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBird(Bird instance);
    partial void UpdateBird(Bird instance);
    partial void DeleteBird(Bird instance);
    partial void InsertBirdCount(BirdCount instance);
    partial void UpdateBirdCount(BirdCount instance);
    partial void DeleteBirdCount(BirdCount instance);
    #endregion
		
		public BirdsDataContext() : 
				base(global::LINQ_Assocations.Properties.Settings.Default.BirdsConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public BirdsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BirdsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BirdsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BirdsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bird> Birds
		{
			get
			{
				return this.GetTable<Bird>();
			}
		}
		
		public System.Data.Linq.Table<BirdCount> BirdCounts
		{
			get
			{
				return this.GetTable<BirdCount>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bird")]
	public partial class Bird : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BirdID;
		
		private string _Name;
		
		private string _Description;
		
		private EntitySet<BirdCount> _BirdCounts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBirdIDChanging(string value);
    partial void OnBirdIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public Bird()
		{
			this._BirdCounts = new EntitySet<BirdCount>(new Action<BirdCount>(this.attach_BirdCounts), new Action<BirdCount>(this.detach_BirdCounts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirdID", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BirdID
		{
			get
			{
				return this._BirdID;
			}
			set
			{
				if ((this._BirdID != value))
				{
					this.OnBirdIDChanging(value);
					this.SendPropertyChanging();
					this._BirdID = value;
					this.SendPropertyChanged("BirdID");
					this.OnBirdIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bird_BirdCount", Storage="_BirdCounts", ThisKey="BirdID", OtherKey="BirdID")]
		public EntitySet<BirdCount> BirdCounts
		{
			get
			{
				return this._BirdCounts;
			}
			set
			{
				this._BirdCounts.Assign(value);
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
		
		private void attach_BirdCounts(BirdCount entity)
		{
			this.SendPropertyChanging();
			entity.Bird = this;
		}
		
		private void detach_BirdCounts(BirdCount entity)
		{
			this.SendPropertyChanging();
			entity.Bird = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BirdCount")]
	public partial class BirdCount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CountID;
		
		private string _RegionID;
		
		private int _BirderID;
		
		private string _BirdID;
		
		private System.DateTime _CountDate;
		
		private int _Counted;
		
		private EntityRef<Bird> _Bird;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountIDChanging(int value);
    partial void OnCountIDChanged();
    partial void OnRegionIDChanging(string value);
    partial void OnRegionIDChanged();
    partial void OnBirderIDChanging(int value);
    partial void OnBirderIDChanged();
    partial void OnBirdIDChanging(string value);
    partial void OnBirdIDChanged();
    partial void OnCountDateChanging(System.DateTime value);
    partial void OnCountDateChanged();
    partial void OnCountedChanging(int value);
    partial void OnCountedChanged();
    #endregion
		
		public BirdCount()
		{
			this._Bird = default(EntityRef<Bird>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CountID
		{
			get
			{
				return this._CountID;
			}
			set
			{
				if ((this._CountID != value))
				{
					this.OnCountIDChanging(value);
					this.SendPropertyChanging();
					this._CountID = value;
					this.SendPropertyChanged("CountID");
					this.OnCountIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegionID", DbType="NVarChar(5) NOT NULL", CanBeNull=false)]
		public string RegionID
		{
			get
			{
				return this._RegionID;
			}
			set
			{
				if ((this._RegionID != value))
				{
					this.OnRegionIDChanging(value);
					this.SendPropertyChanging();
					this._RegionID = value;
					this.SendPropertyChanged("RegionID");
					this.OnRegionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirderID", DbType="Int NOT NULL")]
		public int BirderID
		{
			get
			{
				return this._BirderID;
			}
			set
			{
				if ((this._BirderID != value))
				{
					this.OnBirderIDChanging(value);
					this.SendPropertyChanging();
					this._BirderID = value;
					this.SendPropertyChanged("BirderID");
					this.OnBirderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirdID", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string BirdID
		{
			get
			{
				return this._BirdID;
			}
			set
			{
				if ((this._BirdID != value))
				{
					if (this._Bird.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBirdIDChanging(value);
					this.SendPropertyChanging();
					this._BirdID = value;
					this.SendPropertyChanged("BirdID");
					this.OnBirdIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountDate", DbType="SmallDateTime NOT NULL")]
		public System.DateTime CountDate
		{
			get
			{
				return this._CountDate;
			}
			set
			{
				if ((this._CountDate != value))
				{
					this.OnCountDateChanging(value);
					this.SendPropertyChanging();
					this._CountDate = value;
					this.SendPropertyChanged("CountDate");
					this.OnCountDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Counted", DbType="Int NOT NULL")]
		public int Counted
		{
			get
			{
				return this._Counted;
			}
			set
			{
				if ((this._Counted != value))
				{
					this.OnCountedChanging(value);
					this.SendPropertyChanging();
					this._Counted = value;
					this.SendPropertyChanged("Counted");
					this.OnCountedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bird_BirdCount", Storage="_Bird", ThisKey="BirdID", OtherKey="BirdID", IsForeignKey=true)]
		public Bird Bird
		{
			get
			{
				return this._Bird.Entity;
			}
			set
			{
				Bird previousValue = this._Bird.Entity;
				if (((previousValue != value) 
							|| (this._Bird.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bird.Entity = null;
						previousValue.BirdCounts.Remove(this);
					}
					this._Bird.Entity = value;
					if ((value != null))
					{
						value.BirdCounts.Add(this);
						this._BirdID = value.BirdID;
					}
					else
					{
						this._BirdID = default(string);
					}
					this.SendPropertyChanged("Bird");
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
