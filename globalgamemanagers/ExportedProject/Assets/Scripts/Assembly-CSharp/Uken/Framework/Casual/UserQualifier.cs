using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200056D")]
	public class UserQualifier
	{
		[Token(Token = "0x40019E2")]
		[FieldOffset(Offset = "0x10")]
		public QualifierComparison comparisonFunction;

		[Token(Token = "0x40019E3")]
		[FieldOffset(Offset = "0x14")]
		public QualifierData comparisonData;

		[Token(Token = "0x40019E4")]
		[FieldOffset(Offset = "0x18")]
		public long longValue;

		[Token(Token = "0x40019E5")]
		[FieldOffset(Offset = "0x20")]
		public double doubleValue;

		[Token(Token = "0x40019E6")]
		[FieldOffset(Offset = "0x28")]
		public string stringValue;

		[Token(Token = "0x40019E7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "MultiEntityReference", RVA = "0x832900", Offset = "0x832900")]
		public string itemReference;

		[Token(Token = "0x6002989")]
		[Address(RVA = "0xA9F48C", Offset = "0xA9F48C", VA = "0xA9F48C")]
		public bool Evaluates(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x600298A")]
		[Address(RVA = "0xA9F4A8", Offset = "0xA9F4A8", VA = "0xA9F4A8")]
		protected bool EvaluateByComparitor(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x600298B")]
		[Address(RVA = "0xA9F678", Offset = "0xA9F678", VA = "0xA9F678", Slot = "4")]
		protected virtual bool GetBool(UserProfiler user, out bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x600298C")]
		[Address(RVA = "0xA9F6CC", Offset = "0xA9F6CC", VA = "0xA9F6CC", Slot = "5")]
		protected virtual bool GetInt(UserProfiler user, out int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600298D")]
		[Address(RVA = "0xA9F708", Offset = "0xA9F708", VA = "0xA9F708", Slot = "6")]
		protected virtual bool GetLong(UserProfiler user, out long value)
		{
			return default(bool);
		}

		[Token(Token = "0x600298E")]
		[Address(RVA = "0xA9F910", Offset = "0xA9F910", VA = "0xA9F910", Slot = "7")]
		protected virtual bool GetDouble(UserProfiler user, out double value)
		{
			return default(bool);
		}

		[Token(Token = "0x600298F")]
		[Address(RVA = "0xA9FBCC", Offset = "0xA9FBCC", VA = "0xA9FBCC", Slot = "8")]
		protected virtual bool GetFloat(UserProfiler user, out float value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002990")]
		[Address(RVA = "0xA9FC0C", Offset = "0xA9FC0C", VA = "0xA9FC0C", Slot = "9")]
		protected virtual bool GetString(UserProfiler user, out string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002991")]
		[Address(RVA = "0xA9F5C4", Offset = "0xA9F5C4", VA = "0xA9F5C4")]
		protected bool EvaluateValue(UserProfiler user)
		{
			return default(bool);
		}

		[Token(Token = "0x6002992")]
		[Address(RVA = "0xA9FF24", Offset = "0xA9FF24", VA = "0xA9FF24")]
		protected bool EvaluateString(UserProfiler user, string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002993")]
		[Address(RVA = "0xA9FFCC", Offset = "0xA9FFCC", VA = "0xA9FFCC")]
		protected bool EvaluateInt(UserProfiler user, int value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002994")]
		[Address(RVA = "0xA9FE04", Offset = "0xA9FE04", VA = "0xA9FE04")]
		protected bool EvaluateLong(UserProfiler user, long value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002995")]
		[Address(RVA = "0xAA0010", Offset = "0xAA0010", VA = "0xAA0010")]
		protected bool EvaluateFloat(UserProfiler user, float value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002996")]
		[Address(RVA = "0xA9FE90", Offset = "0xA9FE90", VA = "0xA9FE90")]
		protected bool EvaluateDouble(UserProfiler user, double value)
		{
			return default(bool);
		}

		[Token(Token = "0x6002997")]
		[Address(RVA = "0xAA00CC", Offset = "0xAA00CC", VA = "0xAA00CC")]
		public UserQualifier()
		{
		}
	}
}
