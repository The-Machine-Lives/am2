using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D3")]
	[Preserve]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x80")]
		private string _initialPath;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x88")]
		private JToken _parent;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x90")]
		private JToken _current;

		[Token(Token = "0x1700012A")]
		public JToken CurrentToken
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xCFCF6C", Offset = "0xCFCF6C", VA = "0xCFCF6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0xCFE520", Offset = "0xCFE520", VA = "0xCFE520", Slot = "22")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012C")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xCFE5F0", Offset = "0xCFE5F0", VA = "0xCFE5F0", Slot = "23")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700012D")]
		public override string Path
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xCFE6C0", Offset = "0xCFE6C0", VA = "0xCFE6C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xCFCF74", Offset = "0xCFCF74", VA = "0xCFCF74")]
		public JTokenReader(JToken token)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xCFCFE8", Offset = "0xCFCFE8", VA = "0xCFCFE8", Slot = "10")]
		public override bool Read()
		{
			return default(bool);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xCFD138", Offset = "0xCFD138", VA = "0xCFD138")]
		private bool ReadOver(JToken t)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xCFE204", Offset = "0xCFE204", VA = "0xCFE204")]
		private bool ReadToEnd()
		{
			return default(bool);
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xCFE2D8", Offset = "0xCFE2D8", VA = "0xCFE2D8")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xCFD0BC", Offset = "0xCFD0BC", VA = "0xCFD0BC")]
		private bool ReadInto(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xCFE228", Offset = "0xCFE228", VA = "0xCFE228")]
		private bool SetEnd(JContainer c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xCFD250", Offset = "0xCFD250", VA = "0xCFD250")]
		private void SetToken(JToken token)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xCFE434", Offset = "0xCFE434", VA = "0xCFE434")]
		private string SafeToString(object value)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xCFE454", Offset = "0xCFE454", VA = "0xCFE454", Slot = "21")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default(bool);
		}
	}
}
