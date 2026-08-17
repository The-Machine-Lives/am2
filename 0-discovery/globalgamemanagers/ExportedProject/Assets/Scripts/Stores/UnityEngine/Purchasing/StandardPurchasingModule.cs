using Il2CppDummyDll;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000025")]
	public class StandardPurchasingModule : AbstractPurchasingModule, IAndroidStoreSelection, IStoreConfiguration
	{
		[Token(Token = "0x2000026")]
		internal class StoreInstance
		{
			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x818764", Offset = "0x818764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x818764", Offset = "0x818764")]
			private readonly string _003CstoreName_003Ek__BackingField;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8187A0", Offset = "0x8187A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8187A0", Offset = "0x8187A0")]
			private readonly IStore _003Cinstance_003Ek__BackingField;

			[Token(Token = "0x17000003")]
			internal string storeName
			{
				[Token(Token = "0x600005E")]
				[Address(RVA = "0x1789898", Offset = "0x1789898", VA = "0x1789898")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8188EC", Offset = "0x8188EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			internal IStore instance
			{
				[Token(Token = "0x600005F")]
				[Address(RVA = "0x17898A0", Offset = "0x17898A0", VA = "0x17898A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8188FC", Offset = "0x8188FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x17899C8", Offset = "0x17899C8", VA = "0x17899C8")]
			internal StoreInstance(string name, IStore instance)
			{
			}
		}

		[Token(Token = "0x2000027")]
		private class MicrosoftConfiguration : IMicrosoftConfiguration, IStoreConfiguration
		{
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x10")]
			private StandardPurchasingModule module;

			[Token(Token = "0x6000060")]
			[Address(RVA = "0x17896D8", Offset = "0x17896D8", VA = "0x17896D8")]
			public MicrosoftConfiguration(StandardPurchasingModule module)
			{
			}
		}

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		private AndroidStore m_AndroidPlatform;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		private IRawStoreProvider m_PlatformProvider;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		private RuntimePlatform m_RuntimePlatform;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x30")]
		private IUtil m_Util;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x38")]
		private ILogger m_Logger;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x0")]
		private static StandardPurchasingModule ModuleInstance;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x40")]
		private StoreInstance m_StoreInstance;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x818728", Offset = "0x818728")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x818728", Offset = "0x818728")]
		private FakeStoreUIMode _003CuseFakeStoreUIMode_003Ek__BackingField;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x50")]
		private WinRTStore windowsStore;

		[Token(Token = "0x17000002")]
		public FakeStoreUIMode useFakeStoreUIMode
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1789060", Offset = "0x1789060", VA = "0x1789060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8188CC", Offset = "0x8188CC")]
			get
			{
				return default(FakeStoreUIMode);
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1789058", Offset = "0x1789058", VA = "0x1789058")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8188DC", Offset = "0x8188DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1788FFC", Offset = "0x1788FFC", VA = "0x1788FFC")]
		internal StandardPurchasingModule(IUtil util, ILogger logger, IRawStoreProvider platformProvider, RuntimePlatform platform, AndroidStore android)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1789068", Offset = "0x1789068", VA = "0x1789068")]
		public static StandardPurchasingModule Instance()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17894F8", Offset = "0x17894F8", VA = "0x17894F8", Slot = "5")]
		public override void Configure()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1789704", Offset = "0x1789704", VA = "0x1789704")]
		private StoreInstance InstantiateStore()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1789A00", Offset = "0x1789A00", VA = "0x1789A00")]
		private IStore InstantiateAndroid()
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17898A8", Offset = "0x17898A8", VA = "0x17898A8")]
		private IStore InstantiateApple()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1789B18", Offset = "0x1789B18", VA = "0x1789B18")]
		private IStore instantiateWindowsStore()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1789C60", Offset = "0x1789C60", VA = "0x1789C60")]
		private IStore InstantiateFakeStore()
		{
			return null;
		}
	}
}
