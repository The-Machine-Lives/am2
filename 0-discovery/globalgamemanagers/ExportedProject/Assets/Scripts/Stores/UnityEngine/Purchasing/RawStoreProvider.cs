using Il2CppDummyDll;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000023")]
	internal class RawStoreProvider : IRawStoreProvider
	{
		[Token(Token = "0x2000024")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81868C", Offset = "0x81868C")]
		private sealed class _003CGetAndroidStore_003Ec__AnonStorey0
		{
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x10")]
			internal AndroidJavaObject instance;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x17885D0", Offset = "0x17885D0", VA = "0x17885D0")]
			public _003CGetAndroidStore_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1788674", Offset = "0x1788674", VA = "0x1788674")]
			internal void _003C_003Em__0(bool paused)
			{
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1787E40", Offset = "0x1787E40", VA = "0x1787E40")]
		public RawStoreProvider()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1787E48", Offset = "0x1787E48", VA = "0x1787E48", Slot = "4")]
		public INativeStore GetAndroidStore(IUnityCallback callback, AndroidStore store, IPurchasingBinder binder, IUtil util)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17885D8", Offset = "0x17885D8", VA = "0x17885D8", Slot = "5")]
		public INativeAppleStore GetStorekit(IUnityCallback callback)
		{
			return null;
		}
	}
}
