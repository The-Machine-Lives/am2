using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000004")]
	internal interface INativeStore
	{
		[Token(Token = "0x6000007")]
		void RetrieveProducts(string json);

		[Token(Token = "0x6000008")]
		void Purchase(string productJSON, string developerPayload);

		[Token(Token = "0x6000009")]
		void FinishTransaction(string productJSON, string transactionID);
	}
}
