using System;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200024F")]
	public class PlayGamesScore : IScore
	{
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x10")]
		private string mLbId;

		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x18")]
		private long mValue;

		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x20")]
		private ulong mRank;

		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x28")]
		private string mPlayerId;

		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x30")]
		private string mMetadata;

		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x38")]
		private DateTime mDate;

		[Token(Token = "0x17000291")]
		public string leaderboardID
		{
			[Token(Token = "0x6001114")]
			[Address(RVA = "0xE757CC", Offset = "0xE757CC", VA = "0xE757CC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001115")]
			[Address(RVA = "0xE75874", Offset = "0xE75874", VA = "0xE75874", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000292")]
		public long value
		{
			[Token(Token = "0x6001116")]
			[Address(RVA = "0xE7587C", Offset = "0xE7587C", VA = "0xE7587C", Slot = "7")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6001117")]
			[Address(RVA = "0xE75884", Offset = "0xE75884", VA = "0xE75884", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000293")]
		public DateTime date
		{
			[Token(Token = "0x6001118")]
			[Address(RVA = "0xE7588C", Offset = "0xE7588C", VA = "0xE7588C", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000294")]
		public string formattedValue
		{
			[Token(Token = "0x6001119")]
			[Address(RVA = "0xE75894", Offset = "0xE75894", VA = "0xE75894", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000295")]
		public string userID
		{
			[Token(Token = "0x600111A")]
			[Address(RVA = "0xE6F904", Offset = "0xE6F904", VA = "0xE6F904", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000296")]
		public int rank
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0xE758A0", Offset = "0xE758A0", VA = "0xE758A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000297")]
		public string metaData
		{
			[Token(Token = "0x600111C")]
			[Address(RVA = "0xE758A8", Offset = "0xE758A8", VA = "0xE758A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001112")]
		[Address(RVA = "0xE5BC4C", Offset = "0xE5BC4C", VA = "0xE5BC4C")]
		internal PlayGamesScore(DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata)
		{
		}

		[Token(Token = "0x6001113")]
		[Address(RVA = "0xE757D4", Offset = "0xE757D4", VA = "0xE757D4", Slot = "4")]
		public void ReportScore(Action<bool> callback)
		{
		}
	}
}
