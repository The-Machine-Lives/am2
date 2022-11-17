using System;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x2000206")]
public class PIIScrubberApiClient : ApiClient
{
	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0x18")]
	private PIIScrubberApiConfig m_scrubberConfig;

	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x99EDF8", Offset = "0x99EDF8", VA = "0x99EDF8")]
	public PIIScrubberApiClient(PIIScrubberApiConfig config)
	{
	}

	[Token(Token = "0x6000DA7")]
	[Address(RVA = "0x99EE24", Offset = "0x99EE24", VA = "0x99EE24")]
	public void ScrubUser(string authToken, string userID, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}
}
