using System.Collections;
using System.Collections.Generic;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x2000216")]
public class InventoryApiConfig : IApiConfig
{
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x10")]
	protected string m_baseURL;

	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x18")]
	protected string m_authToken;

	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x20")]
	protected Dictionary<string, object> m_headers;

	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x98E310", Offset = "0x98E310", VA = "0x98E310", Slot = "5")]
	public string GetAuthorizationToken()
	{
		return null;
	}

	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x98E318", Offset = "0x98E318", VA = "0x98E318")]
	public void SetBaseUrl(string baseURL)
	{
	}

	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x98E320", Offset = "0x98E320", VA = "0x98E320")]
	public void SetAuthToken(string authToken)
	{
	}

	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x98E328", Offset = "0x98E328", VA = "0x98E328", Slot = "4")]
	public string GetBaseUrl()
	{
		return null;
	}

	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x98E330", Offset = "0x98E330", VA = "0x98E330", Slot = "6")]
	public Dictionary<string, object> GetHeaders()
	{
		return null;
	}

	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x98E338", Offset = "0x98E338", VA = "0x98E338", Slot = "7")]
	public void StartCoroutine(IEnumerator coroutine)
	{
	}

	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x98E374", Offset = "0x98E374", VA = "0x98E374")]
	public InventoryApiConfig()
	{
	}
}
