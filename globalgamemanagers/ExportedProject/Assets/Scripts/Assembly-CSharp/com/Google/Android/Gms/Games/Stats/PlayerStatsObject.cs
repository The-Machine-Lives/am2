using System;
using Google.Developers;
using Il2CppDummyDll;

namespace Com.Google.Android.Gms.Games.Stats
{
	[Token(Token = "0x200023B")]
	public class PlayerStatsObject : JavaObjWrapper, PlayerStats
	{
		[Token(Token = "0x4000CA4")]
		private const string CLASS_NAME = "com/google/android/gms/games/stats/PlayerStats";

		[Token(Token = "0x17000247")]
		public static float UNSET_VALUE
		{
			[Token(Token = "0x6001004")]
			[Address(RVA = "0xA509B0", Offset = "0xA509B0", VA = "0xA509B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000248")]
		public static int CONTENTS_FILE_DESCRIPTOR
		{
			[Token(Token = "0x6001005")]
			[Address(RVA = "0xA50A08", Offset = "0xA50A08", VA = "0xA50A08")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000249")]
		public static int PARCELABLE_WRITE_RETURN_VALUE
		{
			[Token(Token = "0x6001006")]
			[Address(RVA = "0xA50A60", Offset = "0xA50A60", VA = "0xA50A60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6001003")]
		[Address(RVA = "0xA509A8", Offset = "0xA509A8", VA = "0xA509A8")]
		public PlayerStatsObject(IntPtr ptr)
		{
		}

		[Token(Token = "0x6001007")]
		[Address(RVA = "0xA50AB8", Offset = "0xA50AB8", VA = "0xA50AB8", Slot = "5")]
		public float getAverageSessionLength()
		{
			return default(float);
		}

		[Token(Token = "0x6001008")]
		[Address(RVA = "0xA50B34", Offset = "0xA50B34", VA = "0xA50B34", Slot = "6")]
		public float getChurnProbability()
		{
			return default(float);
		}

		[Token(Token = "0x6001009")]
		[Address(RVA = "0xA50BB0", Offset = "0xA50BB0", VA = "0xA50BB0", Slot = "7")]
		public int getDaysSinceLastPlayed()
		{
			return default(int);
		}

		[Token(Token = "0x600100A")]
		[Address(RVA = "0xA50C2C", Offset = "0xA50C2C", VA = "0xA50C2C", Slot = "8")]
		public int getNumberOfPurchases()
		{
			return default(int);
		}

		[Token(Token = "0x600100B")]
		[Address(RVA = "0xA50CA8", Offset = "0xA50CA8", VA = "0xA50CA8", Slot = "9")]
		public int getNumberOfSessions()
		{
			return default(int);
		}

		[Token(Token = "0x600100C")]
		[Address(RVA = "0xA50D24", Offset = "0xA50D24", VA = "0xA50D24", Slot = "10")]
		public float getSessionPercentile()
		{
			return default(float);
		}

		[Token(Token = "0x600100D")]
		[Address(RVA = "0xA50DA0", Offset = "0xA50DA0", VA = "0xA50DA0", Slot = "11")]
		public float getSpendPercentile()
		{
			return default(float);
		}

		[Token(Token = "0x600100E")]
		[Address(RVA = "0xA50E1C", Offset = "0xA50E1C", VA = "0xA50E1C", Slot = "12")]
		public float getSpendProbability()
		{
			return default(float);
		}

		[Token(Token = "0x600100F")]
		[Address(RVA = "0xA50E98", Offset = "0xA50E98", VA = "0xA50E98", Slot = "13")]
		public float getHighSpenderProbability()
		{
			return default(float);
		}

		[Token(Token = "0x6001010")]
		[Address(RVA = "0xA50F14", Offset = "0xA50F14", VA = "0xA50F14", Slot = "14")]
		public float getTotalSpendNext28Days()
		{
			return default(float);
		}
	}
}
