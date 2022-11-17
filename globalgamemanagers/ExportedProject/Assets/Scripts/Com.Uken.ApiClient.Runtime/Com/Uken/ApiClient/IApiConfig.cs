using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Com.Uken.ApiClient
{
	[Token(Token = "0x200000A")]
	public interface IApiConfig
	{
		[Token(Token = "0x6000020")]
		string GetBaseUrl();

		[Token(Token = "0x6000021")]
		string GetAuthorizationToken();

		[Token(Token = "0x6000022")]
		Dictionary<string, object> GetHeaders();

		[Token(Token = "0x6000023")]
		void StartCoroutine(IEnumerator coroutine);
	}
}
