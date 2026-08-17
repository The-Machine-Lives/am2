using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002E2")]
	public class LeaderboardScoreData
	{
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x18")]
		private ResponseStatus mStatus;

		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x20")]
		private ulong mApproxCount;

		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x28")]
		private string mTitle;

		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x30")]
		private IScore mPlayerScore;

		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x38")]
		private ScorePageToken mPrevPage;

		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x40")]
		private ScorePageToken mNextPage;

		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScores;

		[Token(Token = "0x170002BE")]
		public bool Valid
		{
			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x14617C0", Offset = "0x14617C0", VA = "0x14617C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002BF")]
		public ResponseStatus Status
		{
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x14617D4", Offset = "0x14617D4", VA = "0x14617D4")]
			get
			{
				return default(ResponseStatus);
			}
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x14617DC", Offset = "0x14617DC", VA = "0x14617DC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C0")]
		public ulong ApproximateCount
		{
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x14617E4", Offset = "0x14617E4", VA = "0x14617E4")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x60016B0")]
			[Address(RVA = "0x14617EC", Offset = "0x14617EC", VA = "0x14617EC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C1")]
		public string Title
		{
			[Token(Token = "0x60016B1")]
			[Address(RVA = "0x14617F4", Offset = "0x14617F4", VA = "0x14617F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x14617FC", Offset = "0x14617FC", VA = "0x14617FC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C2")]
		public string Id
		{
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x1461804", Offset = "0x1461804", VA = "0x1461804")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016B4")]
			[Address(RVA = "0x146180C", Offset = "0x146180C", VA = "0x146180C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C3")]
		public IScore PlayerScore
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x1461814", Offset = "0x1461814", VA = "0x1461814")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x146181C", Offset = "0x146181C", VA = "0x146181C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C4")]
		public IScore[] Scores
		{
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x1461824", Offset = "0x1461824", VA = "0x1461824")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C5")]
		public ScorePageToken PrevPageToken
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x1461918", Offset = "0x1461918", VA = "0x1461918")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x1461920", Offset = "0x1461920", VA = "0x1461920")]
			internal set
			{
			}
		}

		[Token(Token = "0x170002C6")]
		public ScorePageToken NextPageToken
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x1461928", Offset = "0x1461928", VA = "0x1461928")]
			get
			{
				return null;
			}
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x1461930", Offset = "0x1461930", VA = "0x1461930")]
			internal set
			{
			}
		}

		[Token(Token = "0x60016AA")]
		[Address(RVA = "0x146173C", Offset = "0x146173C", VA = "0x146173C")]
		internal LeaderboardScoreData(string leaderboardId)
		{
		}

		[Token(Token = "0x60016AB")]
		[Address(RVA = "0x1460B44", Offset = "0x1460B44", VA = "0x1460B44")]
		internal LeaderboardScoreData(string leaderboardId, ResponseStatus status)
		{
		}

		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x1461884", Offset = "0x1461884", VA = "0x1461884")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x60016BD")]
		[Address(RVA = "0x1461938", Offset = "0x1461938", VA = "0x1461938", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
