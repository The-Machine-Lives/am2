using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Purchasing.Default
{
	[Token(Token = "0x2000004")]
	public interface IWindowsIAP
	{
		[Token(Token = "0x6000002")]
		void BuildDummyProducts(List<WinProductDescription> products);

		[Token(Token = "0x6000003")]
		void Initialize(IWindowsIAPCallback callback);

		[Token(Token = "0x6000004")]
		void RetrieveProducts(bool retryIfOffline);

		[Token(Token = "0x6000005")]
		void Purchase(string productId);

		[Token(Token = "0x6000006")]
		void FinaliseTransaction(string transactionId);
	}
}
