using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi.Multiplayer
{
	[Token(Token = "0x2000304")]
	public class TurnBasedMatch
	{
		[Token(Token = "0x20007A2")]
		public enum MatchStatus
		{
			[Token(Token = "0x4002237")]
			Active = 0,
			[Token(Token = "0x4002238")]
			AutoMatching = 1,
			[Token(Token = "0x4002239")]
			Cancelled = 2,
			[Token(Token = "0x400223A")]
			Complete = 3,
			[Token(Token = "0x400223B")]
			Expired = 4,
			[Token(Token = "0x400223C")]
			Unknown = 5,
			[Token(Token = "0x400223D")]
			Deleted = 6
		}

		[Token(Token = "0x20007A3")]
		public enum MatchTurnStatus
		{
			[Token(Token = "0x400223F")]
			Complete = 0,
			[Token(Token = "0x4002240")]
			Invited = 1,
			[Token(Token = "0x4002241")]
			MyTurn = 2,
			[Token(Token = "0x4002242")]
			TheirTurn = 3,
			[Token(Token = "0x4002243")]
			Unknown = 4
		}

		[Serializable]
		[Token(Token = "0x20007A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F68", Offset = "0x820F68")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4002244")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4002245")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Participant, string> _003C_003E9__48_0;

			[Token(Token = "0x600319D")]
			[Address(RVA = "0x1463C8C", Offset = "0x1463C8C", VA = "0x1463C8C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600319E")]
			[Address(RVA = "0x1463C94", Offset = "0x1463C94", VA = "0x1463C94")]
			internal string _003CToString_003Eb__48_0(Participant p)
			{
				return null;
			}
		}

		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x10")]
		private string mMatchId;

		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x18")]
		private byte[] mData;

		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x20")]
		private bool mCanRematch;

		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x24")]
		private uint mAvailableAutomatchSlots;

		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x28")]
		private string mSelfParticipantId;

		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x30")]
		private List<Participant> mParticipants;

		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x38")]
		private string mPendingParticipantId;

		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x40")]
		private MatchTurnStatus mTurnStatus;

		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x44")]
		private MatchStatus mMatchStatus;

		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x48")]
		private uint mVariant;

		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x4C")]
		private uint mVersion;

		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x50")]
		private long mCreationTime;

		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x58")]
		private long mLastUpdateTime;

		[Token(Token = "0x1700030E")]
		public DateTime CreationTime
		{
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x1463288", Offset = "0x1463288", VA = "0x1463288")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x1700030F")]
		public DateTime LastUpdateTime
		{
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x1463318", Offset = "0x1463318", VA = "0x1463318")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000310")]
		public string MatchId
		{
			[Token(Token = "0x60017AF")]
			[Address(RVA = "0x14633A8", Offset = "0x14633A8", VA = "0x14633A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000311")]
		public byte[] Data
		{
			[Token(Token = "0x60017B0")]
			[Address(RVA = "0x14633B0", Offset = "0x14633B0", VA = "0x14633B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000312")]
		public bool CanRematch
		{
			[Token(Token = "0x60017B1")]
			[Address(RVA = "0x14633B8", Offset = "0x14633B8", VA = "0x14633B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000313")]
		public string SelfParticipantId
		{
			[Token(Token = "0x60017B2")]
			[Address(RVA = "0x14633C0", Offset = "0x14633C0", VA = "0x14633C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000314")]
		public Participant Self
		{
			[Token(Token = "0x60017B3")]
			[Address(RVA = "0x14633C8", Offset = "0x14633C8", VA = "0x14633C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000315")]
		public List<Participant> Participants
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x1463588", Offset = "0x1463588", VA = "0x1463588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000316")]
		public string PendingParticipantId
		{
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x1463590", Offset = "0x1463590", VA = "0x1463590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000317")]
		public Participant PendingParticipant
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x1463598", Offset = "0x1463598", VA = "0x1463598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000318")]
		public MatchTurnStatus TurnStatus
		{
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x14635AC", Offset = "0x14635AC", VA = "0x14635AC")]
			get
			{
				return default(MatchTurnStatus);
			}
		}

		[Token(Token = "0x17000319")]
		public MatchStatus Status
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x14635B4", Offset = "0x14635B4", VA = "0x14635B4")]
			get
			{
				return default(MatchStatus);
			}
		}

		[Token(Token = "0x1700031A")]
		public uint Variant
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x14635BC", Offset = "0x14635BC", VA = "0x14635BC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700031B")]
		public uint Version
		{
			[Token(Token = "0x60017BB")]
			[Address(RVA = "0x14635C4", Offset = "0x14635C4", VA = "0x14635C4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700031C")]
		public uint AvailableAutomatchSlots
		{
			[Token(Token = "0x60017BC")]
			[Address(RVA = "0x14635CC", Offset = "0x14635CC", VA = "0x14635CC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x1463180", Offset = "0x1463180", VA = "0x1463180")]
		internal TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, List<Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, MatchTurnStatus turnStatus, MatchStatus matchStatus, uint variant, uint version, ulong creationTime, ulong lastUpdateTime)
		{
		}

		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x14633D0", Offset = "0x14633D0", VA = "0x14633D0")]
		public Participant GetParticipant(string participantId)
		{
			return null;
		}

		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x14635D4", Offset = "0x14635D4", VA = "0x14635D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
