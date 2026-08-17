using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x20002FC")]
	public class Invitation
	{
		[Token(Token = "0x200079F")]
		public enum InvType
		{
			[Token(Token = "0x4002224")]
			RealTime = 0,
			[Token(Token = "0x4002225")]
			TurnBased = 1,
			[Token(Token = "0x4002226")]
			Unknown = 2
		}

		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0x10")]
		private InvType mInvitationType;

		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0x18")]
		private string mInvitationId;

		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x20")]
		private Participant mInviter;

		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x28")]
		private int mVariant;

		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x30")]
		private long mCreationTime;

		[Token(Token = "0x17000302")]
		public InvType InvitationType
		{
			[Token(Token = "0x6001760")]
			[Address(RVA = "0x1461B84", Offset = "0x1461B84", VA = "0x1461B84")]
			get
			{
				return default(InvType);
			}
		}

		[Token(Token = "0x17000303")]
		public string InvitationId
		{
			[Token(Token = "0x6001761")]
			[Address(RVA = "0x1461B8C", Offset = "0x1461B8C", VA = "0x1461B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000304")]
		public Participant Inviter
		{
			[Token(Token = "0x6001762")]
			[Address(RVA = "0x1461B94", Offset = "0x1461B94", VA = "0x1461B94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000305")]
		public int Variant
		{
			[Token(Token = "0x6001763")]
			[Address(RVA = "0x1461B9C", Offset = "0x1461B9C", VA = "0x1461B9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000306")]
		public DateTime CreationTime
		{
			[Token(Token = "0x6001764")]
			[Address(RVA = "0x1461BA4", Offset = "0x1461BA4", VA = "0x1461BA4")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x600175F")]
		[Address(RVA = "0x1461B2C", Offset = "0x1461B2C", VA = "0x1461B2C")]
		internal Invitation(InvType invType, string invId, Participant inviter, int variant, long creationTime)
		{
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x1461C34", Offset = "0x1461C34", VA = "0x1461C34", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
