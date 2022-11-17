using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200007F")]
	[Preserve]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;

		[Token(Token = "0x1700008A")]
		public override int Depth
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xF07A18", Offset = "0xF07A18", VA = "0xF07A18", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008B")]
		public override string Path
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0xF07A4C", Offset = "0xF07A4C", VA = "0xF07A4C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xF07A80", Offset = "0xF07A80", VA = "0xF07A80", Slot = "5")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x1700008D")]
		public override object Value
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0xF07AB4", Offset = "0xF07AB4", VA = "0xF07AB4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public override Type ValueType
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0xF07AE8", Offset = "0xF07AE8", VA = "0xF07AE8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0xF07C18", Offset = "0xF07C18", VA = "0xF07C18", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000090")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0xF07CE0", Offset = "0xF07CE0", VA = "0xF07CE0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xF07404", Offset = "0xF07404", VA = "0xF07404")]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xF07540", Offset = "0xF07540", VA = "0xF07540")]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF07574", Offset = "0xF07574", VA = "0xF07574", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF075F4", Offset = "0xF075F4", VA = "0xF075F4", Slot = "11")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF07674", Offset = "0xF07674", VA = "0xF07674", Slot = "12")]
		public override string ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF076F4", Offset = "0xF076F4", VA = "0xF076F4", Slot = "13")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xF07774", Offset = "0xF07774", VA = "0xF07774", Slot = "16")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xF077F8", Offset = "0xF077F8", VA = "0xF077F8", Slot = "14")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xF07884", Offset = "0xF07884", VA = "0xF07884", Slot = "15")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xF07908", Offset = "0xF07908", VA = "0xF07908", Slot = "17")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xF07994", Offset = "0xF07994", VA = "0xF07994", Slot = "18")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xF07B1C", Offset = "0xF07B1C", VA = "0xF07B1C", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xF07B54", Offset = "0xF07B54", VA = "0xF07B54", Slot = "21")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default(bool);
		}
	}
}
