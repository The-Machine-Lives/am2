using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002AE")]
	internal static class NearbyConnectionsStatus
	{
		[Token(Token = "0x2000751")]
		internal enum InitializationStatus
		{
			[Token(Token = "0x400215C")]
			VALID = 1,
			[Token(Token = "0x400215D")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400215E")]
			ERROR_VERSION_UPDATE_REQUIRED = -4
		}
	}
}
