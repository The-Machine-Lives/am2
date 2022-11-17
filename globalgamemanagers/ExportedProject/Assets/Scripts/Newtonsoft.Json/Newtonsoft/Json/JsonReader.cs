using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000031")]
	[Preserve]
	public abstract class JsonReader : IDisposable
	{
		[Token(Token = "0x2000032")]
		protected internal enum State
		{
			[Token(Token = "0x40000CC")]
			Start = 0,
			[Token(Token = "0x40000CD")]
			Complete = 1,
			[Token(Token = "0x40000CE")]
			Property = 2,
			[Token(Token = "0x40000CF")]
			ObjectStart = 3,
			[Token(Token = "0x40000D0")]
			Object = 4,
			[Token(Token = "0x40000D1")]
			ArrayStart = 5,
			[Token(Token = "0x40000D2")]
			Array = 6,
			[Token(Token = "0x40000D3")]
			Closed = 7,
			[Token(Token = "0x40000D4")]
			PostValue = 8,
			[Token(Token = "0x40000D5")]
			ConstructorStart = 9,
			[Token(Token = "0x40000D6")]
			Constructor = 10,
			[Token(Token = "0x40000D7")]
			Error = 11,
			[Token(Token = "0x40000D8")]
			Finished = 12
		}

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		private object _value;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x24")]
		internal State _currentState;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x40")]
		private CultureInfo _culture;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x60")]
		private string _dateFormatString;

		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x68")]
		private List<JsonPosition> _stack;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F6C8", Offset = "0x80F6C8")]
		private bool _003CCloseInput_003Ek__BackingField;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80F6D8", Offset = "0x80F6D8")]
		private bool _003CSupportMultipleContent_003Ek__BackingField;

		[Token(Token = "0x1700002C")]
		protected State CurrentState
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xD38578", Offset = "0xD38578", VA = "0xD38578")]
			get
			{
				return default(State);
			}
		}

		[Token(Token = "0x1700002D")]
		public bool CloseInput
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xD384C0", Offset = "0xD384C0", VA = "0xD384C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810048", Offset = "0x810048")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xD4E1B0", Offset = "0xD4E1B0", VA = "0xD4E1B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810058", Offset = "0x810058")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public bool SupportMultipleContent
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xD4E1BC", Offset = "0xD4E1BC", VA = "0xD4E1BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810068", Offset = "0x810068")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xD4E1C4", Offset = "0xD4E1C4", VA = "0xD4E1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x810078", Offset = "0x810078")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xD4E1D0", Offset = "0xD4E1D0", VA = "0xD4E1D0")]
			get
			{
				return default(DateTimeZoneHandling);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xD4E1D8", Offset = "0xD4E1D8", VA = "0xD4E1D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xD4E274", Offset = "0xD4E274", VA = "0xD4E274")]
			get
			{
				return default(DateParseHandling);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xD4E27C", Offset = "0xD4E27C", VA = "0xD4E27C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xD4E318", Offset = "0xD4E318", VA = "0xD4E318")]
			get
			{
				return default(FloatParseHandling);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xD4E320", Offset = "0xD4E320", VA = "0xD4E320")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public string DateFormatString
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xD4E3BC", Offset = "0xD4E3BC", VA = "0xD4E3BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xD4E3C4", Offset = "0xD4E3C4", VA = "0xD4E3C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public int? MaxDepth
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xD4E3CC", Offset = "0xD4E3CC", VA = "0xD4E3CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xD4E3D4", Offset = "0xD4E3D4", VA = "0xD4E3D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xD4E4AC", Offset = "0xD4E4AC", VA = "0xD4E4AC", Slot = "5")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x17000035")]
		public virtual object Value
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xD4E4B4", Offset = "0xD4E4B4", VA = "0xD4E4B4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public virtual Type ValueType
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xD4E4BC", Offset = "0xD4E4BC", VA = "0xD4E4BC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public virtual int Depth
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xD4E4D0", Offset = "0xD4E4D0", VA = "0xD4E4D0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000038")]
		public virtual string Path
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xD4E564", Offset = "0xD4E564", VA = "0xD4E564", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public CultureInfo Culture
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xD4E67C", Offset = "0xD4E67C", VA = "0xD4E67C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xD4E6F4", Offset = "0xD4E6F4", VA = "0xD4E6F4")]
			set
			{
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xD4E6FC", Offset = "0xD4E6FC", VA = "0xD4E6FC")]
		internal JsonPosition GetPosition(int depth)
		{
			return default(JsonPosition);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xD4E7B4", Offset = "0xD4E7B4", VA = "0xD4E7B4")]
		protected JsonReader()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xD4E7F0", Offset = "0xD4E7F0", VA = "0xD4E7F0")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xD4EA64", Offset = "0xD4EA64", VA = "0xD4EA64")]
		private JsonContainerType Pop()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xD4EC18", Offset = "0xD4EC18", VA = "0xD4EC18")]
		private JsonContainerType Peek()
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x60000ED")]
		public abstract bool Read();

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xD4EC20", Offset = "0xD4EC20", VA = "0xD4EC20", Slot = "11")]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xD4F0F4", Offset = "0xD4F0F4", VA = "0xD4F0F4")]
		internal int? ReadInt32String(string s)
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD4F270", Offset = "0xD4F270", VA = "0xD4F270", Slot = "12")]
		public virtual string ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xD4F744", Offset = "0xD4F744", VA = "0xD4F744", Slot = "13")]
		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xD4FDB4", Offset = "0xD4FDB4", VA = "0xD4FDB4")]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD4FFC0", Offset = "0xD4FFC0", VA = "0xD4FFC0", Slot = "14")]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD50274", Offset = "0xD50274", VA = "0xD50274")]
		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD5040C", Offset = "0xD5040C", VA = "0xD5040C", Slot = "15")]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD506A8", Offset = "0xD506A8", VA = "0xD506A8")]
		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD5082C", Offset = "0xD5082C", VA = "0xD5082C", Slot = "16")]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xD50AEC", Offset = "0xD50AEC", VA = "0xD50AEC")]
		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xD50C94", Offset = "0xD50C94", VA = "0xD50C94", Slot = "17")]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD50F10", Offset = "0xD50F10", VA = "0xD50F10")]
		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xD51164", Offset = "0xD51164", VA = "0xD51164", Slot = "18")]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xD513E0", Offset = "0xD513E0", VA = "0xD513E0")]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD4FD40", Offset = "0xD4FD40", VA = "0xD4FD40")]
		internal void ReaderReadAndAssert()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD515EC", Offset = "0xD515EC", VA = "0xD515EC")]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD4FB60", Offset = "0xD4FB60", VA = "0xD4FB60")]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD3D824", Offset = "0xD3D824", VA = "0xD3D824")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD38470", Offset = "0xD38470", VA = "0xD38470")]
		protected void SetToken(JsonToken newToken)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD384C8", Offset = "0xD384C8", VA = "0xD384C8")]
		protected void SetToken(JsonToken newToken, object value)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD4EF58", Offset = "0xD4EF58", VA = "0xD4EF58")]
		internal void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD51780", Offset = "0xD51780", VA = "0xD51780")]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD4EA4C", Offset = "0xD4EA4C", VA = "0xD4EA4C")]
		private void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD51640", Offset = "0xD51640", VA = "0xD51640")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD518BC", Offset = "0xD518BC", VA = "0xD518BC")]
		protected void SetStateBasedOnCurrent()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD517C0", Offset = "0xD517C0", VA = "0xD517C0")]
		private void SetFinished()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD517D8", Offset = "0xD517D8", VA = "0xD517D8")]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return default(JsonContainerType);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD519E0", Offset = "0xD519E0", VA = "0xD519E0", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD51A60", Offset = "0xD51A60", VA = "0xD51A60", Slot = "19")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD384AC", Offset = "0xD384AC", VA = "0xD384AC", Slot = "20")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD3D7A4", Offset = "0xD3D7A4", VA = "0xD3D7A4")]
		internal void ReadAndAssert()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD51A84", Offset = "0xD51A84", VA = "0xD51A84")]
		internal bool ReadAndMoveToContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD51ADC", Offset = "0xD51ADC", VA = "0xD51ADC")]
		internal bool MoveToContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD4EEDC", Offset = "0xD4EEDC", VA = "0xD4EEDC")]
		private JsonToken GetContentToken()
		{
			return default(JsonToken);
		}
	}
}
