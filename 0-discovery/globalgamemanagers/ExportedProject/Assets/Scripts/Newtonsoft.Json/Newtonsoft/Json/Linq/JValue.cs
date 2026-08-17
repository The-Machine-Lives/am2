using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000E0")]
	[Preserve]
	public class JValue : JToken, IFormattable, IComparable, IConvertible
	{
		[Token(Token = "0x400034E")]
		[FieldOffset(Offset = "0x30")]
		private JTokenType _valueType;

		[Token(Token = "0x400034F")]
		[FieldOffset(Offset = "0x38")]
		private object _value;

		[Token(Token = "0x1700014E")]
		public override bool HasValues
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xD00138", Offset = "0xD00138", VA = "0xD00138", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014F")]
		public override JTokenType Type
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xD00CA8", Offset = "0xD00CA8", VA = "0xD00CA8", Slot = "12")]
			get
			{
				return default(JTokenType);
			}
		}

		[Token(Token = "0x17000150")]
		public object Value
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xCFE42C", Offset = "0xCFE42C", VA = "0xCFE42C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xCFFB84", Offset = "0xCFFB84", VA = "0xCFFB84")]
		internal JValue(object value, JTokenType type)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xCFFC08", Offset = "0xCFFC08", VA = "0xCFFC08")]
		public JValue(JValue other)
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xCFEC30", Offset = "0xCFEC30", VA = "0xCFEC30")]
		public JValue(object value)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD00008", Offset = "0xD00008", VA = "0xD00008", Slot = "11")]
		internal override bool DeepEquals(JToken node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD00140", Offset = "0xD00140", VA = "0xD00140")]
		internal static int Compare(JTokenType valueType, object objA, object objB)
		{
			return default(int);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD00A3C", Offset = "0xD00A3C", VA = "0xD00A3C")]
		private static int CompareFloat(object objA, object objB)
		{
			return default(int);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD00B44", Offset = "0xD00B44", VA = "0xD00B44", Slot = "10")]
		internal override JToken CloneToken()
		{
			return null;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xCFEE98", Offset = "0xCFEE98", VA = "0xCFEE98")]
		public static JValue CreateComment(string value)
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xCFED1C", Offset = "0xCFED1C", VA = "0xCFED1C")]
		public static JValue CreateNull()
		{
			return null;
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xD00BA4", Offset = "0xD00BA4", VA = "0xD00BA4")]
		public static JValue CreateUndefined()
		{
			return null;
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xCFFCB4", Offset = "0xCFFCB4", VA = "0xCFFCB4")]
		private static JTokenType GetValueType(JTokenType? current, object value)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xD00C04", Offset = "0xD00C04", VA = "0xD00C04")]
		private static JTokenType GetStringValueType(JTokenType? current)
		{
			return default(JTokenType);
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xD00CB0", Offset = "0xD00CB0", VA = "0xD00CB0", Slot = "18")]
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xD015EC", Offset = "0xD015EC", VA = "0xD015EC", Slot = "19")]
		internal override int GetDeepHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xD000B8", Offset = "0xD000B8", VA = "0xD000B8")]
		private static bool ValuesEquals(JValue v1, JValue v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xD0164C", Offset = "0xD0164C", VA = "0xD0164C")]
		public bool Equals(JValue other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xD0165C", Offset = "0xD0165C", VA = "0xD0165C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xD01718", Offset = "0xD01718", VA = "0xD01718", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xD01730", Offset = "0xD01730", VA = "0xD01730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xD017A0", Offset = "0xD017A0", VA = "0xD017A0", Slot = "37")]
		public string ToString(IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xD017B0", Offset = "0xD017B0", VA = "0xD017B0", Slot = "20")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xD018E4", Offset = "0xD018E4", VA = "0xD018E4", Slot = "21")]
		private int System_002EIComparable_002ECompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xD01984", Offset = "0xD01984", VA = "0xD01984")]
		public int CompareTo(JValue obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xD019A8", Offset = "0xD019A8", VA = "0xD019A8", Slot = "22")]
		private TypeCode System_002EIConvertible_002EGetTypeCode()
		{
			return default(TypeCode);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xD01A74", Offset = "0xD01A74", VA = "0xD01A74", Slot = "23")]
		private bool System_002EIConvertible_002EToBoolean(IFormatProvider provider)
		{
			return default(bool);
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD01ADC", Offset = "0xD01ADC", VA = "0xD01ADC", Slot = "24")]
		private char System_002EIConvertible_002EToChar(IFormatProvider provider)
		{
			return default(char);
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xD01B44", Offset = "0xD01B44", VA = "0xD01B44", Slot = "25")]
		private sbyte System_002EIConvertible_002EToSByte(IFormatProvider provider)
		{
			return default(sbyte);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xD01BAC", Offset = "0xD01BAC", VA = "0xD01BAC", Slot = "26")]
		private byte System_002EIConvertible_002EToByte(IFormatProvider provider)
		{
			return default(byte);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD01C14", Offset = "0xD01C14", VA = "0xD01C14", Slot = "27")]
		private short System_002EIConvertible_002EToInt16(IFormatProvider provider)
		{
			return default(short);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xD01C7C", Offset = "0xD01C7C", VA = "0xD01C7C", Slot = "28")]
		private ushort System_002EIConvertible_002EToUInt16(IFormatProvider provider)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xD01CE4", Offset = "0xD01CE4", VA = "0xD01CE4", Slot = "29")]
		private int System_002EIConvertible_002EToInt32(IFormatProvider provider)
		{
			return default(int);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD01D4C", Offset = "0xD01D4C", VA = "0xD01D4C", Slot = "30")]
		private uint System_002EIConvertible_002EToUInt32(IFormatProvider provider)
		{
			return default(uint);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD01DB4", Offset = "0xD01DB4", VA = "0xD01DB4", Slot = "31")]
		private long System_002EIConvertible_002EToInt64(IFormatProvider provider)
		{
			return default(long);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD01E1C", Offset = "0xD01E1C", VA = "0xD01E1C", Slot = "32")]
		private ulong System_002EIConvertible_002EToUInt64(IFormatProvider provider)
		{
			return default(ulong);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD01E84", Offset = "0xD01E84", VA = "0xD01E84", Slot = "33")]
		private float System_002EIConvertible_002EToSingle(IFormatProvider provider)
		{
			return default(float);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD01EEC", Offset = "0xD01EEC", VA = "0xD01EEC", Slot = "34")]
		private double System_002EIConvertible_002EToDouble(IFormatProvider provider)
		{
			return default(double);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD01F54", Offset = "0xD01F54", VA = "0xD01F54", Slot = "35")]
		private decimal System_002EIConvertible_002EToDecimal(IFormatProvider provider)
		{
			return default(decimal);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD01FBC", Offset = "0xD01FBC", VA = "0xD01FBC", Slot = "36")]
		private DateTime System_002EIConvertible_002EToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD02024", Offset = "0xD02024", VA = "0xD02024", Slot = "38")]
		private object System_002EIConvertible_002EToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}
	}
}
