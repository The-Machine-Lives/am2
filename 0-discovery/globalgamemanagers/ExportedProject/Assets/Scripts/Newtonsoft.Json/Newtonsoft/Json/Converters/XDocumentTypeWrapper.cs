using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010D")]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x18")]
		private readonly XDocumentType _documentType;

		[Token(Token = "0x1700019C")]
		public string Name
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0xD410B4", Offset = "0xD410B4", VA = "0xD410B4", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		public string System
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0xD410E4", Offset = "0xD410E4", VA = "0xD410E4", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public string Public
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xD41114", Offset = "0xD41114", VA = "0xD41114", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019F")]
		public string InternalSubset
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xD41144", Offset = "0xD41144", VA = "0xD41144", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A0")]
		public override string LocalName
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xD41174", Offset = "0xD41174", VA = "0xD41174", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xD40E1C", Offset = "0xD40E1C", VA = "0xD40E1C")]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}
	}
}
