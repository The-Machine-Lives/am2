using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000016")]
	internal class FakeAppleConfiguation : IAppleConfiguration, IStoreConfiguration
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1785DC4", Offset = "0x1785DC4", VA = "0x1785DC4")]
		public FakeAppleConfiguation()
		{
		}
	}
}
