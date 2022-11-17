using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x200000F")]
	public class FakeAmazonExtensions : IAmazonExtensions, IAmazonConfiguration, IStoreExtension, IStoreConfiguration
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1785DBC", Offset = "0x1785DBC", VA = "0x1785DBC")]
		public FakeAmazonExtensions()
		{
		}
	}
}
