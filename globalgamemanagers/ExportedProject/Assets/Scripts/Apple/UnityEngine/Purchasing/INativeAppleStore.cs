using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000003")]
	internal interface INativeAppleStore : INativeStore
	{
		[Token(Token = "0x6000005")]
		void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback);

		[Token(Token = "0x6000006")]
		void AddTransactionObserver();
	}
}
