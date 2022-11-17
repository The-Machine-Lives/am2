using System;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	[Token(Token = "0x200024B")]
	internal class PlayGamesAchievement : IAchievement, IAchievementDescription
	{
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x10")]
		private readonly ReportProgress mProgressCallback;

		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x18")]
		private string mId;

		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x20")]
		private bool mIsIncremental;

		[Token(Token = "0x4000CB8")]
		[FieldOffset(Offset = "0x24")]
		private int mCurrentSteps;

		[Token(Token = "0x4000CB9")]
		[FieldOffset(Offset = "0x28")]
		private int mTotalSteps;

		[Token(Token = "0x4000CBA")]
		[FieldOffset(Offset = "0x30")]
		private double mPercentComplete;

		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x38")]
		private bool mCompleted;

		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x39")]
		private bool mHidden;

		[Token(Token = "0x4000CBD")]
		[FieldOffset(Offset = "0x40")]
		private DateTime mLastModifiedTime;

		[Token(Token = "0x4000CBE")]
		[FieldOffset(Offset = "0x48")]
		private string mTitle;

		[Token(Token = "0x4000CBF")]
		[FieldOffset(Offset = "0x50")]
		private string mRevealedImageUrl;

		[Token(Token = "0x4000CC0")]
		[FieldOffset(Offset = "0x58")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x4000CC1")]
		[FieldOffset(Offset = "0x60")]
		private UnityWebRequest mImageFetcher;

		[Token(Token = "0x4000CC2")]
		[FieldOffset(Offset = "0x68")]
		private Texture2D mImage;

		[Token(Token = "0x4000CC3")]
		[FieldOffset(Offset = "0x70")]
		private string mDescription;

		[Token(Token = "0x4000CC4")]
		[FieldOffset(Offset = "0x78")]
		private ulong mPoints;

		[Token(Token = "0x17000268")]
		public string id
		{
			[Token(Token = "0x6001099")]
			[Address(RVA = "0xE6E850", Offset = "0xE6E850", VA = "0xE6E850", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600109A")]
			[Address(RVA = "0xE6E858", Offset = "0xE6E858", VA = "0xE6E858", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		public bool isIncremental
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0xE6E860", Offset = "0xE6E860", VA = "0xE6E860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026A")]
		public int currentSteps
		{
			[Token(Token = "0x600109C")]
			[Address(RVA = "0xE6E868", Offset = "0xE6E868", VA = "0xE6E868")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700026B")]
		public int totalSteps
		{
			[Token(Token = "0x600109D")]
			[Address(RVA = "0xE6E870", Offset = "0xE6E870", VA = "0xE6E870")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700026C")]
		public double percentCompleted
		{
			[Token(Token = "0x600109E")]
			[Address(RVA = "0xE6E878", Offset = "0xE6E878", VA = "0xE6E878", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600109F")]
			[Address(RVA = "0xE6E880", Offset = "0xE6E880", VA = "0xE6E880", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		public bool completed
		{
			[Token(Token = "0x60010A0")]
			[Address(RVA = "0xE6E848", Offset = "0xE6E848", VA = "0xE6E848", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026E")]
		public bool hidden
		{
			[Token(Token = "0x60010A1")]
			[Address(RVA = "0xE6E840", Offset = "0xE6E840", VA = "0xE6E840", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700026F")]
		public DateTime lastReportedDate
		{
			[Token(Token = "0x60010A2")]
			[Address(RVA = "0xE6E888", Offset = "0xE6E888", VA = "0xE6E888", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000270")]
		public string title
		{
			[Token(Token = "0x60010A3")]
			[Address(RVA = "0xE6E890", Offset = "0xE6E890", VA = "0xE6E890", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000271")]
		public Texture2D image
		{
			[Token(Token = "0x60010A4")]
			[Address(RVA = "0xE6E898", Offset = "0xE6E898", VA = "0xE6E898", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000272")]
		public string achievedDescription
		{
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0xE6E89C", Offset = "0xE6E89C", VA = "0xE6E89C", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000273")]
		public string unachievedDescription
		{
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0xE6E8A4", Offset = "0xE6E8A4", VA = "0xE6E8A4", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000274")]
		public int points
		{
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0xE6E8AC", Offset = "0xE6E8AC", VA = "0xE6E8AC", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0xE6D928", Offset = "0xE6D928", VA = "0xE6D928")]
		internal PlayGamesAchievement()
		{
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0xE6DB2C", Offset = "0xE6DB2C", VA = "0xE6DB2C")]
		internal PlayGamesAchievement(ReportProgress progressCallback)
		{
		}

		[Token(Token = "0x6001096")]
		[Address(RVA = "0xE6DC10", Offset = "0xE6DC10", VA = "0xE6DC10")]
		internal PlayGamesAchievement(Achievement ach)
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0xE6DEF0", Offset = "0xE6DEF0", VA = "0xE6DEF0", Slot = "4")]
		public void ReportProgress(Action<bool> callback)
		{
		}

		[Token(Token = "0x6001098")]
		[Address(RVA = "0xE6E6FC", Offset = "0xE6E6FC", VA = "0xE6E6FC")]
		private Texture2D LoadImage()
		{
			return null;
		}
	}
}
