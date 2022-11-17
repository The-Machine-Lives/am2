using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200003B")]
	[Preserve]
	public abstract class JsonWriter : IDisposable
	{
		[Token(Token = "0x200003C")]
		internal enum State
		{
			[Token(Token = "0x4000132")]
			Start = 0,
			[Token(Token = "0x4000133")]
			Property = 1,
			[Token(Token = "0x4000134")]
			ObjectStart = 2,
			[Token(Token = "0x4000135")]
			Object = 3,
			[Token(Token = "0x4000136")]
			ArrayStart = 4,
			[Token(Token = "0x4000137")]
			Array = 5,
			[Token(Token = "0x4000138")]
			ConstructorStart = 6,
			[Token(Token = "0x4000139")]
			Constructor = 7,
			[Token(Token = "0x400013A")]
			Closed = 8,
			[Token(Token = "0x400013B")]
			Error = 9
		}

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		private static readonly State[][] StateArray;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly State[][] StateArrayTempate;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x10")]
		private List<JsonPosition> _stack;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		private State _currentState;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F708", Offset = "0x80F708")]
		private bool _003CCloseOutput_003Ek__BackingField;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x50")]
		private string _dateFormatString;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x58")]
		private CultureInfo _culture;

		[Token(Token = "0x1700004E")]
		public bool CloseOutput
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xFE3630", Offset = "0xFE3630", VA = "0xFE3630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8100C8", Offset = "0x8100C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xFE68B8", Offset = "0xFE68B8", VA = "0xFE68B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8100D8", Offset = "0x8100D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		protected internal int Top
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xFE3CDC", Offset = "0xFE3CDC", VA = "0xFE3CDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public WriteState WriteState
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xFE68CC", Offset = "0xFE68CC", VA = "0xFE68CC")]
			get
			{
				return default(WriteState);
			}
		}

		[Token(Token = "0x17000051")]
		internal string ContainerPath
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xFE698C", Offset = "0xFE698C", VA = "0xFE698C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public string Path
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xFE6A3C", Offset = "0xFE6A3C", VA = "0xFE6A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Formatting Formatting
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xFE6B58", Offset = "0xFE6B58", VA = "0xFE6B58")]
			get
			{
				return default(Formatting);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xFE6B60", Offset = "0xFE6B60", VA = "0xFE6B60")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xFE4EC4", Offset = "0xFE4EC4", VA = "0xFE4EC4")]
			get
			{
				return default(DateFormatHandling);
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xFE6BFC", Offset = "0xFE6BFC", VA = "0xFE6BFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xFE4EB4", Offset = "0xFE4EB4", VA = "0xFE4EB4")]
			get
			{
				return default(DateTimeZoneHandling);
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xFE6C98", Offset = "0xFE6C98", VA = "0xFE6C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xFE3B9C", Offset = "0xFE3B9C", VA = "0xFE3B9C")]
			get
			{
				return default(StringEscapeHandling);
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xFE6D34", Offset = "0xFE6D34", VA = "0xFE6D34")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xFE458C", Offset = "0xFE458C", VA = "0xFE458C")]
			get
			{
				return default(FloatFormatHandling);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xFE6DE0", Offset = "0xFE6DE0", VA = "0xFE6DE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public string DateFormatString
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xFE4EBC", Offset = "0xFE4EBC", VA = "0xFE4EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xFE6E7C", Offset = "0xFE6E7C", VA = "0xFE6E7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public CultureInfo Culture
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xFE4ECC", Offset = "0xFE4ECC", VA = "0xFE4ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xFE6E84", Offset = "0xFE6E84", VA = "0xFE6E84")]
			set
			{
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xFE5698", Offset = "0xFE5698", VA = "0xFE5698")]
		internal static State[][] BuildStateArray()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xFE5B04", Offset = "0xFE5B04", VA = "0xFE5B04")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xFE6DDC", Offset = "0xFE6DDC", VA = "0xFE6DDC", Slot = "5")]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xFE3514", Offset = "0xFE3514", VA = "0xFE3514")]
		protected JsonWriter()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xFE6E8C", Offset = "0xFE6E8C", VA = "0xFE6E8C")]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xFE6EA4", Offset = "0xFE6EA4", VA = "0xFE6EA4")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xFE6FBC", Offset = "0xFE6FBC", VA = "0xFE6FBC")]
		private JsonContainerType Pop()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xFE68C4", Offset = "0xFE68C4", VA = "0xFE68C4")]
		private JsonContainerType Peek()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xFE362C", Offset = "0xFE362C", VA = "0xFE362C", Slot = "6")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xFE7150", Offset = "0xFE7150", VA = "0xFE7150", Slot = "7")]
		public virtual void WriteStartObject()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFE715C", Offset = "0xFE715C", VA = "0xFE715C", Slot = "8")]
		public virtual void WriteEndObject()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xFE7168", Offset = "0xFE7168", VA = "0xFE7168", Slot = "9")]
		public virtual void WriteStartArray()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xFE7174", Offset = "0xFE7174", VA = "0xFE7174", Slot = "10")]
		public virtual void WriteEndArray()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xFE717C", Offset = "0xFE717C", VA = "0xFE717C", Slot = "11")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xFE7188", Offset = "0xFE7188", VA = "0xFE7188", Slot = "12")]
		public virtual void WriteEndConstructor()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xFE7190", Offset = "0xFE7190", VA = "0xFE7190", Slot = "13")]
		public virtual void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFE71A0", Offset = "0xFE71A0", VA = "0xFE71A0", Slot = "14")]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xFE71AC", Offset = "0xFE71AC", VA = "0xFE71AC", Slot = "15")]
		public virtual void WriteEnd()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xFE7298", Offset = "0xFE7298", VA = "0xFE7298")]
		public void WriteToken(JsonReader reader)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xFE72A0", Offset = "0xFE72A0", VA = "0xFE72A0")]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFE7328", Offset = "0xFE7328", VA = "0xFE7328")]
		public void WriteToken(JsonToken token, object value)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFE79C8", Offset = "0xFE79C8", VA = "0xFE79C8", Slot = "16")]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFE7BAC", Offset = "0xFE7BAC", VA = "0xFE7BAC")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xFE71B4", Offset = "0xFE71B4", VA = "0xFE71B4")]
		private void WriteEnd(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xFE7104", Offset = "0xFE7104", VA = "0xFE7104")]
		private void AutoCompleteAll()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xFE7D8C", Offset = "0xFE7D8C", VA = "0xFE7D8C")]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return default(JsonToken);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFE7E44", Offset = "0xFE7E44", VA = "0xFE7E44")]
		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xFE8040", Offset = "0xFE8040", VA = "0xFE8040", Slot = "17")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xFE8044", Offset = "0xFE8044", VA = "0xFE8044", Slot = "18")]
		protected virtual void WriteIndent()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xFE8048", Offset = "0xFE8048", VA = "0xFE8048", Slot = "19")]
		protected virtual void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xFE804C", Offset = "0xFE804C", VA = "0xFE804C", Slot = "20")]
		protected virtual void WriteIndentSpace()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xFE8050", Offset = "0xFE8050", VA = "0xFE8050")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xFE82E0", Offset = "0xFE82E0", VA = "0xFE82E0", Slot = "21")]
		public virtual void WriteNull()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xFE82FC", Offset = "0xFE82FC", VA = "0xFE82FC", Slot = "22")]
		public virtual void WriteUndefined()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xFE8318", Offset = "0xFE8318", VA = "0xFE8318", Slot = "23")]
		public virtual void WriteRaw(string json)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xFE831C", Offset = "0xFE831C", VA = "0xFE831C", Slot = "24")]
		public virtual void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xFE8370", Offset = "0xFE8370", VA = "0xFE8370", Slot = "25")]
		public virtual void WriteValue(string value)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xFE838C", Offset = "0xFE838C", VA = "0xFE838C", Slot = "26")]
		public virtual void WriteValue(int value)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xFE83A8", Offset = "0xFE83A8", VA = "0xFE83A8", Slot = "27")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8100E8", Offset = "0x8100E8")]
		public virtual void WriteValue(uint value)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xFE83C4", Offset = "0xFE83C4", VA = "0xFE83C4", Slot = "28")]
		public virtual void WriteValue(long value)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xFE83E0", Offset = "0xFE83E0", VA = "0xFE83E0", Slot = "29")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x8100FC", Offset = "0x8100FC")]
		public virtual void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xFE83FC", Offset = "0xFE83FC", VA = "0xFE83FC", Slot = "30")]
		public virtual void WriteValue(float value)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xFE8418", Offset = "0xFE8418", VA = "0xFE8418", Slot = "31")]
		public virtual void WriteValue(double value)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xFE8434", Offset = "0xFE8434", VA = "0xFE8434", Slot = "32")]
		public virtual void WriteValue(bool value)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xFE8450", Offset = "0xFE8450", VA = "0xFE8450", Slot = "33")]
		public virtual void WriteValue(short value)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xFE846C", Offset = "0xFE846C", VA = "0xFE846C", Slot = "34")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810110", Offset = "0x810110")]
		public virtual void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xFE8488", Offset = "0xFE8488", VA = "0xFE8488", Slot = "35")]
		public virtual void WriteValue(char value)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xFE84A4", Offset = "0xFE84A4", VA = "0xFE84A4", Slot = "36")]
		public virtual void WriteValue(byte value)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xFE84C0", Offset = "0xFE84C0", VA = "0xFE84C0", Slot = "37")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810124", Offset = "0x810124")]
		public virtual void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xFE84DC", Offset = "0xFE84DC", VA = "0xFE84DC", Slot = "38")]
		public virtual void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xFE84F8", Offset = "0xFE84F8", VA = "0xFE84F8", Slot = "39")]
		public virtual void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xFE8514", Offset = "0xFE8514", VA = "0xFE8514", Slot = "40")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xFE8530", Offset = "0xFE8530", VA = "0xFE8530", Slot = "41")]
		public virtual void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xFE854C", Offset = "0xFE854C", VA = "0xFE854C", Slot = "42")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xFE8568", Offset = "0xFE8568", VA = "0xFE8568", Slot = "43")]
		public virtual void WriteValue(int? value)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xFE8610", Offset = "0xFE8610", VA = "0xFE8610", Slot = "44")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810138", Offset = "0x810138")]
		public virtual void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xFE86B8", Offset = "0xFE86B8", VA = "0xFE86B8", Slot = "45")]
		public virtual void WriteValue(long? value)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xFE8760", Offset = "0xFE8760", VA = "0xFE8760", Slot = "46")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x81014C", Offset = "0x81014C")]
		public virtual void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xFE8808", Offset = "0xFE8808", VA = "0xFE8808", Slot = "47")]
		public virtual void WriteValue(float? value)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xFE88AC", Offset = "0xFE88AC", VA = "0xFE88AC", Slot = "48")]
		public virtual void WriteValue(double? value)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xFE8950", Offset = "0xFE8950", VA = "0xFE8950", Slot = "49")]
		public virtual void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xFE89F8", Offset = "0xFE89F8", VA = "0xFE89F8", Slot = "50")]
		public virtual void WriteValue(short? value)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xFE8AA0", Offset = "0xFE8AA0", VA = "0xFE8AA0", Slot = "51")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810160", Offset = "0x810160")]
		public virtual void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xFE8B48", Offset = "0xFE8B48", VA = "0xFE8B48", Slot = "52")]
		public virtual void WriteValue(char? value)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xFE8BF0", Offset = "0xFE8BF0", VA = "0xFE8BF0", Slot = "53")]
		public virtual void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xFE8C98", Offset = "0xFE8C98", VA = "0xFE8C98", Slot = "54")]
		[AttributeAttribute(Name = "CLSCompliantAttribute", RVA = "0x810174", Offset = "0x810174")]
		public virtual void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xFE8D40", Offset = "0xFE8D40", VA = "0xFE8D40", Slot = "55")]
		public virtual void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFE8DF8", Offset = "0xFE8DF8", VA = "0xFE8DF8", Slot = "56")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xFE8EA0", Offset = "0xFE8EA0", VA = "0xFE8EA0", Slot = "57")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xFE8F58", Offset = "0xFE8F58", VA = "0xFE8F58", Slot = "58")]
		public virtual void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xFE9010", Offset = "0xFE9010", VA = "0xFE9010", Slot = "59")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xFE90B8", Offset = "0xFE90B8", VA = "0xFE90B8", Slot = "60")]
		public virtual void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xFE90E8", Offset = "0xFE90E8", VA = "0xFE90E8", Slot = "61")]
		public virtual void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xFE3DF4", Offset = "0xFE3DF4", VA = "0xFE3DF4", Slot = "62")]
		public virtual void WriteValue(object value)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xFEA0A4", Offset = "0xFEA0A4", VA = "0xFEA0A4", Slot = "63")]
		public virtual void WriteComment(string text)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xFEA0AC", Offset = "0xFEA0AC", VA = "0xFEA0AC", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xFEA12C", Offset = "0xFEA12C", VA = "0xFEA12C", Slot = "64")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xFE91A4", Offset = "0xFE91A4", VA = "0xFE91A4")]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xFEA14C", Offset = "0xFEA14C", VA = "0xFEA14C")]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xFE7164", Offset = "0xFE7164", VA = "0xFE7164")]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xFE3998", Offset = "0xFE3998", VA = "0xFE3998")]
		internal void InternalWritePropertyName(string name)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xFE4090", Offset = "0xFE4090", VA = "0xFE4090")]
		internal void InternalWriteRaw()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xFE3680", Offset = "0xFE3680", VA = "0xFE3680")]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xFE3F88", Offset = "0xFE3F88", VA = "0xFE3F88")]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xFE5690", Offset = "0xFE5690", VA = "0xFE5690")]
		internal void InternalWriteComment()
		{
		}
	}
}
