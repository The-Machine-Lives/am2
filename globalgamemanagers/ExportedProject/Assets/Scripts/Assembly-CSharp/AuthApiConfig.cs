using System.Collections;
using System.Collections.Generic;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x20001F6")]
public class AuthApiConfig : IApiConfig
{
	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x10")]
	protected string m_baseURL;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x18")]
	protected string m_authToken;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x20")]
	protected Dictionary<string, object> m_headers;

	[Token(Token = "0x6000D49")]
	[Address(RVA = "0xA37070", Offset = "0xA37070", VA = "0xA37070")]
	public AuthApiConfig(string baseAuthUrl)
	{
	}

	[Token(Token = "0x6000D4A")]
	[Address(RVA = "0xA3709C", Offset = "0xA3709C", VA = "0xA3709C", Slot = "5")]
	public string GetAuthorizationToken()
	{
		return null;
	}

	[Token(Token = "0x6000D4B")]
	[Address(RVA = "0xA370A4", Offset = "0xA370A4", VA = "0xA370A4")]
	public void SetupWithAuthToken(string authToken)
	{
	}

	[Token(Token = "0x6000D4C")]
	[Address(RVA = "0xA3717C", Offset = "0xA3717C", VA = "0xA3717C", Slot = "4")]
	public string GetBaseUrl()
	{
		return null;
	}

	[Token(Token = "0x6000D4D")]
	[Address(RVA = "0xA37184", Offset = "0xA37184", VA = "0xA37184", Slot = "6")]
	public Dictionary<string, object> GetHeaders()
	{
		return null;
	}

	[Token(Token = "0x6000D4E")]
	[Address(RVA = "0xA3718C", Offset = "0xA3718C", VA = "0xA3718C", Slot = "7")]
	public void StartCoroutine(IEnumerator coroutine)
	{
	}
}
