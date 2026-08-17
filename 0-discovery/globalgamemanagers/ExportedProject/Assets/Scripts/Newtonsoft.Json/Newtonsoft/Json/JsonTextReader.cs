using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000029")]
	[Preserve]
	public class JsonTextReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x78")]
		private readonly TextReader _reader;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x80")]
		private char[] _chars;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x88")]
		private int _charsUsed;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x8C")]
		private int _charPos;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x90")]
		private int _lineStartPos;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x94")]
		private int _lineNumber;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x98")]
		private bool _isEndOfFile;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuffer _stringBuffer;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xB0")]
		private StringReference _stringReference;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xC0")]
		private IArrayPool<char> _arrayPool;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xC8")]
		internal PropertyNameTable NameTable;

		[Token(Token = "0x1700001E")]
		public int LineNumber
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xFE3334", Offset = "0xFE3334", VA = "0xFE3334", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001F")]
		public int LinePosition
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xFE338C", Offset = "0xFE338C", VA = "0xFE338C", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xFDCA38", Offset = "0xFDCA38", VA = "0xFDCA38")]
		public JsonTextReader(TextReader reader)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xFDCAE4", Offset = "0xFDCAE4", VA = "0xFDCAE4")]
		private void EnsureBufferNotEmpty()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFDCB38", Offset = "0xFDCB38", VA = "0xFDCB38")]
		private void OnNewLine(int pos)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xFDCB48", Offset = "0xFDCB48", VA = "0xFDCB48")]
		private void ParseString(char quote, ReadType readType)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xFDD518", Offset = "0xFDD518", VA = "0xFDD518")]
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xFDCEA0", Offset = "0xFDCEA0", VA = "0xFDCEA0")]
		private void ShiftBufferIfNeeded()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xFDD52C", Offset = "0xFDD52C", VA = "0xFDD52C")]
		private int ReadData(bool append)
		{
			return default(int);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xFDD538", Offset = "0xFDD538", VA = "0xFDD538")]
		private int ReadData(bool append, int charsRequired)
		{
			return default(int);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xFDD7D8", Offset = "0xFDD7D8", VA = "0xFDD7D8")]
		private bool EnsureChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFDD7F8", Offset = "0xFDD7F8", VA = "0xFDD7F8")]
		private bool ReadChars(int relativePosition, bool append)
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFDD86C", Offset = "0xFDD86C", VA = "0xFDD86C", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFDE8C4", Offset = "0xFDE8C4", VA = "0xFDE8C4", Slot = "11")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xFDEEA8", Offset = "0xFDEEA8", VA = "0xFDEEA8", Slot = "17")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xFDF704", Offset = "0xFDF704", VA = "0xFDF704", Slot = "12")]
		public override string ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xFDF7BC", Offset = "0xFDF7BC", VA = "0xFDF7BC", Slot = "13")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xFDEF88", Offset = "0xFDEF88", VA = "0xFDEF88")]
		private object ReadStringValue(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xFDFE9C", Offset = "0xFDFE9C", VA = "0xFDFE9C")]
		private JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xFE17B0", Offset = "0xFE17B0", VA = "0xFE17B0", Slot = "15")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xFDFE08", Offset = "0xFDFE08", VA = "0xFDFE08")]
		private void ProcessValueComma()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xFDE9A4", Offset = "0xFDE9A4", VA = "0xFDE9A4")]
		private object ReadNumberValue(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xFE1C88", Offset = "0xFE1C88", VA = "0xFE1C88", Slot = "18")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xFE1D7C", Offset = "0xFE1D7C", VA = "0xFE1D7C", Slot = "16")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFE1E70", Offset = "0xFE1E70", VA = "0xFE1E70", Slot = "14")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xFDFCE8", Offset = "0xFDFCE8", VA = "0xFDFCE8")]
		private void HandleNull()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFE0028", Offset = "0xFE0028", VA = "0xFE0028")]
		private void ReadFinished()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xFDFC8C", Offset = "0xFDFC8C", VA = "0xFDFC8C")]
		private bool ReadNullChar()
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xFDDAE0", Offset = "0xFDDAE0", VA = "0xFDDAE0")]
		private void EnsureBuffer()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xFDCF74", Offset = "0xFDCF74", VA = "0xFDCF74")]
		private void ReadStringIntoBuffer(char quote)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFE211C", Offset = "0xFE211C", VA = "0xFE211C")]
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFE2004", Offset = "0xFE2004", VA = "0xFE2004")]
		private char ParseUnicode()
		{
			return default(char);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xFE217C", Offset = "0xFE217C", VA = "0xFE217C")]
		private void ReadNumberIntoBuffer()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xFE23A8", Offset = "0xFE23A8", VA = "0xFE23A8")]
		private void ClearRecentString()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xFDE158", Offset = "0xFDE158", VA = "0xFDE158")]
		private bool ParsePostValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xFDDFB4", Offset = "0xFDDFB4", VA = "0xFDDFB4")]
		private bool ParseObject()
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xFE23D8", Offset = "0xFE23D8", VA = "0xFE23D8")]
		private bool ParseProperty()
		{
			return default(bool);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xFE26D0", Offset = "0xFE26D0", VA = "0xFE26D0")]
		private bool ValidIdentifierChar(char value)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xFE2760", Offset = "0xFE2760", VA = "0xFE2760")]
		private void ParseUnquotedProperty()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFDDB40", Offset = "0xFDDB40", VA = "0xFDDB40")]
		private bool ParseValue()
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFE000C", Offset = "0xFE000C", VA = "0xFE000C")]
		private void ProcessLineFeed()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFDFF5C", Offset = "0xFDFF5C", VA = "0xFDFF5C")]
		private void ProcessCarriageReturn(bool append)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFDE3EC", Offset = "0xFDE3EC", VA = "0xFDE3EC")]
		private bool EatWhitespace(bool oneOrMore)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFE2B20", Offset = "0xFE2B20", VA = "0xFE2B20")]
		private void ParseConstructor()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFE0330", Offset = "0xFE0330", VA = "0xFE0330")]
		private void ParseNumber(ReadType readType)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xFDE544", Offset = "0xFDE544", VA = "0xFDE544")]
		private void ParseComment(bool setToken)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFE2F54", Offset = "0xFE2F54", VA = "0xFE2F54")]
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFE2FA4", Offset = "0xFE2FA4", VA = "0xFE2FA4")]
		private bool MatchValue(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFE13FC", Offset = "0xFE13FC", VA = "0xFE13FC")]
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xFE3128", Offset = "0xFE3128", VA = "0xFE3128")]
		private bool IsSeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFE2964", Offset = "0xFE2964", VA = "0xFE2964")]
		private void ParseTrue()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFE1F50", Offset = "0xFE1F50", VA = "0xFE1F50")]
		private void ParseNull()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xFE2EA0", Offset = "0xFE2EA0", VA = "0xFE2EA0")]
		private void ParseUndefined()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFE2A44", Offset = "0xFE2A44", VA = "0xFE2A44")]
		private void ParseFalse()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFE01C8", Offset = "0xFE01C8", VA = "0xFE01C8")]
		private object ParseNumberNegativeInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFE14E0", Offset = "0xFE14E0", VA = "0xFE14E0")]
		private object ParseNumberPositiveInfinity(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xFE1648", Offset = "0xFE1648", VA = "0xFE1648")]
		private object ParseNumberNaN(ReadType readType)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xFE32C0", Offset = "0xFE32C0", VA = "0xFE32C0", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xFE332C", Offset = "0xFE332C", VA = "0xFE332C", Slot = "21")]
		public bool HasLineInfo()
		{
			return default(bool);
		}
	}
}
