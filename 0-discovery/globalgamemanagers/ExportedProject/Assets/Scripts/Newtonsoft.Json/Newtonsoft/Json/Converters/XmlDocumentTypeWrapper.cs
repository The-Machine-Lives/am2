using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000105")]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocumentType _documentType;

		[Token(Token = "0x17000179")]
		public string Name
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0xD42C60", Offset = "0xD42C60", VA = "0xD42C60", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		public string System
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0xD42C94", Offset = "0xD42C94", VA = "0xD42C94", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017B")]
		public string Public
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0xD42CC4", Offset = "0xD42CC4", VA = "0xD42CC4", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		public string InternalSubset
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0xD42CF4", Offset = "0xD42CF4", VA = "0xD42CF4", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017D")]
		public override string LocalName
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0xD42D24", Offset = "0xD42D24", VA = "0xD42D24", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD42C30", Offset = "0xD42C30", VA = "0xD42C30")]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
		}
	}
}
