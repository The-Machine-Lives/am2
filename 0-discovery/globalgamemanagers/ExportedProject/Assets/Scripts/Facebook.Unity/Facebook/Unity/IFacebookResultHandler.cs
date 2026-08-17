using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200001C")]
	internal interface IFacebookResultHandler
	{
		[Token(Token = "0x60000D4")]
		void OnInitComplete(ResultContainer resultContainer);

		[Token(Token = "0x60000D5")]
		void OnLoginComplete(ResultContainer resultContainer);

		[Token(Token = "0x60000D6")]
		void OnLogoutComplete(ResultContainer resultContainer);

		[Token(Token = "0x60000D7")]
		void OnGetAppLinkComplete(ResultContainer resultContainer);

		[Token(Token = "0x60000D8")]
		void OnAppRequestsComplete(ResultContainer resultContainer);

		[Token(Token = "0x60000D9")]
		void OnShareLinkComplete(ResultContainer resultContainer);
	}
}
