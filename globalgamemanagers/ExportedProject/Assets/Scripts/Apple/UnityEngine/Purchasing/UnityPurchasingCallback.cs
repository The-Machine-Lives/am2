using Il2CppDummyDll;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000002")]
	internal delegate void UnityPurchasingCallback(string subject, string payload, string receipt, string transactionId);
}
