using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000005")]
	internal class iOSStoreBindings : INativeAppleStore, INativeStore
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x181B98C", Offset = "0x181B98C", VA = "0x181B98C")]
		public iOSStoreBindings()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x181B994", Offset = "0x181B994", VA = "0x181B994", Slot = "4")]
		public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x181B9FC", Offset = "0x181B9FC", VA = "0x181B9FC", Slot = "5")]
		public void AddTransactionObserver()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x181BA64", Offset = "0x181BA64", VA = "0x181BA64", Slot = "6")]
		public void RetrieveProducts(string json)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x181BACC", Offset = "0x181BACC", VA = "0x181BACC", Slot = "7")]
		public void Purchase(string productJSON, string developerPayload)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x181BB34", Offset = "0x181BB34", VA = "0x181BB34", Slot = "8")]
		public void FinishTransaction(string productJSON, string transactionID)
		{
		}
	}
}
