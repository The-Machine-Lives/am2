using System.Collections;
using System.Collections.Generic;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x2000207")]
public class PIIScrubberApiConfig : IApiConfig
{
	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x826184", Offset = "0x826184")]
	private readonly string _003CgameID_003Ek__BackingField;

	[Token(Token = "0x4000B78")]
	[FieldOffset(Offset = "0x18")]
	protected string m_baseURL;

	[Token(Token = "0x4000B79")]
	[FieldOffset(Offset = "0x20")]
	protected string m_authToken;

	[Token(Token = "0x4000B7A")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<string, object> m_headers;

	[Token(Token = "0x170001B0")]
	public string gameID
	{
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x99EF90", Offset = "0x99EF90", VA = "0x99EF90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x835214", Offset = "0x835214")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000DA9")]
	[Address(RVA = "0x99EF98", Offset = "0x99EF98", VA = "0x99EF98")]
	public PIIScrubberApiConfig(string baseAuthUrl, string scrubAPIKey, string inGameID)
	{
	}

	[Token(Token = "0x6000DAA")]
	[Address(RVA = "0x99EF88", Offset = "0x99EF88", VA = "0x99EF88")]
	public void SetAuthToken(string authToken)
	{
	}

	[Token(Token = "0x6000DAB")]
	[Address(RVA = "0x99EFD0", Offset = "0x99EFD0", VA = "0x99EFD0", Slot = "5")]
	public string GetAuthorizationToken()
	{
		return null;
	}

	[Token(Token = "0x6000DAC")]
	[Address(RVA = "0x99EFD8", Offset = "0x99EFD8", VA = "0x99EFD8", Slot = "4")]
	public string GetBaseUrl()
	{
		return null;
	}

	[Token(Token = "0x6000DAD")]
	[Address(RVA = "0x99EFE0", Offset = "0x99EFE0", VA = "0x99EFE0", Slot = "6")]
	public Dictionary<string, object> GetHeaders()
	{
		return null;
	}

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x99EFE8", Offset = "0x99EFE8", VA = "0x99EFE8", Slot = "7")]
	public void StartCoroutine(IEnumerator coroutine)
	{
	}
}
