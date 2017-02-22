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

namespace SiPA
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="20131011110169")]
	public partial class BancoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduto(Produto instance);
    partial void UpdateProduto(Produto instance);
    partial void DeleteProduto(Produto instance);
    partial void InsertCompra(Compra instance);
    partial void UpdateCompra(Compra instance);
    partial void DeleteCompra(Compra instance);
    partial void InsertFornecedor(Fornecedor instance);
    partial void UpdateFornecedor(Fornecedor instance);
    partial void DeleteFornecedor(Fornecedor instance);
    partial void InsertItemCompra(ItemCompra instance);
    partial void UpdateItemCompra(ItemCompra instance);
    partial void DeleteItemCompra(ItemCompra instance);
    #endregion
		
		public BancoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["_20131011110169ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BancoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Produto> Produtos
		{
			get
			{
				return this.GetTable<Produto>();
			}
		}
		
		public System.Data.Linq.Table<Compra> Compras
		{
			get
			{
				return this.GetTable<Compra>();
			}
		}
		
		public System.Data.Linq.Table<Fornecedor> Fornecedors
		{
			get
			{
				return this.GetTable<Fornecedor>();
			}
		}
		
		public System.Data.Linq.Table<ItemCompra> ItemCompras
		{
			get
			{
				return this.GetTable<ItemCompra>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Produto")]
	public partial class Produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _descricao;
		
		private EntitySet<ItemCompra> _ItemCompras;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OndescricaoChanging(string value);
    partial void OndescricaoChanged();
    #endregion
		
		public Produto()
		{
			this._ItemCompras = new EntitySet<ItemCompra>(new Action<ItemCompra>(this.attach_ItemCompras), new Action<ItemCompra>(this.detach_ItemCompras));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descricao", DbType="NChar(10)")]
		public string descricao
		{
			get
			{
				return this._descricao;
			}
			set
			{
				if ((this._descricao != value))
				{
					this.OndescricaoChanging(value);
					this.SendPropertyChanging();
					this._descricao = value;
					this.SendPropertyChanged("descricao");
					this.OndescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_ItemCompra", Storage="_ItemCompras", ThisKey="id", OtherKey="produto_id")]
		public EntitySet<ItemCompra> ItemCompras
		{
			get
			{
				return this._ItemCompras;
			}
			set
			{
				this._ItemCompras.Assign(value);
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
		
		private void attach_ItemCompras(ItemCompra entity)
		{
			this.SendPropertyChanging();
			entity.Produto = this;
		}
		
		private void detach_ItemCompras(ItemCompra entity)
		{
			this.SendPropertyChanging();
			entity.Produto = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Compra")]
	public partial class Compra : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _fornecedor_id;
		
		private System.Nullable<System.DateTime> _dataCompra;
		
		private System.Nullable<double> _desconto;
		
		private System.Nullable<double> _valorTotal;
		
		private EntitySet<ItemCompra> _ItemCompras;
		
		private EntityRef<Fornecedor> _Fornecedor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onfornecedor_idChanging(System.Nullable<int> value);
    partial void Onfornecedor_idChanged();
    partial void OndataCompraChanging(System.Nullable<System.DateTime> value);
    partial void OndataCompraChanged();
    partial void OndescontoChanging(System.Nullable<double> value);
    partial void OndescontoChanged();
    partial void OnvalorTotalChanging(System.Nullable<double> value);
    partial void OnvalorTotalChanged();
    #endregion
		
		public Compra()
		{
			this._ItemCompras = new EntitySet<ItemCompra>(new Action<ItemCompra>(this.attach_ItemCompras), new Action<ItemCompra>(this.detach_ItemCompras));
			this._Fornecedor = default(EntityRef<Fornecedor>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fornecedor_id", DbType="Int")]
		public System.Nullable<int> fornecedor_id
		{
			get
			{
				return this._fornecedor_id;
			}
			set
			{
				if ((this._fornecedor_id != value))
				{
					if (this._Fornecedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onfornecedor_idChanging(value);
					this.SendPropertyChanging();
					this._fornecedor_id = value;
					this.SendPropertyChanged("fornecedor_id");
					this.Onfornecedor_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dataCompra", DbType="Date")]
		public System.Nullable<System.DateTime> dataCompra
		{
			get
			{
				return this._dataCompra;
			}
			set
			{
				if ((this._dataCompra != value))
				{
					this.OndataCompraChanging(value);
					this.SendPropertyChanging();
					this._dataCompra = value;
					this.SendPropertyChanged("dataCompra");
					this.OndataCompraChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_desconto", DbType="Float")]
		public System.Nullable<double> desconto
		{
			get
			{
				return this._desconto;
			}
			set
			{
				if ((this._desconto != value))
				{
					this.OndescontoChanging(value);
					this.SendPropertyChanging();
					this._desconto = value;
					this.SendPropertyChanged("desconto");
					this.OndescontoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valorTotal", DbType="Float")]
		public System.Nullable<double> valorTotal
		{
			get
			{
				return this._valorTotal;
			}
			set
			{
				if ((this._valorTotal != value))
				{
					this.OnvalorTotalChanging(value);
					this.SendPropertyChanging();
					this._valorTotal = value;
					this.SendPropertyChanged("valorTotal");
					this.OnvalorTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Compra_ItemCompra", Storage="_ItemCompras", ThisKey="id", OtherKey="compra_id")]
		internal EntitySet<ItemCompra> ItemCompras
		{
			get
			{
				return this._ItemCompras;
			}
			set
			{
				this._ItemCompras.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fornecedor_Compra", Storage="_Fornecedor", ThisKey="fornecedor_id", OtherKey="id", IsForeignKey=true)]
		public Fornecedor Fornecedor
		{
			get
			{
				return this._Fornecedor.Entity;
			}
			set
			{
				Fornecedor previousValue = this._Fornecedor.Entity;
				if (((previousValue != value) 
							|| (this._Fornecedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Fornecedor.Entity = null;
						previousValue.Compras.Remove(this);
					}
					this._Fornecedor.Entity = value;
					if ((value != null))
					{
						value.Compras.Add(this);
						this._fornecedor_id = value.id;
					}
					else
					{
						this._fornecedor_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Fornecedor");
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
		
		private void attach_ItemCompras(ItemCompra entity)
		{
			this.SendPropertyChanging();
			entity.Compra = this;
		}
		
		private void detach_ItemCompras(ItemCompra entity)
		{
			this.SendPropertyChanging();
			entity.Compra = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Fornecedor")]
	public partial class Fornecedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nome;
		
		private string _telefone;
		
		private string _cidade;
		
		private string _estado;
		
		private string _endereco;
		
		private string _cpf;
		
		private string _cnpj;
		
		private System.Nullable<int> _opCPForCNPJ;
		
		private string _email;
		
		private EntitySet<Compra> _Compras;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnomeChanging(string value);
    partial void OnnomeChanged();
    partial void OntelefoneChanging(string value);
    partial void OntelefoneChanged();
    partial void OncidadeChanging(string value);
    partial void OncidadeChanged();
    partial void OnestadoChanging(string value);
    partial void OnestadoChanged();
    partial void OnenderecoChanging(string value);
    partial void OnenderecoChanged();
    partial void OncpfChanging(string value);
    partial void OncpfChanged();
    partial void OncnpjChanging(string value);
    partial void OncnpjChanged();
    partial void OnopCPForCNPJChanging(System.Nullable<int> value);
    partial void OnopCPForCNPJChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public Fornecedor()
		{
			this._Compras = new EntitySet<Compra>(new Action<Compra>(this.attach_Compras), new Action<Compra>(this.detach_Compras));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nome", DbType="VarChar(MAX)")]
		public string nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				if ((this._nome != value))
				{
					this.OnnomeChanging(value);
					this.SendPropertyChanging();
					this._nome = value;
					this.SendPropertyChanged("nome");
					this.OnnomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefone", DbType="VarChar(MAX)")]
		public string telefone
		{
			get
			{
				return this._telefone;
			}
			set
			{
				if ((this._telefone != value))
				{
					this.OntelefoneChanging(value);
					this.SendPropertyChanging();
					this._telefone = value;
					this.SendPropertyChanged("telefone");
					this.OntelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cidade", DbType="VarChar(MAX)")]
		public string cidade
		{
			get
			{
				return this._cidade;
			}
			set
			{
				if ((this._cidade != value))
				{
					this.OncidadeChanging(value);
					this.SendPropertyChanging();
					this._cidade = value;
					this.SendPropertyChanged("cidade");
					this.OncidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="VarChar(MAX)")]
		public string estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_endereco", DbType="VarChar(MAX)")]
		public string endereco
		{
			get
			{
				return this._endereco;
			}
			set
			{
				if ((this._endereco != value))
				{
					this.OnenderecoChanging(value);
					this.SendPropertyChanging();
					this._endereco = value;
					this.SendPropertyChanged("endereco");
					this.OnenderecoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cpf", DbType="VarChar(MAX)")]
		public string cpf
		{
			get
			{
				return this._cpf;
			}
			set
			{
				if ((this._cpf != value))
				{
					this.OncpfChanging(value);
					this.SendPropertyChanging();
					this._cpf = value;
					this.SendPropertyChanged("cpf");
					this.OncpfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cnpj", DbType="VarChar(MAX)")]
		public string cnpj
		{
			get
			{
				return this._cnpj;
			}
			set
			{
				if ((this._cnpj != value))
				{
					this.OncnpjChanging(value);
					this.SendPropertyChanging();
					this._cnpj = value;
					this.SendPropertyChanged("cnpj");
					this.OncnpjChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_opCPForCNPJ", DbType="Int")]
		public System.Nullable<int> opCPForCNPJ
		{
			get
			{
				return this._opCPForCNPJ;
			}
			set
			{
				if ((this._opCPForCNPJ != value))
				{
					this.OnopCPForCNPJChanging(value);
					this.SendPropertyChanging();
					this._opCPForCNPJ = value;
					this.SendPropertyChanged("opCPForCNPJ");
					this.OnopCPForCNPJChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(MAX)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Fornecedor_Compra", Storage="_Compras", ThisKey="id", OtherKey="fornecedor_id")]
		public EntitySet<Compra> Compras
		{
			get
			{
				return this._Compras;
			}
			set
			{
				this._Compras.Assign(value);
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
		
		private void attach_Compras(Compra entity)
		{
			this.SendPropertyChanging();
			entity.Fornecedor = this;
		}
		
		private void detach_Compras(Compra entity)
		{
			this.SendPropertyChanging();
			entity.Fornecedor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ItemCompra")]
	public partial class ItemCompra : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private System.Nullable<int> _produto_id;
		
		private System.Nullable<int> _compra_id;
		
		private string _unidade;
		
		private System.Nullable<double> _quantidade;
		
		private System.Nullable<double> _precoUnitario;
		
		private System.Nullable<double> _valorTotal;
		
		private EntityRef<Compra> _Compra;
		
		private EntityRef<Produto> _Produto;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onproduto_idChanging(System.Nullable<int> value);
    partial void Onproduto_idChanged();
    partial void Oncompra_idChanging(System.Nullable<int> value);
    partial void Oncompra_idChanged();
    partial void OnunidadeChanging(string value);
    partial void OnunidadeChanged();
    partial void OnquantidadeChanging(System.Nullable<double> value);
    partial void OnquantidadeChanged();
    partial void OnprecoUnitarioChanging(System.Nullable<double> value);
    partial void OnprecoUnitarioChanged();
    partial void OnvalorTotalChanging(System.Nullable<double> value);
    partial void OnvalorTotalChanged();
    #endregion
		
		public ItemCompra()
		{
			this._Compra = default(EntityRef<Compra>);
			this._Produto = default(EntityRef<Produto>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_produto_id", DbType="Int")]
		public System.Nullable<int> produto_id
		{
			get
			{
				return this._produto_id;
			}
			set
			{
				if ((this._produto_id != value))
				{
					if (this._Produto.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onproduto_idChanging(value);
					this.SendPropertyChanging();
					this._produto_id = value;
					this.SendPropertyChanged("produto_id");
					this.Onproduto_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_compra_id", DbType="Int")]
		public System.Nullable<int> compra_id
		{
			get
			{
				return this._compra_id;
			}
			set
			{
				if ((this._compra_id != value))
				{
					if (this._Compra.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncompra_idChanging(value);
					this.SendPropertyChanging();
					this._compra_id = value;
					this.SendPropertyChanged("compra_id");
					this.Oncompra_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_unidade", DbType="VarChar(MAX)")]
		public string unidade
		{
			get
			{
				return this._unidade;
			}
			set
			{
				if ((this._unidade != value))
				{
					this.OnunidadeChanging(value);
					this.SendPropertyChanging();
					this._unidade = value;
					this.SendPropertyChanged("unidade");
					this.OnunidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantidade", DbType="Float")]
		public System.Nullable<double> quantidade
		{
			get
			{
				return this._quantidade;
			}
			set
			{
				if ((this._quantidade != value))
				{
					this.OnquantidadeChanging(value);
					this.SendPropertyChanging();
					this._quantidade = value;
					this.SendPropertyChanged("quantidade");
					this.OnquantidadeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precoUnitario", DbType="Float")]
		public System.Nullable<double> precoUnitario
		{
			get
			{
				return this._precoUnitario;
			}
			set
			{
				if ((this._precoUnitario != value))
				{
					this.OnprecoUnitarioChanging(value);
					this.SendPropertyChanging();
					this._precoUnitario = value;
					this.SendPropertyChanged("precoUnitario");
					this.OnprecoUnitarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valorTotal", DbType="Float")]
		public System.Nullable<double> valorTotal
		{
			get
			{
				return this._valorTotal;
			}
			set
			{
				if ((this._valorTotal != value))
				{
					this.OnvalorTotalChanging(value);
					this.SendPropertyChanging();
					this._valorTotal = value;
					this.SendPropertyChanged("valorTotal");
					this.OnvalorTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Compra_ItemCompra", Storage="_Compra", ThisKey="compra_id", OtherKey="id", IsForeignKey=true)]
		internal Compra Compra
		{
			get
			{
				return this._Compra.Entity;
			}
			set
			{
				Compra previousValue = this._Compra.Entity;
				if (((previousValue != value) 
							|| (this._Compra.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Compra.Entity = null;
						previousValue.ItemCompras.Remove(this);
					}
					this._Compra.Entity = value;
					if ((value != null))
					{
						value.ItemCompras.Add(this);
						this._compra_id = value.id;
					}
					else
					{
						this._compra_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Compra");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Produto_ItemCompra", Storage="_Produto", ThisKey="produto_id", OtherKey="id", IsForeignKey=true)]
		public Produto Produto
		{
			get
			{
				return this._Produto.Entity;
			}
			set
			{
				Produto previousValue = this._Produto.Entity;
				if (((previousValue != value) 
							|| (this._Produto.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Produto.Entity = null;
						previousValue.ItemCompras.Remove(this);
					}
					this._Produto.Entity = value;
					if ((value != null))
					{
						value.ItemCompras.Add(this);
						this._produto_id = value.id;
					}
					else
					{
						this._produto_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Produto");
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
