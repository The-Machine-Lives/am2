using System;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.PInvoke;
using Il2CppDummyDll;

namespace GooglePlayGames.Native
{
	[Token(Token = "0x2000260")]
	internal interface IClientImpl
	{
		[Token(Token = "0x60011E8")]
		PlatformConfiguration CreatePlatformConfiguration(PlayGamesClientConfiguration clientConfig);

		[Token(Token = "0x60011E9")]
		TokenClient CreateTokenClient(bool reset);

		[Token(Token = "0x60011EA")]
		void GetPlayerStats(IntPtr apiClientPtr, Action<CommonStatusCodes, PlayerStats> callback);

		[Token(Token = "0x60011EB")]
		void SetGravityForPopups(IntPtr apiClient, Gravity gravity);
	}
}
