using System;
using Com.Google.Android.Gms.Common.Api;
using Com.Google.Android.Gms.Games.Stats;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games
{
	[Token(Token = "0x2000237")]
	public class Games : JavaObjWrapper
	{
		[Token(Token = "0x4000CA1")]
		private const string CLASS_NAME = "com/google/android/gms/games/Games";

		[Token(Token = "0x17000238")]
		public static string EXTRA_PLAYER_IDS
		{
			[Token(Token = "0x6000FDE")]
			[Address(RVA = "0xA4FCA4", Offset = "0xA4FCA4", VA = "0xA4FCA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		public static string EXTRA_STATUS
		{
			[Token(Token = "0x6000FDF")]
			[Address(RVA = "0xA4FCFC", Offset = "0xA4FCFC", VA = "0xA4FCFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023A")]
		public static object SCOPE_GAMES
		{
			[Token(Token = "0x6000FE0")]
			[Address(RVA = "0xA4FD54", Offset = "0xA4FD54", VA = "0xA4FD54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023B")]
		public static object API
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0xA4FDC0", Offset = "0xA4FDC0", VA = "0xA4FDC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023C")]
		public static object GamesMetadata
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0xA4FE2C", Offset = "0xA4FE2C", VA = "0xA4FE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023D")]
		public static object Achievements
		{
			[Token(Token = "0x6000FE3")]
			[Address(RVA = "0xA4FE98", Offset = "0xA4FE98", VA = "0xA4FE98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023E")]
		public static object Events
		{
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0xA4FF04", Offset = "0xA4FF04", VA = "0xA4FF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023F")]
		public static object Leaderboards
		{
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0xA4FF70", Offset = "0xA4FF70", VA = "0xA4FF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000240")]
		public static object Invitations
		{
			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0xA4FFDC", Offset = "0xA4FFDC", VA = "0xA4FFDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000241")]
		public static object TurnBasedMultiplayer
		{
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0xA50048", Offset = "0xA50048", VA = "0xA50048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000242")]
		public static object RealTimeMultiplayer
		{
			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0xA500B4", Offset = "0xA500B4", VA = "0xA500B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000243")]
		public static object Players
		{
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0xA50120", Offset = "0xA50120", VA = "0xA50120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000244")]
		public static object Notifications
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0xA5018C", Offset = "0xA5018C", VA = "0xA5018C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000245")]
		public static object Snapshots
		{
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0xA501F8", Offset = "0xA501F8", VA = "0xA501F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000246")]
		public static StatsObject Stats
		{
			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0xA50264", Offset = "0xA50264", VA = "0xA50264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0xA4FC9C", Offset = "0xA4FC9C", VA = "0xA4FC9C")]
		public Games(IntPtr ptr)
		{
		}

		[Token(Token = "0x6000FED")]
		[Address(RVA = "0xA502D0", Offset = "0xA502D0", VA = "0xA502D0")]
		public static string getAppId(GoogleApiClient arg_GoogleApiClient_1)
		{
			return null;
		}

		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0xA503B0", Offset = "0xA503B0", VA = "0xA503B0")]
		public static string getCurrentAccountName(GoogleApiClient arg_GoogleApiClient_1)
		{
			return null;
		}

		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0xA50490", Offset = "0xA50490", VA = "0xA50490")]
		public static int getSdkVariant(GoogleApiClient arg_GoogleApiClient_1)
		{
			return default(int);
		}

		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0xA50570", Offset = "0xA50570", VA = "0xA50570")]
		public static object getSettingsIntent(GoogleApiClient arg_GoogleApiClient_1)
		{
			return null;
		}

		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0xA50650", Offset = "0xA50650", VA = "0xA50650")]
		public static void setGravityForPopups(GoogleApiClient arg_GoogleApiClient_1, int arg_int_2)
		{
		}

		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0xA5079C", Offset = "0xA5079C", VA = "0xA5079C")]
		public static void setViewForPopups(GoogleApiClient arg_GoogleApiClient_1, object arg_object_2)
		{
		}

		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0xA508C8", Offset = "0xA508C8", VA = "0xA508C8")]
		public static PendingResult<Status> signOut(GoogleApiClient arg_GoogleApiClient_1)
		{
			return null;
		}
	}
}
