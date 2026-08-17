using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000002")]
	internal class AndroidJavaStore : INativeStore
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private AndroidJavaObject m_Store;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1783E6C", Offset = "0x1783E6C", VA = "0x1783E6C")]
		public AndroidJavaStore(AndroidJavaObject store)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1783E98", Offset = "0x1783E98", VA = "0x1783E98", Slot = "4")]
		public void RetrieveProducts(string json)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1783F78", Offset = "0x1783F78", VA = "0x1783F78", Slot = "5")]
		public void Purchase(string productJSON, string developerPayload)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x17840A4", Offset = "0x17840A4", VA = "0x17840A4", Slot = "6")]
		public void FinishTransaction(string productJSON, string transactionID)
		{
		}
	}
}
