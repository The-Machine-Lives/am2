using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x2000301")]
	public class Participant : IComparable<Participant>
	{
		[Token(Token = "0x20007A1")]
		public enum ParticipantStatus
		{
			[Token(Token = "0x400222E")]
			NotInvitedYet = 0,
			[Token(Token = "0x400222F")]
			Invited = 1,
			[Token(Token = "0x4002230")]
			Joined = 2,
			[Token(Token = "0x4002231")]
			Declined = 3,
			[Token(Token = "0x4002232")]
			Left = 4,
			[Token(Token = "0x4002233")]
			Finished = 5,
			[Token(Token = "0x4002234")]
			Unresponsive = 6,
			[Token(Token = "0x4002235")]
			Unknown = 7
		}

		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x10")]
		private string mDisplayName;

		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x18")]
		private readonly string mParticipantId;

		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x20")]
		private ParticipantStatus mStatus;

		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x28")]
		private Player mPlayer;

		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x30")]
		private bool mIsConnectedToRoom;

		[Token(Token = "0x17000308")]
		public string DisplayName
		{
			[Token(Token = "0x6001799")]
			[Address(RVA = "0x1462C1C", Offset = "0x1462C1C", VA = "0x1462C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000309")]
		public string ParticipantId
		{
			[Token(Token = "0x600179A")]
			[Address(RVA = "0x1462C24", Offset = "0x1462C24", VA = "0x1462C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030A")]
		public ParticipantStatus Status
		{
			[Token(Token = "0x600179B")]
			[Address(RVA = "0x1462C2C", Offset = "0x1462C2C", VA = "0x1462C2C")]
			get
			{
				return default(ParticipantStatus);
			}
		}

		[Token(Token = "0x1700030B")]
		public Player Player
		{
			[Token(Token = "0x600179C")]
			[Address(RVA = "0x1462C34", Offset = "0x1462C34", VA = "0x1462C34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030C")]
		public bool IsConnectedToRoom
		{
			[Token(Token = "0x600179D")]
			[Address(RVA = "0x1462C3C", Offset = "0x1462C3C", VA = "0x1462C3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700030D")]
		public bool IsAutomatch
		{
			[Token(Token = "0x600179E")]
			[Address(RVA = "0x1462C44", Offset = "0x1462C44", VA = "0x1462C44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x1462C54", Offset = "0x1462C54", VA = "0x1462C54")]
		internal Participant(string displayName, string participantId, ParticipantStatus status, Player player, bool connectedToRoom)
		{
		}

		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x1462D0C", Offset = "0x1462D0C", VA = "0x1462D0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x1462FAC", Offset = "0x1462FAC", VA = "0x1462FAC", Slot = "4")]
		public int CompareTo(Participant other)
		{
			return default(int);
		}

		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x1462FE8", Offset = "0x1462FE8", VA = "0x1462FE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x1463160", Offset = "0x1463160", VA = "0x1463160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
