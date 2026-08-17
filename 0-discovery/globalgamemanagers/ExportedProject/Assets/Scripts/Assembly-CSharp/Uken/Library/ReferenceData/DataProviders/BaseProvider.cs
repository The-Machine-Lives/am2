using System;
using Il2CppDummyDll;

namespace Uken.Library.ReferenceData.DataProviders
{
	[Token(Token = "0x200047F")]
	public abstract class BaseProvider
	{
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E9DC", Offset = "0x82E9DC")]
		private float _003CProgress_003Ek__BackingField;

		[Token(Token = "0x40014A2")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E9EC", Offset = "0x82E9EC")]
		private string _003Cm_data_003Ek__BackingField;

		[Token(Token = "0x40014A3")]
		[FieldOffset(Offset = "0x20")]
		public BaseDataStore m_activeDataStore;

		[Token(Token = "0x170005D7")]
		public float Progress
		{
			[Token(Token = "0x600211F")]
			[Address(RVA = "0xB34CBC", Offset = "0xB34CBC", VA = "0xB34CBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839464", Offset = "0x839464")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6002120")]
			[Address(RVA = "0xB34CC4", Offset = "0xB34CC4", VA = "0xB34CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839474", Offset = "0x839474")]
			protected set
			{
			}
		}

		[Token(Token = "0x170005D8")]
		public string m_data
		{
			[Token(Token = "0x6002121")]
			[Address(RVA = "0xB340E8", Offset = "0xB340E8", VA = "0xB340E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839484", Offset = "0x839484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002122")]
			[Address(RVA = "0xB34CCC", Offset = "0xB34CCC", VA = "0xB34CCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839494", Offset = "0x839494")]
			protected set
			{
			}
		}

		[Token(Token = "0x6002123")]
		protected abstract bool LoadDataAsync(Action<bool, BaseProvider, bool> onDataLoaded);

		[Token(Token = "0x6002124")]
		protected abstract bool LoadData(Action<bool, BaseProvider, bool> onDataLoaded);

		[Token(Token = "0x6002125")]
		public abstract DataSource GetDataSourceValue();

		[Token(Token = "0x6002126")]
		[Address(RVA = "0xB34CD4", Offset = "0xB34CD4", VA = "0xB34CD4")]
		public StoreMetaData GetStoreMetadata()
		{
			return default(StoreMetaData);
		}

		[Token(Token = "0x6002127")]
		[Address(RVA = "0xB34D08", Offset = "0xB34D08", VA = "0xB34D08", Slot = "7")]
		public virtual bool SupportsAsync()
		{
			return default(bool);
		}

		[Token(Token = "0x6002128")]
		[Address(RVA = "0xB33B48", Offset = "0xB33B48", VA = "0xB33B48")]
		public bool LoadData(Action<bool, BaseProvider, bool> onDataLoaded, bool asyncLoad)
		{
			return default(bool);
		}

		[Token(Token = "0x6002129")]
		[Address(RVA = "0xB34D10", Offset = "0xB34D10", VA = "0xB34D10", Slot = "8")]
		public virtual void ProcessData(string rawData, bool success, bool isPartial, Action<bool, BaseProvider, bool> onDataLoaded)
		{
		}

		[Token(Token = "0x600212A")]
		[Address(RVA = "0xB34E48", Offset = "0xB34E48", VA = "0xB34E48")]
		protected BaseProvider()
		{
		}
	}
}
