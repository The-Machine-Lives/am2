using System;
using System.Runtime.InteropServices;
using GooglePlayGames.BasicApi;
using Il2CppDummyDll;

namespace GooglePlayGames.Native.PInvoke
{
	[Token(Token = "0x200027B")]
	internal class NativePlayerStats : BaseReferenceHolder
	{
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0xE5B1BC", Offset = "0xE5B1BC", VA = "0xE5B1BC")]
		internal NativePlayerStats(IntPtr selfPointer)
		{
		}

		[Token(Token = "0x60012DE")]
		[Address(RVA = "0xE5B234", Offset = "0xE5B234", VA = "0xE5B234")]
		internal bool Valid()
		{
			return default(bool);
		}

		[Token(Token = "0x60012DF")]
		[Address(RVA = "0xE5B250", Offset = "0xE5B250", VA = "0xE5B250")]
		internal bool HasAverageSessionLength()
		{
			return default(bool);
		}

		[Token(Token = "0x60012E0")]
		[Address(RVA = "0xE5B26C", Offset = "0xE5B26C", VA = "0xE5B26C")]
		internal float AverageSessionLength()
		{
			return default(float);
		}

		[Token(Token = "0x60012E1")]
		[Address(RVA = "0xE5B288", Offset = "0xE5B288", VA = "0xE5B288")]
		internal bool HasChurnProbability()
		{
			return default(bool);
		}

		[Token(Token = "0x60012E2")]
		[Address(RVA = "0xE5B2A4", Offset = "0xE5B2A4", VA = "0xE5B2A4")]
		internal float ChurnProbability()
		{
			return default(float);
		}

		[Token(Token = "0x60012E3")]
		[Address(RVA = "0xE5B2C0", Offset = "0xE5B2C0", VA = "0xE5B2C0")]
		internal bool HasDaysSinceLastPlayed()
		{
			return default(bool);
		}

		[Token(Token = "0x60012E4")]
		[Address(RVA = "0xE5B2DC", Offset = "0xE5B2DC", VA = "0xE5B2DC")]
		internal int DaysSinceLastPlayed()
		{
			return default(int);
		}

		[Token(Token = "0x60012E5")]
		[Address(RVA = "0xE5B2F8", Offset = "0xE5B2F8", VA = "0xE5B2F8")]
		internal bool HasNumberOfPurchases()
		{
			return default(bool);
		}

		[Token(Token = "0x60012E6")]
		[Address(RVA = "0xE5B314", Offset = "0xE5B314", VA = "0xE5B314")]
		internal int NumberOfPurchases()
		{
			return default(int);
		}

		[Token(Token = "0x60012E7")]
		[Address(RVA = "0xE5B330", Offset = "0xE5B330", VA = "0xE5B330")]
		internal bool HasNumberOfSessions()
		{
			return default(bool);
		}

		[Token(Token = "0x60012E8")]
		[Address(RVA = "0xE5B34C", Offset = "0xE5B34C", VA = "0xE5B34C")]
		internal int NumberOfSessions()
		{
			return default(int);
		}

		[Token(Token = "0x60012E9")]
		[Address(RVA = "0xE5B368", Offset = "0xE5B368", VA = "0xE5B368")]
		internal bool HasSessionPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x60012EA")]
		[Address(RVA = "0xE5B384", Offset = "0xE5B384", VA = "0xE5B384")]
		internal float SessionPercentile()
		{
			return default(float);
		}

		[Token(Token = "0x60012EB")]
		[Address(RVA = "0xE5B3A0", Offset = "0xE5B3A0", VA = "0xE5B3A0")]
		internal bool HasSpendPercentile()
		{
			return default(bool);
		}

		[Token(Token = "0x60012EC")]
		[Address(RVA = "0xE5B3BC", Offset = "0xE5B3BC", VA = "0xE5B3BC")]
		internal float SpendPercentile()
		{
			return default(float);
		}

		[Token(Token = "0x60012ED")]
		[Address(RVA = "0xE5B3D8", Offset = "0xE5B3D8", VA = "0xE5B3D8", Slot = "5")]
		protected override void CallDispose(HandleRef selfPointer)
		{
		}

		[Token(Token = "0x60012EE")]
		[Address(RVA = "0xE5B3E8", Offset = "0xE5B3E8", VA = "0xE5B3E8")]
		internal PlayerStats AsPlayerStats()
		{
			return null;
		}
	}
}
