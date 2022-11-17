using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046A")]
	public abstract class StoreModel
	{
		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E738", Offset = "0x82E738")]
		private DataStoreController _003Cm_parentController_003Ek__BackingField;

		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, IBaseDepotEntity> registeredDepots;

		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> classToDepotName;

		[Token(Token = "0x4001473")]
		[FieldOffset(Offset = "0x28")]
		private List<string> m_overrideDepotQueryNames;

		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E748", Offset = "0x82E748")]
		private List<HashSet<IBaseDepotEntity>> _003CmultiReferenceDepots_003Ek__BackingField;

		[Token(Token = "0x170005CD")]
		public DataStoreController m_parentController
		{
			[Token(Token = "0x60020C8")]
			[Address(RVA = "0xB37DD8", Offset = "0xB37DD8", VA = "0xB37DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839334", Offset = "0x839334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020C9")]
			[Address(RVA = "0xB37DE0", Offset = "0xB37DE0", VA = "0xB37DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839344", Offset = "0x839344")]
			private set
			{
			}
		}

		[Token(Token = "0x170005CE")]
		[JsonIgnore]
		public List<HashSet<IBaseDepotEntity>> multiReferenceDepots
		{
			[Token(Token = "0x60020CA")]
			[Address(RVA = "0xB37DE8", Offset = "0xB37DE8", VA = "0xB37DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839354", Offset = "0x839354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020CB")]
			[Address(RVA = "0xB37DF0", Offset = "0xB37DF0", VA = "0xB37DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839364", Offset = "0x839364")]
			protected set
			{
			}
		}

		[Token(Token = "0x60020CC")]
		[Address(RVA = "0xB37DF8", Offset = "0xB37DF8", VA = "0xB37DF8")]
		public void RegisterController(DataStoreController parentController)
		{
		}

		[Token(Token = "0x60020CD")]
		[Address(RVA = "0xB37E00", Offset = "0xB37E00", VA = "0xB37E00")]
		public string GetDepotClassName(string depotName)
		{
			return null;
		}

		[Token(Token = "0x60020CE")]
		[Address(RVA = "0xB37F84", Offset = "0xB37F84", VA = "0xB37F84")]
		public string GetDepotName(IBaseDepotEntity depotEntity)
		{
			return null;
		}

		[Token(Token = "0x60020CF")]
		[Address(RVA = "0xB3811C", Offset = "0xB3811C", VA = "0xB3811C")]
		public void SetOverrideQueryDepots(List<string> depots)
		{
		}

		[Token(Token = "0x60020D0")]
		[Address(RVA = "0xB38194", Offset = "0xB38194", VA = "0xB38194")]
		public bool AreOverrideDepotsSet()
		{
			return default(bool);
		}

		[Token(Token = "0x60020D1")]
		[Address(RVA = "0xB381F4", Offset = "0xB381F4", VA = "0xB381F4")]
		public VersionPlatform GetPlatform()
		{
			return default(VersionPlatform);
		}

		[Token(Token = "0x60020D2")]
		[Address(RVA = "0xB38220", Offset = "0xB38220", VA = "0xB38220")]
		public Version GetVersion()
		{
			return null;
		}

		[Token(Token = "0x60020D3")]
		[Address(RVA = "0xB3824C", Offset = "0xB3824C", VA = "0xB3824C")]
		public List<string> GetMetadata()
		{
			return null;
		}

		[Token(Token = "0x60020D4")]
		public abstract bool OnDataStoreUpdated(StoreModel newDataStore, DataSource dataSource);

		[Token(Token = "0x60020D5")]
		protected void RegisterDepot<T>(string depotName, DepotEntity<T> depotReference, DataSource dataSource) where T : BaseEntityDocument
		{
		}

		[Token(Token = "0x60020D6")]
		[Address(RVA = "0xB3836C", Offset = "0xB3836C", VA = "0xB3836C")]
		public string GetDepotNameByClass(string className)
		{
			return null;
		}

		[Token(Token = "0x60020D7")]
		[Address(RVA = "0xB38414", Offset = "0xB38414", VA = "0xB38414")]
		public IBaseDepotEntity GetDepotByClass(string className)
		{
			return null;
		}

		[Token(Token = "0x60020D8")]
		[Address(RVA = "0xB3851C", Offset = "0xB3851C", VA = "0xB3851C")]
		protected StoreModel()
		{
		}
	}
}
