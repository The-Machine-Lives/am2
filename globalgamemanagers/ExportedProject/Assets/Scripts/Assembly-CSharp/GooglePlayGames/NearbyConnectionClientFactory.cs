using System;
using GooglePlayGames.BasicApi.Nearby;
using GooglePlayGames.Native.Cwrapper;
using Il2CppDummyDll;

namespace GooglePlayGames
{
	[Token(Token = "0x2000251")]
	public static class NearbyConnectionClientFactory
	{
		[Token(Token = "0x6001129")]
		[Address(RVA = "0xE6B7A8", Offset = "0xE6B7A8", VA = "0xE6B7A8")]
		public static void Create(Action<INearbyConnectionClient> callback)
		{
		}

		[Token(Token = "0x600112A")]
		[Address(RVA = "0xE6B89C", Offset = "0xE6B89C", VA = "0xE6B89C")]
		private static InitializationStatus ToStatus(NearbyConnectionsStatus.InitializationStatus status)
		{
			return default(InitializationStatus);
		}
	}
}
