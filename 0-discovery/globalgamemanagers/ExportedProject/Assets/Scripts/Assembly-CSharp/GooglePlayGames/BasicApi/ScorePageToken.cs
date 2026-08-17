using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002E5")]
	public class ScorePageToken
	{
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x18")]
		private object mInternalObject;

		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x20")]
		private LeaderboardCollection mCollection;

		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x24")]
		private LeaderboardTimeSpan mTimespan;

		[Token(Token = "0x170002DC")]
		public LeaderboardCollection Collection
		{
			[Token(Token = "0x60016EC")]
			[Address(RVA = "0x14661D0", Offset = "0x14661D0", VA = "0x14661D0")]
			get
			{
				return default(LeaderboardCollection);
			}
		}

		[Token(Token = "0x170002DD")]
		public LeaderboardTimeSpan TimeSpan
		{
			[Token(Token = "0x60016ED")]
			[Address(RVA = "0x14661D8", Offset = "0x14661D8", VA = "0x14661D8")]
			get
			{
				return default(LeaderboardTimeSpan);
			}
		}

		[Token(Token = "0x170002DE")]
		public string LeaderboardId
		{
			[Token(Token = "0x60016EE")]
			[Address(RVA = "0x1460C78", Offset = "0x1460C78", VA = "0x1460C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002DF")]
		internal object InternalObject
		{
			[Token(Token = "0x60016EF")]
			[Address(RVA = "0x14661E0", Offset = "0x14661E0", VA = "0x14661E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60016EB")]
		[Address(RVA = "0x1466184", Offset = "0x1466184", VA = "0x1466184")]
		internal ScorePageToken(object internalObject, string id, LeaderboardCollection collection, LeaderboardTimeSpan timespan)
		{
		}
	}
}
