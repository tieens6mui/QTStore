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

namespace QTStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QTStore")]
	public partial class dbQTStoreDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAdmin(Admin instance);
    partial void UpdateAdmin(Admin instance);
    partial void DeleteAdmin(Admin instance);
    partial void InsertSANPHAM(SANPHAM instance);
    partial void UpdateSANPHAM(SANPHAM instance);
    partial void DeleteSANPHAM(SANPHAM instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertKHUYEMMAI(KHUYEMMAI instance);
    partial void UpdateKHUYEMMAI(KHUYEMMAI instance);
    partial void DeleteKHUYEMMAI(KHUYEMMAI instance);
    partial void InsertLOAISP(LOAISP instance);
    partial void UpdateLOAISP(LOAISP instance);
    partial void DeleteLOAISP(LOAISP instance);
    partial void InsertNHASANXUAT(NHASANXUAT instance);
    partial void UpdateNHASANXUAT(NHASANXUAT instance);
    partial void DeleteNHASANXUAT(NHASANXUAT instance);
    #endregion
		
		public dbQTStoreDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QTStoreConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbQTStoreDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQTStoreDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQTStoreDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbQTStoreDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Admin> Admins
		{
			get
			{
				return this.GetTable<Admin>();
			}
		}
		
		public System.Data.Linq.Table<SANPHAM> SANPHAMs
		{
			get
			{
				return this.GetTable<SANPHAM>();
			}
		}
		
		public System.Data.Linq.Table<CHITIETDONHANG> CHITIETDONHANGs
		{
			get
			{
				return this.GetTable<CHITIETDONHANG>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHUYEMMAI> KHUYEMMAIs
		{
			get
			{
				return this.GetTable<KHUYEMMAI>();
			}
		}
		
		public System.Data.Linq.Table<LOAISP> LOAISPs
		{
			get
			{
				return this.GetTable<LOAISP>();
			}
		}
		
		public System.Data.Linq.Table<NHASANXUAT> NHASANXUATs
		{
			get
			{
				return this.GetTable<NHASANXUAT>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
	public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserAdmin;
		
		private string _PassAdmin;
		
		private string _Hoten;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserAdminChanging(string value);
    partial void OnUserAdminChanged();
    partial void OnPassAdminChanging(string value);
    partial void OnPassAdminChanged();
    partial void OnHotenChanging(string value);
    partial void OnHotenChanged();
    #endregion
		
		public Admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAdmin", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserAdmin
		{
			get
			{
				return this._UserAdmin;
			}
			set
			{
				if ((this._UserAdmin != value))
				{
					this.OnUserAdminChanging(value);
					this.SendPropertyChanging();
					this._UserAdmin = value;
					this.SendPropertyChanged("UserAdmin");
					this.OnUserAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassAdmin", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PassAdmin
		{
			get
			{
				return this._PassAdmin;
			}
			set
			{
				if ((this._PassAdmin != value))
				{
					this.OnPassAdminChanging(value);
					this.SendPropertyChanging();
					this._PassAdmin = value;
					this.SendPropertyChanged("PassAdmin");
					this.OnPassAdminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hoten", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Hoten
		{
			get
			{
				return this._Hoten;
			}
			set
			{
				if ((this._Hoten != value))
				{
					this.OnHotenChanging(value);
					this.SendPropertyChanging();
					this._Hoten = value;
					this.SendPropertyChanged("Hoten");
					this.OnHotenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SANPHAM")]
	public partial class SANPHAM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<decimal> _Giaban;
		
		private string _Mota;
		
		private string _Anhbia;
		
		private System.Nullable<System.DateTime> _Ngaycapnhat;
		
		private System.Nullable<int> _Soluongton;
		
		private System.Nullable<int> _MaLSP;
		
		private System.Nullable<int> _MaNSX;
		
		private System.Nullable<int> _MaKM;
		
		private EntityRef<KHUYEMMAI> _KHUYEMMAI;
		
		private EntityRef<LOAISP> _LOAISP;
		
		private EntityRef<NHASANXUAT> _NHASANXUAT;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiabanChanging(System.Nullable<decimal> value);
    partial void OnGiabanChanged();
    partial void OnMotaChanging(string value);
    partial void OnMotaChanged();
    partial void OnAnhbiaChanging(string value);
    partial void OnAnhbiaChanged();
    partial void OnNgaycapnhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaycapnhatChanged();
    partial void OnSoluongtonChanging(System.Nullable<int> value);
    partial void OnSoluongtonChanged();
    partial void OnMaLSPChanging(System.Nullable<int> value);
    partial void OnMaLSPChanged();
    partial void OnMaNSXChanging(System.Nullable<int> value);
    partial void OnMaNSXChanged();
    partial void OnMaKMChanging(System.Nullable<int> value);
    partial void OnMaKMChanged();
    #endregion
		
		public SANPHAM()
		{
			this._KHUYEMMAI = default(EntityRef<KHUYEMMAI>);
			this._LOAISP = default(EntityRef<LOAISP>);
			this._NHASANXUAT = default(EntityRef<NHASANXUAT>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Giaban", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Giaban
		{
			get
			{
				return this._Giaban;
			}
			set
			{
				if ((this._Giaban != value))
				{
					this.OnGiabanChanging(value);
					this.SendPropertyChanging();
					this._Giaban = value;
					this.SendPropertyChanged("Giaban");
					this.OnGiabanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mota", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Mota
		{
			get
			{
				return this._Mota;
			}
			set
			{
				if ((this._Mota != value))
				{
					this.OnMotaChanging(value);
					this.SendPropertyChanging();
					this._Mota = value;
					this.SendPropertyChanged("Mota");
					this.OnMotaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anhbia", DbType="VarChar(50)")]
		public string Anhbia
		{
			get
			{
				return this._Anhbia;
			}
			set
			{
				if ((this._Anhbia != value))
				{
					this.OnAnhbiaChanging(value);
					this.SendPropertyChanging();
					this._Anhbia = value;
					this.SendPropertyChanged("Anhbia");
					this.OnAnhbiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaycapnhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaycapnhat
		{
			get
			{
				return this._Ngaycapnhat;
			}
			set
			{
				if ((this._Ngaycapnhat != value))
				{
					this.OnNgaycapnhatChanging(value);
					this.SendPropertyChanging();
					this._Ngaycapnhat = value;
					this.SendPropertyChanged("Ngaycapnhat");
					this.OnNgaycapnhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluongton", DbType="Int")]
		public System.Nullable<int> Soluongton
		{
			get
			{
				return this._Soluongton;
			}
			set
			{
				if ((this._Soluongton != value))
				{
					this.OnSoluongtonChanging(value);
					this.SendPropertyChanging();
					this._Soluongton = value;
					this.SendPropertyChanged("Soluongton");
					this.OnSoluongtonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLSP", DbType="Int")]
		public System.Nullable<int> MaLSP
		{
			get
			{
				return this._MaLSP;
			}
			set
			{
				if ((this._MaLSP != value))
				{
					if (this._LOAISP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLSPChanging(value);
					this.SendPropertyChanging();
					this._MaLSP = value;
					this.SendPropertyChanged("MaLSP");
					this.OnMaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSX", DbType="Int")]
		public System.Nullable<int> MaNSX
		{
			get
			{
				return this._MaNSX;
			}
			set
			{
				if ((this._MaNSX != value))
				{
					if (this._NHASANXUAT.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNSXChanging(value);
					this.SendPropertyChanging();
					this._MaNSX = value;
					this.SendPropertyChanged("MaNSX");
					this.OnMaNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKM", DbType="Int")]
		public System.Nullable<int> MaKM
		{
			get
			{
				return this._MaKM;
			}
			set
			{
				if ((this._MaKM != value))
				{
					if (this._KHUYEMMAI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKMChanging(value);
					this.SendPropertyChanging();
					this._MaKM = value;
					this.SendPropertyChanged("MaKM");
					this.OnMaKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUYEMMAI_SANPHAM", Storage="_KHUYEMMAI", ThisKey="MaKM", OtherKey="MaKM", IsForeignKey=true)]
		public KHUYEMMAI KHUYEMMAI
		{
			get
			{
				return this._KHUYEMMAI.Entity;
			}
			set
			{
				KHUYEMMAI previousValue = this._KHUYEMMAI.Entity;
				if (((previousValue != value) 
							|| (this._KHUYEMMAI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHUYEMMAI.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._KHUYEMMAI.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaKM = value.MaKM;
					}
					else
					{
						this._MaKM = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHUYEMMAI");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_LOAISP", ThisKey="MaLSP", OtherKey="MaLSP", IsForeignKey=true)]
		public LOAISP LOAISP
		{
			get
			{
				return this._LOAISP.Entity;
			}
			set
			{
				LOAISP previousValue = this._LOAISP.Entity;
				if (((previousValue != value) 
							|| (this._LOAISP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAISP.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._LOAISP.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaLSP = value.MaLSP;
					}
					else
					{
						this._MaLSP = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAISP");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHASANXUAT_SANPHAM", Storage="_NHASANXUAT", ThisKey="MaNSX", OtherKey="MaNSX", IsForeignKey=true)]
		public NHASANXUAT NHASANXUAT
		{
			get
			{
				return this._NHASANXUAT.Entity;
			}
			set
			{
				NHASANXUAT previousValue = this._NHASANXUAT.Entity;
				if (((previousValue != value) 
							|| (this._NHASANXUAT.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHASANXUAT.Entity = null;
						previousValue.SANPHAMs.Remove(this);
					}
					this._NHASANXUAT.Entity = value;
					if ((value != null))
					{
						value.SANPHAMs.Add(this);
						this._MaNSX = value.MaNSX;
					}
					else
					{
						this._MaNSX = default(Nullable<int>);
					}
					this.SendPropertyChanged("NHASANXUAT");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CHITIETDONHANG")]
	public partial class CHITIETDONHANG
	{
		
		private System.Nullable<int> _MaDonHang;
		
		private System.Nullable<int> _MaSP;
		
		private System.Nullable<int> _Soluong;
		
		private System.Nullable<decimal> _Dongia;
		
		public CHITIETDONHANG()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", DbType="Int")]
		public System.Nullable<int> MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this._MaDonHang = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", DbType="Int")]
		public System.Nullable<int> MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this._MaSP = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Soluong", DbType="Int")]
		public System.Nullable<int> Soluong
		{
			get
			{
				return this._Soluong;
			}
			set
			{
				if ((this._Soluong != value))
				{
					this._Soluong = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Dongia
		{
			get
			{
				return this._Dongia;
			}
			set
			{
				if ((this._Dongia != value))
				{
					this._Dongia = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDonHang;
		
		private System.Nullable<bool> _Datthanhtoan;
		
		private System.Nullable<bool> _Tinhtranggiaohang;
		
		private System.Nullable<System.DateTime> _Ngaydat;
		
		private System.Nullable<System.DateTime> _Ngaygiao;
		
		private int _MaKH;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDonHangChanging(int value);
    partial void OnMaDonHangChanged();
    partial void OnDatthanhtoanChanging(System.Nullable<bool> value);
    partial void OnDatthanhtoanChanged();
    partial void OnTinhtranggiaohangChanging(System.Nullable<bool> value);
    partial void OnTinhtranggiaohangChanged();
    partial void OnNgaydatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaydatChanged();
    partial void OnNgaygiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaygiaoChanged();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDonHang", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDonHang
		{
			get
			{
				return this._MaDonHang;
			}
			set
			{
				if ((this._MaDonHang != value))
				{
					this.OnMaDonHangChanging(value);
					this.SendPropertyChanging();
					this._MaDonHang = value;
					this.SendPropertyChanged("MaDonHang");
					this.OnMaDonHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Datthanhtoan", DbType="Bit")]
		public System.Nullable<bool> Datthanhtoan
		{
			get
			{
				return this._Datthanhtoan;
			}
			set
			{
				if ((this._Datthanhtoan != value))
				{
					this.OnDatthanhtoanChanging(value);
					this.SendPropertyChanging();
					this._Datthanhtoan = value;
					this.SendPropertyChanged("Datthanhtoan");
					this.OnDatthanhtoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tinhtranggiaohang", DbType="Bit")]
		public System.Nullable<bool> Tinhtranggiaohang
		{
			get
			{
				return this._Tinhtranggiaohang;
			}
			set
			{
				if ((this._Tinhtranggiaohang != value))
				{
					this.OnTinhtranggiaohangChanging(value);
					this.SendPropertyChanging();
					this._Tinhtranggiaohang = value;
					this.SendPropertyChanged("Tinhtranggiaohang");
					this.OnTinhtranggiaohangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaydat", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaydat
		{
			get
			{
				return this._Ngaydat;
			}
			set
			{
				if ((this._Ngaydat != value))
				{
					this.OnNgaydatChanging(value);
					this.SendPropertyChanging();
					this._Ngaydat = value;
					this.SendPropertyChanged("Ngaydat");
					this.OnNgaydatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaygiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaygiao
		{
			get
			{
				return this._Ngaygiao;
			}
			set
			{
				if ((this._Ngaygiao != value))
				{
					this.OnNgaygiaoChanging(value);
					this.SendPropertyChanging();
					this._Ngaygiao = value;
					this.SendPropertyChanged("Ngaygiao");
					this.OnNgaygiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int NOT NULL")]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(int);
					}
					this.SendPropertyChanged("KHACHHANG");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _Taikhoan;
		
		private string _Matkhau;
		
		private string _Email;
		
		private string _DiachiKH;
		
		private string _DienthoaiKH;
		
		private System.Nullable<System.DateTime> _Ngaysinh;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaikhoanChanging(string value);
    partial void OnTaikhoanChanged();
    partial void OnMatkhauChanging(string value);
    partial void OnMatkhauChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiachiKHChanging(string value);
    partial void OnDiachiKHChanged();
    partial void OnDienthoaiKHChanging(string value);
    partial void OnDienthoaiKHChanged();
    partial void OnNgaysinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaysinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taikhoan", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Taikhoan
		{
			get
			{
				return this._Taikhoan;
			}
			set
			{
				if ((this._Taikhoan != value))
				{
					this.OnTaikhoanChanging(value);
					this.SendPropertyChanging();
					this._Taikhoan = value;
					this.SendPropertyChanged("Taikhoan");
					this.OnTaikhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matkhau", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Matkhau
		{
			get
			{
				return this._Matkhau;
			}
			set
			{
				if ((this._Matkhau != value))
				{
					this.OnMatkhauChanging(value);
					this.SendPropertyChanging();
					this._Matkhau = value;
					this.SendPropertyChanged("Matkhau");
					this.OnMatkhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiachiKH", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string DiachiKH
		{
			get
			{
				return this._DiachiKH;
			}
			set
			{
				if ((this._DiachiKH != value))
				{
					this.OnDiachiKHChanging(value);
					this.SendPropertyChanging();
					this._DiachiKH = value;
					this.SendPropertyChanged("DiachiKH");
					this.OnDiachiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienthoaiKH", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string DienthoaiKH
		{
			get
			{
				return this._DienthoaiKH;
			}
			set
			{
				if ((this._DienthoaiKH != value))
				{
					this.OnDienthoaiKHChanging(value);
					this.SendPropertyChanging();
					this._DienthoaiKH = value;
					this.SendPropertyChanged("DienthoaiKH");
					this.OnDienthoaiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ngaysinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> Ngaysinh
		{
			get
			{
				return this._Ngaysinh;
			}
			set
			{
				if ((this._Ngaysinh != value))
				{
					this.OnNgaysinhChanging(value);
					this.SendPropertyChanging();
					this._Ngaysinh = value;
					this.SendPropertyChanged("Ngaysinh");
					this.OnNgaysinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHUYEMMAI")]
	public partial class KHUYEMMAI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKM;
		
		private string _TenKM;
		
		private string _Ghichu;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKMChanging(int value);
    partial void OnMaKMChanged();
    partial void OnTenKMChanging(string value);
    partial void OnTenKMChanged();
    partial void OnGhichuChanging(string value);
    partial void OnGhichuChanged();
    #endregion
		
		public KHUYEMMAI()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKM", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKM
		{
			get
			{
				return this._MaKM;
			}
			set
			{
				if ((this._MaKM != value))
				{
					this.OnMaKMChanging(value);
					this.SendPropertyChanging();
					this._MaKM = value;
					this.SendPropertyChanged("MaKM");
					this.OnMaKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKM", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKM
		{
			get
			{
				return this._TenKM;
			}
			set
			{
				if ((this._TenKM != value))
				{
					this.OnTenKMChanging(value);
					this.SendPropertyChanging();
					this._TenKM = value;
					this.SendPropertyChanged("TenKM");
					this.OnTenKMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ghichu", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Ghichu
		{
			get
			{
				return this._Ghichu;
			}
			set
			{
				if ((this._Ghichu != value))
				{
					this.OnGhichuChanging(value);
					this.SendPropertyChanging();
					this._Ghichu = value;
					this.SendPropertyChanged("Ghichu");
					this.OnGhichuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHUYEMMAI_SANPHAM", Storage="_SANPHAMs", ThisKey="MaKM", OtherKey="MaKM")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.KHUYEMMAI = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.KHUYEMMAI = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAISP")]
	public partial class LOAISP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLSP;
		
		private string _TenLSP;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLSPChanging(int value);
    partial void OnMaLSPChanged();
    partial void OnTenLSPChanging(string value);
    partial void OnTenLSPChanged();
    #endregion
		
		public LOAISP()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLSP
		{
			get
			{
				return this._MaLSP;
			}
			set
			{
				if ((this._MaLSP != value))
				{
					this.OnMaLSPChanging(value);
					this.SendPropertyChanging();
					this._MaLSP = value;
					this.SendPropertyChanged("MaLSP");
					this.OnMaLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLSP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenLSP
		{
			get
			{
				return this._TenLSP;
			}
			set
			{
				if ((this._TenLSP != value))
				{
					this.OnTenLSPChanging(value);
					this.SendPropertyChanging();
					this._TenLSP = value;
					this.SendPropertyChanged("TenLSP");
					this.OnTenLSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAISP_SANPHAM", Storage="_SANPHAMs", ThisKey="MaLSP", OtherKey="MaLSP")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.LOAISP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHASANXUAT")]
	public partial class NHASANXUAT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNSX;
		
		private string _TenNSX;
		
		private string _Diachi;
		
		private string _Dienthoai;
		
		private EntitySet<SANPHAM> _SANPHAMs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNSXChanging(int value);
    partial void OnMaNSXChanged();
    partial void OnTenNSXChanging(string value);
    partial void OnTenNSXChanged();
    partial void OnDiachiChanging(string value);
    partial void OnDiachiChanged();
    partial void OnDienthoaiChanging(string value);
    partial void OnDienthoaiChanged();
    #endregion
		
		public NHASANXUAT()
		{
			this._SANPHAMs = new EntitySet<SANPHAM>(new Action<SANPHAM>(this.attach_SANPHAMs), new Action<SANPHAM>(this.detach_SANPHAMs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNSX", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNSX
		{
			get
			{
				return this._MaNSX;
			}
			set
			{
				if ((this._MaNSX != value))
				{
					this.OnMaNSXChanging(value);
					this.SendPropertyChanging();
					this._MaNSX = value;
					this.SendPropertyChanged("MaNSX");
					this.OnMaNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNSX", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNSX
		{
			get
			{
				return this._TenNSX;
			}
			set
			{
				if ((this._TenNSX != value))
				{
					this.OnTenNSXChanging(value);
					this.SendPropertyChanging();
					this._TenNSX = value;
					this.SendPropertyChanged("TenNSX");
					this.OnTenNSXChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Diachi", DbType="NVarChar(50)")]
		public string Diachi
		{
			get
			{
				return this._Diachi;
			}
			set
			{
				if ((this._Diachi != value))
				{
					this.OnDiachiChanging(value);
					this.SendPropertyChanging();
					this._Diachi = value;
					this.SendPropertyChanged("Diachi");
					this.OnDiachiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dienthoai", DbType="NVarChar(50)")]
		public string Dienthoai
		{
			get
			{
				return this._Dienthoai;
			}
			set
			{
				if ((this._Dienthoai != value))
				{
					this.OnDienthoaiChanging(value);
					this.SendPropertyChanging();
					this._Dienthoai = value;
					this.SendPropertyChanged("Dienthoai");
					this.OnDienthoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHASANXUAT_SANPHAM", Storage="_SANPHAMs", ThisKey="MaNSX", OtherKey="MaNSX")]
		public EntitySet<SANPHAM> SANPHAMs
		{
			get
			{
				return this._SANPHAMs;
			}
			set
			{
				this._SANPHAMs.Assign(value);
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
		
		private void attach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHASANXUAT = this;
		}
		
		private void detach_SANPHAMs(SANPHAM entity)
		{
			this.SendPropertyChanging();
			entity.NHASANXUAT = null;
		}
	}
}
#pragma warning restore 1591
