using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000004")]
	internal interface IUnityCallback
	{
		[Token(Token = "0x6000005")]
		void OnSetupFailed(string json);

		[Token(Token = "0x6000006")]
		void OnProductsRetrieved(string json);

		[Token(Token = "0x6000007")]
		void OnPurchaseSucceeded(string id, string receipt, string transactionID);

		[Token(Token = "0x6000008")]
		void OnPurchaseFailed(string json);
	}
}
