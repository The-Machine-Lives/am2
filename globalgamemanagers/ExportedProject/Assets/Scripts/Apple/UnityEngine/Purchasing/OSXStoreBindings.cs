using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000006")]
	internal class OSXStoreBindings : INativeAppleStore, INativeStore
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x181AF24", Offset = "0x181AF24", VA = "0x181AF24")]
		public OSXStoreBindings()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x181AF2C", Offset = "0x181AF2C", VA = "0x181AF2C", Slot = "4")]
		public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x181AF94", Offset = "0x181AF94", VA = "0x181AF94", Slot = "5")]
		public void AddTransactionObserver()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x181AFFC", Offset = "0x181AFFC", VA = "0x181AFFC", Slot = "6")]
		public void RetrieveProducts(string json)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x181B064", Offset = "0x181B064", VA = "0x181B064", Slot = "7")]
		public void Purchase(string productJSON, string developerPayload)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x181B0CC", Offset = "0x181B0CC", VA = "0x181B0CC", Slot = "8")]
		public void FinishTransaction(string productJSON, string transactionID)
		{
		}
	}
}
