using System;
using Il2CppDummyDll;

namespace GooglePlayGames.BasicApi
{
	[Token(Token = "0x20002D2")]
	public class Achievement
	{
		[Token(Token = "0x4000D40")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime UnixEpoch;

		[Token(Token = "0x4000D41")]
		[FieldOffset(Offset = "0x10")]
		private string mId;

		[Token(Token = "0x4000D42")]
		[FieldOffset(Offset = "0x18")]
		private bool mIsIncremental;

		[Token(Token = "0x4000D43")]
		[FieldOffset(Offset = "0x19")]
		private bool mIsRevealed;

		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x1A")]
		private bool mIsUnlocked;

		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x1C")]
		private int mCurrentSteps;

		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x20")]
		private int mTotalSteps;

		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x28")]
		private string mDescription;

		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x30")]
		private string mName;

		[Token(Token = "0x4000D49")]
		[FieldOffset(Offset = "0x38")]
		private long mLastModifiedTime;

		[Token(Token = "0x4000D4A")]
		[FieldOffset(Offset = "0x40")]
		private ulong mPoints;

		[Token(Token = "0x4000D4B")]
		[FieldOffset(Offset = "0x48")]
		private string mRevealedImageUrl;

		[Token(Token = "0x4000D4C")]
		[FieldOffset(Offset = "0x50")]
		private string mUnlockedImageUrl;

		[Token(Token = "0x170002B2")]
		public bool IsIncremental
		{
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x146016C", Offset = "0x146016C", VA = "0x146016C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x1460174", Offset = "0x1460174", VA = "0x1460174")]
			set
			{
			}
		}

		[Token(Token = "0x170002B3")]
		public int CurrentSteps
		{
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x1460180", Offset = "0x1460180", VA = "0x1460180")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001646")]
			[Address(RVA = "0x1460188", Offset = "0x1460188", VA = "0x1460188")]
			set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		public int TotalSteps
		{
			[Token(Token = "0x6001647")]
			[Address(RVA = "0x1460190", Offset = "0x1460190", VA = "0x1460190")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001648")]
			[Address(RVA = "0x1460198", Offset = "0x1460198", VA = "0x1460198")]
			set
			{
			}
		}

		[Token(Token = "0x170002B5")]
		public bool IsUnlocked
		{
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x14601A0", Offset = "0x14601A0", VA = "0x14601A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600164A")]
			[Address(RVA = "0x14601A8", Offset = "0x14601A8", VA = "0x14601A8")]
			set
			{
			}
		}

		[Token(Token = "0x170002B6")]
		public bool IsRevealed
		{
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x14601B4", Offset = "0x14601B4", VA = "0x14601B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600164C")]
			[Address(RVA = "0x14601BC", Offset = "0x14601BC", VA = "0x14601BC")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public string Id
		{
			[Token(Token = "0x600164D")]
			[Address(RVA = "0x14601C8", Offset = "0x14601C8", VA = "0x14601C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600164E")]
			[Address(RVA = "0x14601D0", Offset = "0x14601D0", VA = "0x14601D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public string Description
		{
			[Token(Token = "0x600164F")]
			[Address(RVA = "0x14601D8", Offset = "0x14601D8", VA = "0x14601D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001650")]
			[Address(RVA = "0x14601E0", Offset = "0x14601E0", VA = "0x14601E0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		public string Name
		{
			[Token(Token = "0x6001651")]
			[Address(RVA = "0x14601E8", Offset = "0x14601E8", VA = "0x14601E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001652")]
			[Address(RVA = "0x14601F0", Offset = "0x14601F0", VA = "0x14601F0")]
			set
			{
			}
		}

		[Token(Token = "0x170002BA")]
		public DateTime LastModifiedTime
		{
			[Token(Token = "0x6001653")]
			[Address(RVA = "0x14601F8", Offset = "0x14601F8", VA = "0x14601F8")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x1460288", Offset = "0x1460288", VA = "0x1460288")]
			set
			{
			}
		}

		[Token(Token = "0x170002BB")]
		public ulong Points
		{
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x1460350", Offset = "0x1460350", VA = "0x1460350")]
			get
			{
				return default(ulong);
			}
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x1460358", Offset = "0x1460358", VA = "0x1460358")]
			set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		public string RevealedImageUrl
		{
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x1460360", Offset = "0x1460360", VA = "0x1460360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001658")]
			[Address(RVA = "0x1460368", Offset = "0x1460368", VA = "0x1460368")]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		public string UnlockedImageUrl
		{
			[Token(Token = "0x6001659")]
			[Address(RVA = "0x1460370", Offset = "0x1460370", VA = "0x1460370")]
			get
			{
				return null;
			}
			[Token(Token = "0x600165A")]
			[Address(RVA = "0x1460378", Offset = "0x1460378", VA = "0x1460378")]
			set
			{
			}
		}

		[Token(Token = "0x6001641")]
		[Address(RVA = "0x145FD80", Offset = "0x145FD80", VA = "0x145FD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6001642")]
		[Address(RVA = "0x14600F4", Offset = "0x14600F4", VA = "0x14600F4")]
		public Achievement()
		{
		}
	}
}
