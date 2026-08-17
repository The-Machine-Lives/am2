using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000007")]
	internal class JavaBridge : AndroidJavaProxy, IUnityCallback
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		private IUnityCallback forwardTo;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17877F0", Offset = "0x17877F0", VA = "0x17877F0")]
		public JavaBridge(IUnityCallback forwardTo)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1787878", Offset = "0x1787878", VA = "0x1787878", Slot = "9")]
		public void OnSetupFailed(string json)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x178793C", Offset = "0x178793C", VA = "0x178793C", Slot = "10")]
		public void OnProductsRetrieved(string json)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1787A04", Offset = "0x1787A04", VA = "0x1787A04", Slot = "11")]
		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1787AE4", Offset = "0x1787AE4", VA = "0x1787AE4", Slot = "12")]
		public void OnPurchaseFailed(string json)
		{
		}
	}
}
