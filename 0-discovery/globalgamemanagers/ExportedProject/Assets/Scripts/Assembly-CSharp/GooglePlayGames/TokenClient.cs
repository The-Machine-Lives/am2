using System;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000253")]
	internal interface TokenClient
	{
		[Token(Token = "0x600112D")]
		string GetEmail();

		[Token(Token = "0x600112E")]
		string GetAuthCode();

		[Token(Token = "0x600112F")]
		string GetIdToken();

		[Token(Token = "0x6001130")]
		void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, Action<string> callback);

		[Token(Token = "0x6001131")]
		void Signout();

		[Token(Token = "0x6001132")]
		void SetRequestAuthCode(bool flag, bool forceRefresh);

		[Token(Token = "0x6001133")]
		void SetRequestEmail(bool flag);

		[Token(Token = "0x6001134")]
		void SetRequestIdToken(bool flag);

		[Token(Token = "0x6001135")]
		void SetWebClientId(string webClientId);

		[Token(Token = "0x6001136")]
		void SetAccountName(string accountName);

		[Token(Token = "0x6001137")]
		void AddOauthScopes(params string[] scopes);

		[Token(Token = "0x6001138")]
		void SetHidePopups(bool flag);

		[Token(Token = "0x6001139")]
		void FetchTokens(bool silent, Action<int> callback);
	}
}
