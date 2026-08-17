using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200005A")]
	[Preserve]
	internal static class ConvertUtils
	{
		[Token(Token = "0x200005B")]
		internal struct TypeConvertKey
		{
			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x0")]
			private readonly Type _initialType;

			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x8")]
			private readonly Type _targetType;

			[Token(Token = "0x17000066")]
			public Type InitialType
			{
				[Token(Token = "0x600024F")]
				[Address(RVA = "0x8B6244", Offset = "0x8B6244", VA = "0x8B6244")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			public Type TargetType
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x8B624C", Offset = "0x8B624C", VA = "0x8B624C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000251")]
			[Address(RVA = "0x8B6254", Offset = "0x8B6254", VA = "0x8B6254")]
			public TypeConvertKey(Type initialType, Type targetType)
			{
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x8B625C", Offset = "0x8B625C", VA = "0x8B625C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x8B6264", Offset = "0x8B6264", VA = "0x8B6264", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000254")]
			[Address(RVA = "0x8B626C", Offset = "0x8B626C", VA = "0x8B626C")]
			public bool Equals(TypeConvertKey other)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200005C")]
		internal enum ConvertResult
		{
			[Token(Token = "0x40001C3")]
			Success = 0,
			[Token(Token = "0x40001C4")]
			CannotConvertNull = 1,
			[Token(Token = "0x40001C5")]
			NotInstantiableType = 2,
			[Token(Token = "0x40001C6")]
			NoValidConversion = 3
		}

		[Token(Token = "0x200005D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80E758", Offset = "0x80E758")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x10")]
			public MethodCall<object, object> call;

			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1765360", Offset = "0x1765360", VA = "0x1765360")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1765368", Offset = "0x1765368", VA = "0x1765368")]
			internal object _003CCreateCastConverter_003Eb__0(object o)
			{
				return null;
			}
		}

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly ThreadSafeStore<TypeConvertKey, Func<object, object>> CastConverters;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xF0A918", Offset = "0xF0A918", VA = "0xF0A918")]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return default(PrimitiveTypeCode);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xF0A990", Offset = "0xF0A990", VA = "0xF0A990")]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return default(PrimitiveTypeCode);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xF0AC1C", Offset = "0xF0AC1C", VA = "0xF0AC1C")]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xF0AD34", Offset = "0xF0AD34", VA = "0xF0AD34")]
		public static bool IsConvertible(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xF0ADCC", Offset = "0xF0ADCC", VA = "0xF0ADCC")]
		public static TimeSpan ParseTimeSpan(string input)
		{
			return default(TimeSpan);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xF0AE34", Offset = "0xF0AE34", VA = "0xF0AE34")]
		private static Func<object, object> CreateCastConverter(TypeConvertKey t)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xF0B0CC", Offset = "0xF0B0CC", VA = "0xF0B0CC")]
		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xF0B1E0", Offset = "0xF0B1E0", VA = "0xF0B1E0")]
		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			return default(ConvertResult);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xEF7DB8", Offset = "0xEF7DB8", VA = "0xEF7DB8")]
		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xF0BBDC", Offset = "0xF0BBDC", VA = "0xF0BBDC")]
		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xF01CDC", Offset = "0xF01CDC", VA = "0xF01CDC")]
		internal static TypeConverter GetConverter(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xF0BAE8", Offset = "0xF0BAE8", VA = "0xF0BAE8")]
		public static bool VersionTryParse(string input, out Version result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xEF7D14", Offset = "0xEF7D14", VA = "0xEF7D14")]
		public static bool IsInteger(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xF0BDF0", Offset = "0xF0BDF0", VA = "0xF0BDF0")]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return default(ParseResult);
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xF0BFFC", Offset = "0xF0BFFC", VA = "0xF0BFFC")]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return default(ParseResult);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xF0C1D8", Offset = "0xF0C1D8", VA = "0xF0C1D8")]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xF0C330", Offset = "0xF0C330", VA = "0xF0C330")]
		public static int HexTextToInt(char[] text, int start, int end)
		{
			return default(int);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xF0C438", Offset = "0xF0C438", VA = "0xF0C438")]
		private static int HexCharToInt(char ch)
		{
			return default(int);
		}
	}
}
