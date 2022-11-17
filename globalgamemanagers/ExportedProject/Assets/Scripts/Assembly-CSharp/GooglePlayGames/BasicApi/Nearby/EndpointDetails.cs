using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F6")]
	public struct EndpointDetails
	{
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x0")]
		private readonly string mEndpointId;

		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mName;

		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0x10")]
		private readonly string mServiceId;

		[Token(Token = "0x170002FD")]
		public string EndpointId
		{
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x8B42CC", Offset = "0x8B42CC", VA = "0x8B42CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FE")]
		public string Name
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x8B42D4", Offset = "0x8B42D4", VA = "0x8B42D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FF")]
		public string ServiceId
		{
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x8B42DC", Offset = "0x8B42DC", VA = "0x8B42DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001745")]
		[Address(RVA = "0x8B42C4", Offset = "0x8B42C4", VA = "0x8B42C4")]
		public EndpointDetails(string endpointId, string name, string serviceId)
		{
		}
	}
}
