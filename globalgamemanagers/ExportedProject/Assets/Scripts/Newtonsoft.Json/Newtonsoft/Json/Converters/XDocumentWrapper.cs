using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010E")]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		[Token(Token = "0x170001A1")]
		private XDocument Document
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xD411BC", Offset = "0xD411BC", VA = "0xD411BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A2")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xD41288", Offset = "0xD41288", VA = "0xD41288", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xD41B0C", Offset = "0xD41B0C", VA = "0xD41B0C", Slot = "33")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xD40D1C", Offset = "0xD40D1C", VA = "0xD40D1C")]
		public XDocumentWrapper(XDocument document)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xD41410", Offset = "0xD41410", VA = "0xD41410", Slot = "21")]
		public IXmlNode CreateComment(string text)
		{
			return null;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0xD41494", Offset = "0xD41494", VA = "0xD41494", Slot = "22")]
		public IXmlNode CreateTextNode(string text)
		{
			return null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xD41518", Offset = "0xD41518", VA = "0xD41518", Slot = "23")]
		public IXmlNode CreateCDataSection(string data)
		{
			return null;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xD4159C", Offset = "0xD4159C", VA = "0xD4159C", Slot = "24")]
		public IXmlNode CreateWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xD41620", Offset = "0xD41620", VA = "0xD41620", Slot = "25")]
		public IXmlNode CreateSignificantWhitespace(string text)
		{
			return null;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xD416A4", Offset = "0xD416A4", VA = "0xD416A4", Slot = "26")]
		public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			return null;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xD4173C", Offset = "0xD4173C", VA = "0xD4173C", Slot = "27")]
		public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xD417E4", Offset = "0xD417E4", VA = "0xD417E4", Slot = "28")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xD41874", Offset = "0xD41874", VA = "0xD41874", Slot = "29")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xD41908", Offset = "0xD41908", VA = "0xD41908", Slot = "30")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xD419B4", Offset = "0xD419B4", VA = "0xD419B4", Slot = "31")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xD41A58", Offset = "0xD41A58", VA = "0xD41A58", Slot = "32")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xD41BC0", Offset = "0xD41BC0", VA = "0xD41BC0", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
