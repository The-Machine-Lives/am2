using Il2CppDummyDll;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x200000E")]
	public class AmazonAppStoreStoreExtensions : IAmazonExtensions, IAmazonConfiguration, IStoreExtension, IStoreConfiguration
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject android;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1783E40", Offset = "0x1783E40", VA = "0x1783E40")]
		public AmazonAppStoreStoreExtensions(AndroidJavaObject a)
		{
		}
	}
}
