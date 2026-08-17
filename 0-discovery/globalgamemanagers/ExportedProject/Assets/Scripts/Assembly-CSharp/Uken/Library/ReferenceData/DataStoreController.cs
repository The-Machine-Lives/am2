using System;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.ReferenceData.DataProviders;

namespace Uken.Library.ReferenceData
{
	[Token(Token = "0x200046D")]
	public abstract class DataStoreController : UkenController
	{
		[Token(Token = "0x2000815")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8212C8", Offset = "0x8212C8")]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			[Token(Token = "0x4002348")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onComplete;

			[Token(Token = "0x60032E0")]
			[Address(RVA = "0xB3778C", Offset = "0xB3778C", VA = "0xB3778C")]
			public _003C_003Ec__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60032E1")]
			[Address(RVA = "0xB3779C", Offset = "0xB3779C", VA = "0xB3779C")]
			internal void _003CQueryProvider_003Eb__0(bool success, BaseProvider newStore)
			{
			}
		}

		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E768", Offset = "0x82E768")]
		private BaseDataStore _003Cm_baseDataStore_003Ek__BackingField;

		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E778", Offset = "0x82E778")]
		private VersionPlatform _003Cm_currentPlatform_003Ek__BackingField;

		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E788", Offset = "0x82E788")]
		private Version _003Cm_currentVersion_003Ek__BackingField;

		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E798", Offset = "0x82E798")]
		private string _003Cm_HostURL_003Ek__BackingField;

		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E7A8", Offset = "0x82E7A8")]
		private Action<WebRequest> _003Cm_webSend_003Ek__BackingField;

		[Token(Token = "0x170005D1")]
		protected BaseDataStore m_baseDataStore
		{
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0xB374D4", Offset = "0xB374D4", VA = "0xB374D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393A4", Offset = "0x8393A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0xB374DC", Offset = "0xB374DC", VA = "0xB374DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393B4", Offset = "0x8393B4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005D2")]
		public VersionPlatform m_currentPlatform
		{
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0xB374E4", Offset = "0xB374E4", VA = "0xB374E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393C4", Offset = "0x8393C4")]
			get
			{
				return default(VersionPlatform);
			}
			[Token(Token = "0x60020FB")]
			[Address(RVA = "0xB374EC", Offset = "0xB374EC", VA = "0xB374EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393D4", Offset = "0x8393D4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005D3")]
		public Version m_currentVersion
		{
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0xB36A30", Offset = "0xB36A30", VA = "0xB36A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393E4", Offset = "0x8393E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0xB374F4", Offset = "0xB374F4", VA = "0xB374F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393F4", Offset = "0x8393F4")]
			private set
			{
			}
		}

		[Token(Token = "0x170005D4")]
		public string m_HostURL
		{
			[Token(Token = "0x60020FE")]
			[Address(RVA = "0xB374FC", Offset = "0xB374FC", VA = "0xB374FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839404", Offset = "0x839404")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020FF")]
			[Address(RVA = "0xB37504", Offset = "0xB37504", VA = "0xB37504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839414", Offset = "0x839414")]
			private set
			{
			}
		}

		[Token(Token = "0x170005D5")]
		public Action<WebRequest> m_webSend
		{
			[Token(Token = "0x6002100")]
			[Address(RVA = "0xB3750C", Offset = "0xB3750C", VA = "0xB3750C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839424", Offset = "0x839424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002101")]
			[Address(RVA = "0xB37514", Offset = "0xB37514", VA = "0xB37514")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x839434", Offset = "0x839434")]
			private set
			{
			}
		}

		[Token(Token = "0x6002102")]
		[Address(RVA = "0xB3751C", Offset = "0xB3751C", VA = "0xB3751C")]
		public DataStoreController(string hostURL, Action<WebRequest> webSend, VersionPlatform platform, Version currentVersion)
		{
		}

		[Token(Token = "0x6002103")]
		public abstract BaseDataStore CreateDataStore();

		[Token(Token = "0x6002104")]
		[Address(RVA = "0xB3759C", Offset = "0xB3759C", VA = "0xB3759C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6002105")]
		[Address(RVA = "0xB3761C", Offset = "0xB3761C", VA = "0xB3761C", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6002106")]
		[Address(RVA = "0xB37674", Offset = "0xB37674", VA = "0xB37674")]
		public BaseDataStore GetBaseDataStore()
		{
			return null;
		}

		[Token(Token = "0x6002107")]
		[Address(RVA = "0xB30590", Offset = "0xB30590", VA = "0xB30590")]
		public StoreModel GetBaseStoreData()
		{
			return null;
		}

		[Token(Token = "0x6002108")]
		[Address(RVA = "0xB3767C", Offset = "0xB3767C", VA = "0xB3767C", Slot = "11")]
		public virtual void QueryNetworkProvider(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002109")]
		[Address(RVA = "0xB376B0", Offset = "0xB376B0", VA = "0xB376B0", Slot = "12")]
		public virtual void QueryProvider(int providerID, Action<bool> onComplete, bool useAsync)
		{
		}

		[Token(Token = "0x600210A")]
		[Address(RVA = "0xB37794", Offset = "0xB37794", VA = "0xB37794", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}
	}
}
