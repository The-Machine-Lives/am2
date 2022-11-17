using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Nearby
{
	[Token(Token = "0x20002F4")]
	public struct ConnectionResponse
	{
		[Token(Token = "0x200079E")]
		public enum Status
		{
			[Token(Token = "0x400221D")]
			Accepted = 0,
			[Token(Token = "0x400221E")]
			Rejected = 1,
			[Token(Token = "0x400221F")]
			ErrorInternal = 2,
			[Token(Token = "0x4002220")]
			ErrorNetworkNotConnected = 3,
			[Token(Token = "0x4002221")]
			ErrorEndpointNotConnected = 4,
			[Token(Token = "0x4002222")]
			ErrorAlreadyConnected = 5
		}

		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] EmptyPayload;

		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x0")]
		private readonly long mLocalClientId;

		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x8")]
		private readonly string mRemoteEndpointId;

		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x10")]
		private readonly Status mResponseStatus;

		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] mPayload;

		[Token(Token = "0x170002F9")]
		public long LocalClientId
		{
			[Token(Token = "0x6001728")]
			[Address(RVA = "0x8B42A4", Offset = "0x8B42A4", VA = "0x8B42A4")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x170002FA")]
		public string RemoteEndpointId
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x8B42AC", Offset = "0x8B42AC", VA = "0x8B42AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002FB")]
		public Status ResponseStatus
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x8B42B4", Offset = "0x8B42B4", VA = "0x8B42B4")]
			get
			{
				return default(Status);
			}
		}

		[Token(Token = "0x170002FC")]
		public byte[] Payload
		{
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x8B42BC", Offset = "0x8B42BC", VA = "0x8B42BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001727")]
		[Address(RVA = "0x8B429C", Offset = "0x8B429C", VA = "0x8B429C")]
		private ConnectionResponse(long localClientId, string remoteEndpointId, Status code, byte[] payload)
		{
		}

		[Token(Token = "0x600172C")]
		[Address(RVA = "0x1463F9C", Offset = "0x1463F9C", VA = "0x1463F9C")]
		public static ConnectionResponse Rejected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x600172D")]
		[Address(RVA = "0x1464030", Offset = "0x1464030", VA = "0x1464030")]
		public static ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x600172E")]
		[Address(RVA = "0x14640C4", Offset = "0x14640C4", VA = "0x14640C4")]
		public static ConnectionResponse InternalError(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x600172F")]
		[Address(RVA = "0x1464158", Offset = "0x1464158", VA = "0x1464158")]
		public static ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6001730")]
		[Address(RVA = "0x14641EC", Offset = "0x14641EC", VA = "0x14641EC")]
		public static ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload)
		{
			return default(ConnectionResponse);
		}

		[Token(Token = "0x6001731")]
		[Address(RVA = "0x1464218", Offset = "0x1464218", VA = "0x1464218")]
		public static ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId)
		{
			return default(ConnectionResponse);
		}
	}
}
