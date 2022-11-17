using Il2CppDummyDll;

namespace GooglePlayGames.Native.Cwrapper
{
	[Token(Token = "0x20002C8")]
	internal static class Types
	{
		[Token(Token = "0x2000778")]
		internal enum DataSource
		{
			[Token(Token = "0x400219B")]
			CACHE_OR_NETWORK = 1,
			[Token(Token = "0x400219C")]
			NETWORK_ONLY = 2
		}

		[Token(Token = "0x2000779")]
		internal enum LogLevel
		{
			[Token(Token = "0x400219E")]
			VERBOSE = 1,
			[Token(Token = "0x400219F")]
			INFO = 2,
			[Token(Token = "0x40021A0")]
			WARNING = 3,
			[Token(Token = "0x40021A1")]
			ERROR = 4
		}

		[Token(Token = "0x200077A")]
		internal enum AuthOperation
		{
			[Token(Token = "0x40021A3")]
			SIGN_IN = 1,
			[Token(Token = "0x40021A4")]
			SIGN_OUT = 2
		}

		[Token(Token = "0x200077B")]
		internal enum ImageResolution
		{
			[Token(Token = "0x40021A6")]
			ICON = 1,
			[Token(Token = "0x40021A7")]
			HI_RES = 2
		}

		[Token(Token = "0x200077C")]
		internal enum AchievementType
		{
			[Token(Token = "0x40021A9")]
			STANDARD = 1,
			[Token(Token = "0x40021AA")]
			INCREMENTAL = 2
		}

		[Token(Token = "0x200077D")]
		internal enum AchievementState
		{
			[Token(Token = "0x40021AC")]
			HIDDEN = 1,
			[Token(Token = "0x40021AD")]
			REVEALED = 2,
			[Token(Token = "0x40021AE")]
			UNLOCKED = 3
		}

		[Token(Token = "0x200077E")]
		internal enum EventVisibility
		{
			[Token(Token = "0x40021B0")]
			HIDDEN = 1,
			[Token(Token = "0x40021B1")]
			REVEALED = 2
		}

		[Token(Token = "0x200077F")]
		internal enum LeaderboardOrder
		{
			[Token(Token = "0x40021B3")]
			LARGER_IS_BETTER = 1,
			[Token(Token = "0x40021B4")]
			SMALLER_IS_BETTER = 2
		}

		[Token(Token = "0x2000780")]
		internal enum LeaderboardStart
		{
			[Token(Token = "0x40021B6")]
			TOP_SCORES = 1,
			[Token(Token = "0x40021B7")]
			PLAYER_CENTERED = 2
		}

		[Token(Token = "0x2000781")]
		internal enum LeaderboardTimeSpan
		{
			[Token(Token = "0x40021B9")]
			DAILY = 1,
			[Token(Token = "0x40021BA")]
			WEEKLY = 2,
			[Token(Token = "0x40021BB")]
			ALL_TIME = 3
		}

		[Token(Token = "0x2000782")]
		internal enum LeaderboardCollection
		{
			[Token(Token = "0x40021BD")]
			PUBLIC = 1,
			[Token(Token = "0x40021BE")]
			SOCIAL = 2
		}

		[Token(Token = "0x2000783")]
		internal enum ParticipantStatus
		{
			[Token(Token = "0x40021C0")]
			INVITED = 1,
			[Token(Token = "0x40021C1")]
			JOINED = 2,
			[Token(Token = "0x40021C2")]
			DECLINED = 3,
			[Token(Token = "0x40021C3")]
			LEFT = 4,
			[Token(Token = "0x40021C4")]
			NOT_INVITED_YET = 5,
			[Token(Token = "0x40021C5")]
			FINISHED = 6,
			[Token(Token = "0x40021C6")]
			UNRESPONSIVE = 7
		}

		[Token(Token = "0x2000784")]
		internal enum MatchResult
		{
			[Token(Token = "0x40021C8")]
			DISAGREED = 1,
			[Token(Token = "0x40021C9")]
			DISCONNECTED = 2,
			[Token(Token = "0x40021CA")]
			LOSS = 3,
			[Token(Token = "0x40021CB")]
			NONE = 4,
			[Token(Token = "0x40021CC")]
			TIE = 5,
			[Token(Token = "0x40021CD")]
			WIN = 6
		}

		[Token(Token = "0x2000785")]
		internal enum MatchStatus
		{
			[Token(Token = "0x40021CF")]
			INVITED = 1,
			[Token(Token = "0x40021D0")]
			THEIR_TURN = 2,
			[Token(Token = "0x40021D1")]
			MY_TURN = 3,
			[Token(Token = "0x40021D2")]
			PENDING_COMPLETION = 4,
			[Token(Token = "0x40021D3")]
			COMPLETED = 5,
			[Token(Token = "0x40021D4")]
			CANCELED = 6,
			[Token(Token = "0x40021D5")]
			EXPIRED = 7
		}

		[Token(Token = "0x2000786")]
		internal enum MultiplayerEvent
		{
			[Token(Token = "0x40021D7")]
			UPDATED = 1,
			[Token(Token = "0x40021D8")]
			UPDATED_FROM_APP_LAUNCH = 2,
			[Token(Token = "0x40021D9")]
			REMOVED = 3
		}

		[Token(Token = "0x2000787")]
		internal enum MultiplayerInvitationType
		{
			[Token(Token = "0x40021DB")]
			TURN_BASED = 1,
			[Token(Token = "0x40021DC")]
			REAL_TIME = 2
		}

		[Token(Token = "0x2000788")]
		internal enum RealTimeRoomStatus
		{
			[Token(Token = "0x40021DE")]
			INVITING = 1,
			[Token(Token = "0x40021DF")]
			CONNECTING = 2,
			[Token(Token = "0x40021E0")]
			AUTO_MATCHING = 3,
			[Token(Token = "0x40021E1")]
			ACTIVE = 4,
			[Token(Token = "0x40021E2")]
			DELETED = 5
		}

		[Token(Token = "0x2000789")]
		internal enum SnapshotConflictPolicy
		{
			[Token(Token = "0x40021E4")]
			MANUAL = 1,
			[Token(Token = "0x40021E5")]
			LONGEST_PLAYTIME = 2,
			[Token(Token = "0x40021E6")]
			LAST_KNOWN_GOOD = 3,
			[Token(Token = "0x40021E7")]
			MOST_RECENTLY_MODIFIED = 4
		}

		[Token(Token = "0x200078A")]
		internal enum VideoCaptureMode
		{
			[Token(Token = "0x40021E9")]
			UNKNOWN = -1,
			[Token(Token = "0x40021EA")]
			FILE = 0,
			[Token(Token = "0x40021EB")]
			STREAM = 1
		}

		[Token(Token = "0x200078B")]
		internal enum VideoQualityLevel
		{
			[Token(Token = "0x40021ED")]
			UNKNOWN = -1,
			[Token(Token = "0x40021EE")]
			SD = 0,
			[Token(Token = "0x40021EF")]
			HD = 1,
			[Token(Token = "0x40021F0")]
			XHD = 2,
			[Token(Token = "0x40021F1")]
			FULLHD = 3
		}

		[Token(Token = "0x200078C")]
		internal enum VideoCaptureOverlayState
		{
			[Token(Token = "0x40021F3")]
			UNKNOWN = -1,
			[Token(Token = "0x40021F4")]
			SHOWN = 1,
			[Token(Token = "0x40021F5")]
			STARTED = 2,
			[Token(Token = "0x40021F6")]
			STOPPED = 3,
			[Token(Token = "0x40021F7")]
			DISMISSED = 4
		}
	}
}
