/*
===============================================================================
                    EntitySpaces Studio by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2012.1.0930.0
EntitySpaces Driver  : SQL
Date Generated       : 9/23/2012 6:16:28 PM
===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using EntitySpaces.DynamicQuery;

namespace Proxies
{
	[DataContract(Namespace = "http://tempuri.org/", Name = "SuppliersCollection")]	
	[XmlType(TypeName = "SuppliersCollectionProxyStub")]	
	public partial class SuppliersCollectionProxyStub 
	{
		public SuppliersCollectionProxyStub() { }
	
		[DataMember(Name = "Collection", EmitDefaultValue = false)]
		public ObservableCollection<SuppliersProxyStub> Collection = new ObservableCollection<SuppliersProxyStub>();
		
		public bool IsDirty()
		{
			foreach (SuppliersProxyStub obj in Collection)
			{
				if (obj.IsDirty()) return true;
			}

			return false;
		}
	}
	
	[DataContract(Namespace = "http://tempuri.org/", Name = "Suppliers")]
	[XmlType(TypeName = "SuppliersProxyStub")]	
	public partial class SuppliersProxyStub : object, System.ComponentModel.INotifyPropertyChanged
	{
		public SuppliersProxyStub()
		{
			this.esRowState = "Added";
		}
		
		public bool IsDirty()
		{
			return esRowState != "Unchanged" ? true : false;
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected void RaisePropertyChanged(string propertyName) 
		{
			System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if ((propertyChanged != null)) 
			{
				propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[DataMember(Name="a0", Order=1, EmitDefaultValue=false)]
		public System.Int32? SupplierID
		{
			get
			{
				return _SupplierID;
			}
			set
			{
				if (_SupplierID != value)
				{
					_SupplierID = value;
					SetDirty("SupplierID");
					RaisePropertyChanged("SupplierID");
				}
			}
		}
		private System.Int32? _SupplierID;
		
		[DataMember(Name="a1", Order=2, EmitDefaultValue=false)]
		public System.String CompanyName
		{
			get
			{
				return _CompanyName;
			}
			set
			{
				if (_CompanyName != value)
				{
					_CompanyName = value;
					SetDirty("CompanyName");
					RaisePropertyChanged("CompanyName");
				}
			}
		}
		private System.String _CompanyName;
		
		[DataMember(Name="a2", Order=3, EmitDefaultValue=false)]
		public System.String ContactName
		{
			get
			{
				return _ContactName;
			}
			set
			{
				if (_ContactName != value)
				{
					_ContactName = value;
					SetDirty("ContactName");
					RaisePropertyChanged("ContactName");
				}
			}
		}
		private System.String _ContactName;
		
		[DataMember(Name="a3", Order=4, EmitDefaultValue=false)]
		public System.String ContactTitle
		{
			get
			{
				return _ContactTitle;
			}
			set
			{
				if (_ContactTitle != value)
				{
					_ContactTitle = value;
					SetDirty("ContactTitle");
					RaisePropertyChanged("ContactTitle");
				}
			}
		}
		private System.String _ContactTitle;
		
		[DataMember(Name="a4", Order=5, EmitDefaultValue=false)]
		public System.String Address
		{
			get
			{
				return _Address;
			}
			set
			{
				if (_Address != value)
				{
					_Address = value;
					SetDirty("Address");
					RaisePropertyChanged("Address");
				}
			}
		}
		private System.String _Address;
		
		[DataMember(Name="a5", Order=6, EmitDefaultValue=false)]
		public System.String City
		{
			get
			{
				return _City;
			}
			set
			{
				if (_City != value)
				{
					_City = value;
					SetDirty("City");
					RaisePropertyChanged("City");
				}
			}
		}
		private System.String _City;
		
		[DataMember(Name="a6", Order=7, EmitDefaultValue=false)]
		public System.String Region
		{
			get
			{
				return _Region;
			}
			set
			{
				if (_Region != value)
				{
					_Region = value;
					SetDirty("Region");
					RaisePropertyChanged("Region");
				}
			}
		}
		private System.String _Region;
		
		[DataMember(Name="a7", Order=8, EmitDefaultValue=false)]
		public System.String PostalCode
		{
			get
			{
				return _PostalCode;
			}
			set
			{
				if (_PostalCode != value)
				{
					_PostalCode = value;
					SetDirty("PostalCode");
					RaisePropertyChanged("PostalCode");
				}
			}
		}
		private System.String _PostalCode;
		
		[DataMember(Name="a8", Order=9, EmitDefaultValue=false)]
		public System.String Country
		{
			get
			{
				return _Country;
			}
			set
			{
				if (_Country != value)
				{
					_Country = value;
					SetDirty("Country");
					RaisePropertyChanged("Country");
				}
			}
		}
		private System.String _Country;
		
		[DataMember(Name="a9", Order=10, EmitDefaultValue=false)]
		public System.String Phone
		{
			get
			{
				return _Phone;
			}
			set
			{
				if (_Phone != value)
				{
					_Phone = value;
					SetDirty("Phone");
					RaisePropertyChanged("Phone");
				}
			}
		}
		private System.String _Phone;
		
		[DataMember(Name="a10", Order=11, EmitDefaultValue=false)]
		public System.String Fax
		{
			get
			{
				return _Fax;
			}
			set
			{
				if (_Fax != value)
				{
					_Fax = value;
					SetDirty("Fax");
					RaisePropertyChanged("Fax");
				}
			}
		}
		private System.String _Fax;
		
		[DataMember(Name="a11", Order=12, EmitDefaultValue=false)]
		public System.String HomePage
		{
			get
			{
				return _HomePage;
			}
			set
			{
				if (_HomePage != value)
				{
					_HomePage = value;
					SetDirty("HomePage");
					RaisePropertyChanged("HomePage");
				}
			}
		}
		private System.String _HomePage;
		
	
		[DataMember(Name="a10000", Order=10000)]
		public string esRowState
		{
			get { return _esRowState; }
			set 
			{
				if(_esRowState != value)
				{
					_esRowState = value; 
					RaisePropertyChanged("esRowState");
				}
			}
		}
		private string _esRowState = "Unchanged";
		
		[DataMember(Name="a10001", Order=10001, EmitDefaultValue=false)]
		public List<string> ModifiedColumns
		{
			get
			{
				if (_ModifiedColumns == null)
				{
					_ModifiedColumns = new List<string>();
				}
				return _ModifiedColumns;
			}
			set
			{
				_ModifiedColumns = new List<string>(value);
			}
		}
		List<string> _ModifiedColumns;
		
		[DataMember(Name="a10002", Order=10002, EmitDefaultValue=false)]		
		public Dictionary<string, object> esExtraColumns
		{
			get
			{
				if (_ExtraColumns == null)
				{
					_ExtraColumns = new Dictionary<string, object>();
				}
				return _ExtraColumns;
			}
			set
			{
				_ExtraColumns = new Dictionary<string, object>(value);
			}
		}
		Dictionary<string, object> _ExtraColumns;

		public void MarkAsDeleted()
		{
			this.esRowState = "Deleted";
		}

		private void SetDirty(string property)
		{
			if (!ModifiedColumns.Contains(property))
			{
				ModifiedColumns.Add(property);
			}

			if (this.esRowState == "Unchanged")
			{
				this.esRowState = "Modified";
			}
		}
	}
	
	[XmlType(TypeName = "SuppliersQueryProxyStub")]	
	[DataContract(Name = "SuppliersQuery", Namespace = "http://www.entityspaces.net")]
	public partial class SuppliersQueryProxyStub : esDynamicQuerySerializable
	{
		public SuppliersQueryProxyStub() { }
		
		public SuppliersQueryProxyStub(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
		override protected string GetQueryName()
		{
			return "SuppliersQuery";
		}
		
		#region Implicit Casts

		public static implicit operator string(SuppliersQueryProxyStub query)
		{
			return Proxies.SuppliersQueryProxyStub.SerializeHelper.ToXml(query);
		}

		#endregion
	
		public esQueryItem SupplierID
		{
			get { return new esQueryItem(this, "SupplierID", esSystemType.Int32); }
		} 
		
		public esQueryItem CompanyName
		{
			get { return new esQueryItem(this, "CompanyName", esSystemType.String); }
		} 
		
		public esQueryItem ContactName
		{
			get { return new esQueryItem(this, "ContactName", esSystemType.String); }
		} 
		
		public esQueryItem ContactTitle
		{
			get { return new esQueryItem(this, "ContactTitle", esSystemType.String); }
		} 
		
		public esQueryItem Address
		{
			get { return new esQueryItem(this, "Address", esSystemType.String); }
		} 
		
		public esQueryItem City
		{
			get { return new esQueryItem(this, "City", esSystemType.String); }
		} 
		
		public esQueryItem Region
		{
			get { return new esQueryItem(this, "Region", esSystemType.String); }
		} 
		
		public esQueryItem PostalCode
		{
			get { return new esQueryItem(this, "PostalCode", esSystemType.String); }
		} 
		
		public esQueryItem Country
		{
			get { return new esQueryItem(this, "Country", esSystemType.String); }
		} 
		
		public esQueryItem Phone
		{
			get { return new esQueryItem(this, "Phone", esSystemType.String); }
		} 
		
		public esQueryItem Fax
		{
			get { return new esQueryItem(this, "Fax", esSystemType.String); }
		} 
		
		public esQueryItem HomePage
		{
			get { return new esQueryItem(this, "HomePage", esSystemType.String); }
		} 
		
	}
}