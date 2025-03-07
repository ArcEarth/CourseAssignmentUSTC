﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripAdviserDesktopClient
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TripAdviserDatabase")]
	public partial class TripAdviserDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFlight(Flight instance);
    partial void UpdateFlight(Flight instance);
    partial void DeleteFlight(Flight instance);
    partial void InsertCity(City instance);
    partial void UpdateCity(City instance);
    partial void DeleteCity(City instance);
    #endregion
		
		public TripAdviserDataContext() : 
				base(global::TripAdviserDesktopClient.Properties.Settings.Default.TripAdviserDatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TripAdviserDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TripAdviserDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TripAdviserDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TripAdviserDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Flight> Flights
		{
			get
			{
				return this.GetTable<Flight>();
			}
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Flights")]
	public partial class Flight : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _SourceCity;
		
		private string _TargetCity;
		
		private System.Nullable<System.TimeSpan> _TakeoffTime;
		
		private System.Nullable<System.TimeSpan> _LandingTime;
		
		private EntityRef<City> _ArriveCity;
		
		private EntityRef<City> _DepartureCity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSourceCityChanging(string value);
    partial void OnSourceCityChanged();
    partial void OnTargetCityChanging(string value);
    partial void OnTargetCityChanged();
    partial void OnTakeoffTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnTakeoffTimeChanged();
    partial void OnLandingTimeChanging(System.Nullable<System.TimeSpan> value);
    partial void OnLandingTimeChanged();
    #endregion
		
		public Flight()
		{
			this._ArriveCity = default(EntityRef<City>);
			this._DepartureCity = default(EntityRef<City>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SourceCity", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string SourceCity
		{
			get
			{
				return this._SourceCity;
			}
			set
			{
				if ((this._SourceCity != value))
				{
					if (this._ArriveCity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSourceCityChanging(value);
					this.SendPropertyChanging();
					this._SourceCity = value;
					this.SendPropertyChanged("SourceCity");
					this.OnSourceCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetCity", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string TargetCity
		{
			get
			{
				return this._TargetCity;
			}
			set
			{
				if ((this._TargetCity != value))
				{
					if (this._DepartureCity.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTargetCityChanging(value);
					this.SendPropertyChanging();
					this._TargetCity = value;
					this.SendPropertyChanged("TargetCity");
					this.OnTargetCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TakeoffTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> TakeoffTime
		{
			get
			{
				return this._TakeoffTime;
			}
			set
			{
				if ((this._TakeoffTime != value))
				{
					this.OnTakeoffTimeChanging(value);
					this.SendPropertyChanging();
					this._TakeoffTime = value;
					this.SendPropertyChanged("TakeoffTime");
					this.OnTakeoffTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LandingTime", DbType="Time")]
		public System.Nullable<System.TimeSpan> LandingTime
		{
			get
			{
				return this._LandingTime;
			}
			set
			{
				if ((this._LandingTime != value))
				{
					this.OnLandingTimeChanging(value);
					this.SendPropertyChanging();
					this._LandingTime = value;
					this.SendPropertyChanged("LandingTime");
					this.OnLandingTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Flight", Storage="_ArriveCity", ThisKey="SourceCity", OtherKey="Name", IsForeignKey=true)]
		public City ArriveCity
		{
			get
			{
				return this._ArriveCity.Entity;
			}
			set
			{
				City previousValue = this._ArriveCity.Entity;
				if (((previousValue != value) 
							|| (this._ArriveCity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ArriveCity.Entity = null;
						previousValue.FlightsFromHere.Remove(this);
					}
					this._ArriveCity.Entity = value;
					if ((value != null))
					{
						value.FlightsFromHere.Add(this);
						this._SourceCity = value.Name;
					}
					else
					{
						this._SourceCity = default(string);
					}
					this.SendPropertyChanged("ArriveCity");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Flight1", Storage="_DepartureCity", ThisKey="TargetCity", OtherKey="Name", IsForeignKey=true)]
		public City DepartureCity
		{
			get
			{
				return this._DepartureCity.Entity;
			}
			set
			{
				City previousValue = this._DepartureCity.Entity;
				if (((previousValue != value) 
							|| (this._DepartureCity.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DepartureCity.Entity = null;
						previousValue.FlightsArriveHere.Remove(this);
					}
					this._DepartureCity.Entity = value;
					if ((value != null))
					{
						value.FlightsArriveHere.Add(this);
						this._TargetCity = value.Name;
					}
					else
					{
						this._TargetCity = default(string);
					}
					this.SendPropertyChanged("DepartureCity");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cities")]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private float _Longtitude;
		
		private System.Nullable<float> _Latitude;
		
		private EntitySet<Flight> _FlightsFromHere;
		
		private EntitySet<Flight> _FlightsArriveHere;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnLongtitudeChanging(float value);
    partial void OnLongtitudeChanged();
    partial void OnLatitudeChanging(System.Nullable<float> value);
    partial void OnLatitudeChanged();
    #endregion
		
		public City()
		{
			this._FlightsFromHere = new EntitySet<Flight>(new Action<Flight>(this.attach_FlightsFromHere), new Action<Flight>(this.detach_FlightsFromHere));
			this._FlightsArriveHere = new EntitySet<Flight>(new Action<Flight>(this.attach_FlightsArriveHere), new Action<Flight>(this.detach_FlightsArriveHere));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longtitude", DbType="Real NOT NULL")]
		public float Longtitude
		{
			get
			{
				return this._Longtitude;
			}
			set
			{
				if ((this._Longtitude != value))
				{
					this.OnLongtitudeChanging(value);
					this.SendPropertyChanging();
					this._Longtitude = value;
					this.SendPropertyChanged("Longtitude");
					this.OnLongtitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="Real")]
		public System.Nullable<float> Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Flight", Storage="_FlightsFromHere", ThisKey="Name", OtherKey="SourceCity")]
		public EntitySet<Flight> FlightsFromHere
		{
			get
			{
				return this._FlightsFromHere;
			}
			set
			{
				this._FlightsFromHere.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Flight1", Storage="_FlightsArriveHere", ThisKey="Name", OtherKey="TargetCity")]
		public EntitySet<Flight> FlightsArriveHere
		{
			get
			{
				return this._FlightsArriveHere;
			}
			set
			{
				this._FlightsArriveHere.Assign(value);
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
		
		private void attach_FlightsFromHere(Flight entity)
		{
			this.SendPropertyChanging();
			entity.ArriveCity = this;
		}
		
		private void detach_FlightsFromHere(Flight entity)
		{
			this.SendPropertyChanging();
			entity.ArriveCity = null;
		}
		
		private void attach_FlightsArriveHere(Flight entity)
		{
			this.SendPropertyChanging();
			entity.DepartureCity = this;
		}
		
		private void detach_FlightsArriveHere(Flight entity)
		{
			this.SendPropertyChanging();
			entity.DepartureCity = null;
		}
	}
}
#pragma warning restore 1591
