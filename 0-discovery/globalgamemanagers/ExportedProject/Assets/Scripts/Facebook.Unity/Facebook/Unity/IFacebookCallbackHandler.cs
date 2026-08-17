using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200001A")]
	internal interface IFacebookCallbackHandler
	{
		[Token(Token = "0x60000D0")]
		void OnInitComplete(string message);

		[Token(Token = "0x60000D1")]
		void OnLoginComplete(string message);

		[Token(Token = "0x60000D2")]
		void OnAppRequestsComplete(string message);

		[Token(Token = "0x60000D3")]
		void OnShareLinkComplete(string message);
	}
}
