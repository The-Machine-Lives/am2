using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002D3")]
	public enum CommonStatusCodes
	{
		[Token(Token = "0x4000D4E")]
		SuccessCached = -1,
		[Token(Token = "0x4000D4F")]
		Success = 0,
		[Token(Token = "0x4000D50")]
		ServiceMissing = 1,
		[Token(Token = "0x4000D51")]
		ServiceVersionUpdateRequired = 2,
		[Token(Token = "0x4000D52")]
		ServiceDisabled = 3,
		[Token(Token = "0x4000D53")]
		SignInRequired = 4,
		[Token(Token = "0x4000D54")]
		InvalidAccount = 5,
		[Token(Token = "0x4000D55")]
		ResolutionRequired = 6,
		[Token(Token = "0x4000D56")]
		NetworkError = 7,
		[Token(Token = "0x4000D57")]
		InternalError = 8,
		[Token(Token = "0x4000D58")]
		ServiceInvalid = 9,
		[Token(Token = "0x4000D59")]
		DeveloperError = 10,
		[Token(Token = "0x4000D5A")]
		LicenseCheckFailed = 11,
		[Token(Token = "0x4000D5B")]
		Error = 13,
		[Token(Token = "0x4000D5C")]
		Interrupted = 14,
		[Token(Token = "0x4000D5D")]
		Timeout = 15,
		[Token(Token = "0x4000D5E")]
		Canceled = 16,
		[Token(Token = "0x4000D5F")]
		ApiNotConnected = 17,
		[Token(Token = "0x4000D60")]
		AuthApiInvalidCredentials = 3000,
		[Token(Token = "0x4000D61")]
		AuthApiAccessForbidden = 3001,
		[Token(Token = "0x4000D62")]
		AuthApiClientError = 3002,
		[Token(Token = "0x4000D63")]
		AuthApiServerError = 3003,
		[Token(Token = "0x4000D64")]
		AuthTokenError = 3004,
		[Token(Token = "0x4000D65")]
		AuthUrlResolution = 3005
	}
}
