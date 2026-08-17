using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000102")]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocument _document;

		[Token(Token = "0x17000174")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xD43644", Offset = "0xD43644", VA = "0xD43644", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD42D6C", Offset = "0xD42D6C", VA = "0xD42D6C")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD42D9C", Offset = "0xD42D9C", VA = "0xD42D9C", Slot = "15")]
		public IXmlNode CreateComment(string data)
		{
			return null;
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD42E3C", Offset = "0xD42E3C", VA = "0xD42E3C", Slot = "16")]
		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xD42EDC", Offset = "0xD42EDC", VA = "0xD42EDC", Slot = "17")]
		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD42F7C", Offset = "0xD42F7C", VA = "0xD42F7C", Slot = "18")]
		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD4301C", Offset = "0xD4301C", VA = "0xD4301C", Slot = "19")]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD430BC", Offset = "0xD430BC", VA = "0xD430BC", Slot = "20")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD43178", Offset = "0xD43178", VA = "0xD43178", Slot = "21")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD43238", Offset = "0xD43238", VA = "0xD43238", Slot = "22")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD432E0", Offset = "0xD432E0", VA = "0xD432E0", Slot = "23")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD433AC", Offset = "0xD433AC", VA = "0xD433AC", Slot = "24")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD43450", Offset = "0xD43450", VA = "0xD43450", Slot = "25")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD43560", Offset = "0xD43560", VA = "0xD43560", Slot = "26")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}
	}
}
