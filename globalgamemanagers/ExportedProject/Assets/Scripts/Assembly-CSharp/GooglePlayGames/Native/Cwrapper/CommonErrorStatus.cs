using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002A1")]
	internal static class CommonErrorStatus
	{
		[Token(Token = "0x2000739")]
		internal enum ResponseStatus
		{
			[Token(Token = "0x400211E")]
			VALID = 1,
			[Token(Token = "0x400211F")]
			VALID_BUT_STALE = 2,
			[Token(Token = "0x4002120")]
			ERROR_LICENSE_CHECK_FAILED = -1,
			[Token(Token = "0x4002121")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002122")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002123")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002124")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200073A")]
		internal enum FlushStatus
		{
			[Token(Token = "0x4002126")]
			FLUSHED = 4,
			[Token(Token = "0x4002127")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002128")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002129")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x400212A")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200073B")]
		internal enum AuthStatus
		{
			[Token(Token = "0x400212C")]
			VALID = 1,
			[Token(Token = "0x400212D")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400212E")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400212F")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002130")]
			ERROR_TIMEOUT = -5
		}

		[Token(Token = "0x200073C")]
		internal enum UIStatus
		{
			[Token(Token = "0x4002132")]
			VALID = 1,
			[Token(Token = "0x4002133")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002134")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002135")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002136")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x4002137")]
			ERROR_CANCELED = -6,
			[Token(Token = "0x4002138")]
			ERROR_UI_BUSY = -12,
			[Token(Token = "0x4002139")]
			ERROR_LEFT_ROOM = -18
		}

		[Token(Token = "0x200073D")]
		internal enum MultiplayerStatus
		{
			[Token(Token = "0x400213B")]
			VALID = 1,
			[Token(Token = "0x400213C")]
			VALID_BUT_STALE = 2,
			[Token(Token = "0x400213D")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400213E")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400213F")]
			ERROR_VERSION_UPDATE_REQUIRED = -4,
			[Token(Token = "0x4002140")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x4002141")]
			ERROR_MATCH_ALREADY_REMATCHED = -7,
			[Token(Token = "0x4002142")]
			ERROR_INACTIVE_MATCH = -8,
			[Token(Token = "0x4002143")]
			ERROR_INVALID_RESULTS = -9,
			[Token(Token = "0x4002144")]
			ERROR_INVALID_MATCH = -10,
			[Token(Token = "0x4002145")]
			ERROR_MATCH_OUT_OF_DATE = -11,
			[Token(Token = "0x4002146")]
			ERROR_REAL_TIME_ROOM_NOT_JOINED = -17
		}

		[Token(Token = "0x200073E")]
		internal enum QuestAcceptStatus
		{
			[Token(Token = "0x4002148")]
			VALID = 1,
			[Token(Token = "0x4002149")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x400214A")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400214B")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x400214C")]
			ERROR_QUEST_NO_LONGER_AVAILABLE = -13,
			[Token(Token = "0x400214D")]
			ERROR_QUEST_NOT_STARTED = -14
		}

		[Token(Token = "0x200073F")]
		internal enum QuestClaimMilestoneStatus
		{
			[Token(Token = "0x400214F")]
			VALID = 1,
			[Token(Token = "0x4002150")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002151")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x4002152")]
			ERROR_TIMEOUT = -5,
			[Token(Token = "0x4002153")]
			ERROR_MILESTONE_ALREADY_CLAIMED = -15,
			[Token(Token = "0x4002154")]
			ERROR_MILESTONE_CLAIM_FAILED = -16
		}

		[Token(Token = "0x2000740")]
		internal enum SnapshotOpenStatus
		{
			[Token(Token = "0x4002156")]
			VALID = 1,
			[Token(Token = "0x4002157")]
			VALID_WITH_CONFLICT = 3,
			[Token(Token = "0x4002158")]
			ERROR_INTERNAL = -2,
			[Token(Token = "0x4002159")]
			ERROR_NOT_AUTHORIZED = -3,
			[Token(Token = "0x400215A")]
			ERROR_TIMEOUT = -5
		}
	}
}
