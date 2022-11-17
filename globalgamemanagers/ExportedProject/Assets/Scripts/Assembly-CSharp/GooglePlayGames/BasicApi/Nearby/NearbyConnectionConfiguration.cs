using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002FB")]
	public struct NearbyConnectionConfiguration
	{
		[Token(Token = "0x4000DF0")]
		public const int MaxUnreliableMessagePayloadLength = 1168;

		[Token(Token = "0x4000DF1")]
		public const int MaxReliableMessagePayloadLength = 4096;

		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<InitializationStatus> mInitializationCallback;

		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0x8")]
		private readonly long mLocalClientId;

		[Token(Token = "0x17000300")]
		public long LocalClientId
		{
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x8B4390", Offset = "0x8B4390", VA = "0x8B4390")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000301")]
		public Action<InitializationStatus> InitializationCallback
		{
			[Token(Token = "0x600175E")]
			[Address(RVA = "0x8B4398", Offset = "0x8B4398", VA = "0x8B4398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600175C")]
		[Address(RVA = "0x8B4388", Offset = "0x8B4388", VA = "0x8B4388")]
		public NearbyConnectionConfiguration(Action<InitializationStatus> callback, long localClientId)
		{
		}
	}
}
