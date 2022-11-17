using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200024C")]
	public class PlayGamesLeaderboard : ILeaderboard
	{
		[Token(Token = "0x4000CC5")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000CC6")]
		[FieldOffset(Offset = "0x18")]
		private UserScope mUserScope;

		[Token(Token = "0x4000CC7")]
		[FieldOffset(Offset = "0x1C")]
		private Range mRange;

		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x24")]
		private TimeScope mTimeScope;

		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x28")]
		private string[] mFilteredUserIds;

		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x30")]
		private bool mLoading;

		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x38")]
		private IScore mLocalUserScore;

		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x40")]
		private uint mMaxRange;

		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x48")]
		private List<PlayGamesScore> mScoreList;

		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x50")]
		private string mTitle;

		[Token(Token = "0x17000275")]
		public bool loading
		{
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0xE6F304", Offset = "0xE6F304", VA = "0xE6F304", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0xE6F30C", Offset = "0xE6F30C", VA = "0xE6F30C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000276")]
		public string id
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0xE6F318", Offset = "0xE6F318", VA = "0xE6F318", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0xE6F320", Offset = "0xE6F320", VA = "0xE6F320", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000277")]
		public UserScope userScope
		{
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0xE6F328", Offset = "0xE6F328", VA = "0xE6F328", Slot = "6")]
			get
			{
				return default(UserScope);
			}
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0xE6F330", Offset = "0xE6F330", VA = "0xE6F330", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000278")]
		public Range range
		{
			[Token(Token = "0x60010B1")]
			[Address(RVA = "0xE6F338", Offset = "0xE6F338", VA = "0xE6F338", Slot = "7")]
			get
			{
				return default(Range);
			}
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0xE6F340", Offset = "0xE6F340", VA = "0xE6F340", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000279")]
		public TimeScope timeScope
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0xE6F348", Offset = "0xE6F348", VA = "0xE6F348", Slot = "8")]
			get
			{
				return default(TimeScope);
			}
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0xE6F350", Offset = "0xE6F350", VA = "0xE6F350", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1700027A")]
		public IScore localUserScore
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0xE6F358", Offset = "0xE6F358", VA = "0xE6F358", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027B")]
		public uint maxRange
		{
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0xE6F360", Offset = "0xE6F360", VA = "0xE6F360", Slot = "16")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700027C")]
		public IScore[] scores
		{
			[Token(Token = "0x60010B7")]
			[Address(RVA = "0xE6F368", Offset = "0xE6F368", VA = "0xE6F368", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027D")]
		public string title
		{
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0xE6F414", Offset = "0xE6F414", VA = "0xE6F414", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027E")]
		public int ScoreCount
		{
			[Token(Token = "0x60010BE")]
			[Address(RVA = "0xE6F90C", Offset = "0xE6F90C", VA = "0xE6F90C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60010A8")]
		[Address(RVA = "0xE6E9E4", Offset = "0xE6E9E4", VA = "0xE6E9E4")]
		public PlayGamesLeaderboard(string id)
		{
		}

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0xE6EA68", Offset = "0xE6EA68", VA = "0xE6EA68", Slot = "9")]
		public void SetUserFilter(string[] userIDs)
		{
		}

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0xE6EA70", Offset = "0xE6EA70", VA = "0xE6EA70", Slot = "10")]
		public void LoadScores(Action<bool> callback)
		{
		}

		[Token(Token = "0x60010B9")]
		[Address(RVA = "0xE6F41C", Offset = "0xE6F41C", VA = "0xE6F41C")]
		internal bool SetFromData(LeaderboardScoreData data)
		{
			return default(bool);
		}

		[Token(Token = "0x60010BA")]
		[Address(RVA = "0xE6F724", Offset = "0xE6F724", VA = "0xE6F724")]
		internal void SetMaxRange(ulong val)
		{
		}

		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xE6F72C", Offset = "0xE6F72C", VA = "0xE6F72C")]
		internal void SetTitle(string value)
		{
		}

		[Token(Token = "0x60010BC")]
		[Address(RVA = "0xE6F734", Offset = "0xE6F734", VA = "0xE6F734")]
		internal void SetLocalUserScore(PlayGamesScore score)
		{
		}

		[Token(Token = "0x60010BD")]
		[Address(RVA = "0xE6F73C", Offset = "0xE6F73C", VA = "0xE6F73C")]
		internal int AddScore(PlayGamesScore score)
		{
			return default(int);
		}

		[Token(Token = "0x60010BF")]
		[Address(RVA = "0xE6F858", Offset = "0xE6F858", VA = "0xE6F858")]
		internal bool HasAllScores()
		{
			return default(bool);
		}
	}
}
