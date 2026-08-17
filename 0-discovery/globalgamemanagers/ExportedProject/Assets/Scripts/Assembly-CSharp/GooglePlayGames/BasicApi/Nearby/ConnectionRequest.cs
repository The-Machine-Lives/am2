using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F3")]
	public struct ConnectionRequest
	{
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x0")]
		private readonly EndpointDetails mRemoteEndpoint;

		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x170002F7")]
		public EndpointDetails RemoteEndpoint
		{
			[Token(Token = "0x6001725")]
			[Address(RVA = "0x8B40C0", Offset = "0x8B40C0", VA = "0x8B40C0")]
			get
			{
				return default(EndpointDetails);
			}
		}

		[Token(Token = "0x170002F8")]
		public byte[] Payload
		{
			[Token(Token = "0x6001726")]
			[Address(RVA = "0x8B40D4", Offset = "0x8B40D4", VA = "0x8B40D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001724")]
		[Address(RVA = "0x8B40B8", Offset = "0x8B40B8", VA = "0x8B40B8")]
		public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		{
		}
	}
}
