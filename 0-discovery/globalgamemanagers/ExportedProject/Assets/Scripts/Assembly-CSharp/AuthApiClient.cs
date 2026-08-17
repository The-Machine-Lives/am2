using System;
using Com.Uken.ApiClient;
using Il2CppDummyDll;

[Token(Token = "0x20001F5")]
public class AuthApiClient : ApiClient
{
	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0xA36658", Offset = "0xA36658", VA = "0xA36658")]
	public AuthApiClient(IApiConfig config)
	{
	}

	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0xA36660", Offset = "0xA36660", VA = "0xA36660")]
	public void GuestLogin(string credential, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0xA36714", Offset = "0xA36714", VA = "0xA36714")]
	public void GuestLink(Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0xA36820", Offset = "0xA36820", VA = "0xA36820")]
	public void GuestUnlink(string credential, string userID, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0xA36960", Offset = "0xA36960", VA = "0xA36960")]
	public void GooglePlayLogin(string authCode, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0xA36A14", Offset = "0xA36A14", VA = "0xA36A14")]
	public void GooglePlayLink(string authCode, bool forced, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D43")]
	[Address(RVA = "0xA36B54", Offset = "0xA36B54", VA = "0xA36B54")]
	public void GooglePlayUnlink(string authCode, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D44")]
	[Address(RVA = "0xA36C08", Offset = "0xA36C08", VA = "0xA36C08")]
	public void AppleLogin(string identityToken, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D45")]
	[Address(RVA = "0xA36CBC", Offset = "0xA36CBC", VA = "0xA36CBC")]
	public void AppleLink(string identityToken, bool forced, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D46")]
	[Address(RVA = "0xA36DFC", Offset = "0xA36DFC", VA = "0xA36DFC")]
	public void AppleUnlink(string identityToken, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D47")]
	[Address(RVA = "0xA36EB0", Offset = "0xA36EB0", VA = "0xA36EB0")]
	public void UnlinkAll(Action<string> successCallback, Action<long, string> errorCallback)
	{
	}

	[Token(Token = "0x6000D48")]
	[Address(RVA = "0xA36FBC", Offset = "0xA36FBC", VA = "0xA36FBC")]
	public void RefreshAuth(string refreshToken, Action<string> successCallback, Action<long, string> errorCallback)
	{
	}
}
