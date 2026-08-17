using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000028")]
	internal class StoreConfiguration
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8187DC", Offset = "0x8187DC")]
		[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x8187DC", Offset = "0x8187DC")]
		private AndroidStore _003CandroidStore_003Ek__BackingField;

		[Token(Token = "0x17000005")]
		public AndroidStore androidStore
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x17894F0", Offset = "0x17894F0", VA = "0x17894F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81890C", Offset = "0x81890C")]
			get
			{
				return default(AndroidStore);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1789D68", Offset = "0x1789D68", VA = "0x1789D68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81891C", Offset = "0x81891C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1789D3C", Offset = "0x1789D3C", VA = "0x1789D3C")]
		public StoreConfiguration(AndroidStore store)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x17892B4", Offset = "0x17892B4", VA = "0x17892B4")]
		public static StoreConfiguration Deserialize(string json)
		{
			return null;
		}
	}
}
