using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F2")]
	public struct AdvertisingResult
	{
		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x0")]
		private readonly ResponseStatus mStatus;

		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mLocalEndpointName;

		[Token(Token = "0x170002F4")]
		public bool Succeeded
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x8B3E04", Offset = "0x8B3E04", VA = "0x8B3E04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002F5")]
		public ResponseStatus Status
		{
			[Token(Token = "0x6001722")]
			[Address(RVA = "0x8B3E14", Offset = "0x8B3E14", VA = "0x8B3E14")]
			get
			{
				return default(ResponseStatus);
			}
		}

		[Token(Token = "0x170002F6")]
		public string LocalEndpointName
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x8B3E1C", Offset = "0x8B3E1C", VA = "0x8B3E1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001720")]
		[Address(RVA = "0x8B3DFC", Offset = "0x8B3DFC", VA = "0x8B3DFC")]
		public AdvertisingResult(ResponseStatus status, string localEndpointName)
		{
		}
	}
}
