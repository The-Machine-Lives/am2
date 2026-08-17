using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x2000462")]
	public class DepotEntity<T> : IBaseDepotEntity where T : BaseEntityDocument
	{
		[Token(Token = "0x4001459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x82E698", Offset = "0x82E698")]
		protected BaseEntity<T>[] entities;

		[Token(Token = "0x400145A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StoreModel m_parentModel;

		[Token(Token = "0x400145B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private string m_requiredReferencePrefix;

		[Token(Token = "0x400145C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E6A8", Offset = "0x82E6A8")]
		private readonly bool _003CcountsTowardsInventoryLimits_003Ek__BackingField;

		[Token(Token = "0x400145D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E6B8", Offset = "0x82E6B8")]
		private DataSource _003Cm_dataSource_003Ek__BackingField;

		[Token(Token = "0x170005C9")]
		[JsonIgnore]
		public string ClassName
		{
			[Token(Token = "0x60020AF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005CA")]
		[JsonIgnore]
		public bool countsTowardsInventoryLimits
		{
			[Token(Token = "0x60020B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839304", Offset = "0x839304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170005CB")]
		[JsonIgnore]
		public DataSource m_dataSource
		{
			[Token(Token = "0x60020B1")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839314", Offset = "0x839314")]
			get
			{
				return default(DataSource);
			}
			[Token(Token = "0x60020B2")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839324", Offset = "0x839324")]
			protected set
			{
			}
		}

		[Token(Token = "0x60020B3")]
		public DepotEntity(StoreModel parentModel)
		{
		}

		[Token(Token = "0x60020B4")]
		public DepotEntity(StoreModel parentModel, bool inCountsTowardsInventoryLimits, [Optional] string requiredReferencePrefix)
		{
		}

		[Token(Token = "0x60020B5")]
		public void SetDataSource(DataSource dataSource)
		{
		}

		[Token(Token = "0x60020B6")]
		public List<T> GetDocuments()
		{
			return null;
		}

		[Token(Token = "0x60020B7")]
		public virtual void PostProcessData()
		{
		}

		[Token(Token = "0x60020B8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60020B9")]
		public void SetDocuments(List<T> newDocuments)
		{
		}

		[Token(Token = "0x60020BA")]
		public T Get(string reference)
		{
			return null;
		}

		[Token(Token = "0x60020BB")]
		public BaseEntityDocument GetBaseEntityDocument(string reference)
		{
			return null;
		}
	}
}
