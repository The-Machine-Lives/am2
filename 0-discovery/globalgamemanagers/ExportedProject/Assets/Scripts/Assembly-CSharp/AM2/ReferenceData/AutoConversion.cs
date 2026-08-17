using System;
using Il2CppDummyDll;
using Uken.Framework.Casual;

namespace AM2.ReferenceData
{
	[Token(Token = "0x2000350")]
	public class AutoConversion : RuntimeData<RDAutoConversion>, IEquatable<AutoConversion>, IComparable<AutoConversion>
	{
		[Token(Token = "0x17000433")]
		public string inputItemRef
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x9AC2DC", Offset = "0x9AC2DC", VA = "0x9AC2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000434")]
		public string outputItemRef
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x9AC308", Offset = "0x9AC308", VA = "0x9AC308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000435")]
		public double conversionRate
		{
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x9AC334", Offset = "0x9AC334", VA = "0x9AC334")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000436")]
		public long amountToLeave
		{
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x9AC360", Offset = "0x9AC360", VA = "0x9AC360")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000437")]
		private sbyte orderPriority
		{
			[Token(Token = "0x6001A34")]
			[Address(RVA = "0x9AC38C", Offset = "0x9AC38C", VA = "0x9AC38C")]
			get
			{
				return default(sbyte);
			}
		}

		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x9AC3B8", Offset = "0x9AC3B8", VA = "0x9AC3B8")]
		public AutoConversion()
		{
		}

		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x9AC408", Offset = "0x9AC408", VA = "0x9AC408", Slot = "6")]
		public bool Equals(AutoConversion other)
		{
			return default(bool);
		}

		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x9AC460", Offset = "0x9AC460", VA = "0x9AC460", Slot = "7")]
		public int CompareTo(AutoConversion other)
		{
			return default(int);
		}
	}
}
