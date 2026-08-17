using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000115")]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;

		[Token(Token = "0x170001BD")]
		private XElement Element
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xD41C88", Offset = "0xD41C88", VA = "0xD41C88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BE")]
		public override List<IXmlNode> Attributes
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0xD41E58", Offset = "0xD41E58", VA = "0xD41E58", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BF")]
		public override string Value
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0xD42624", Offset = "0xD42624", VA = "0xD42624", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C0")]
		public override string LocalName
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xD42654", Offset = "0xD42654", VA = "0xD42654", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C1")]
		public override string NamespaceUri
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xD4269C", Offset = "0xD4269C", VA = "0xD4269C", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C2")]
		public bool IsEmpty
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xD426E4", Offset = "0xD426E4", VA = "0xD426E4", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xD40D20", Offset = "0xD40D20", VA = "0xD40D20")]
		public XElementWrapper(XElement element)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xD41D54", Offset = "0xD41D54", VA = "0xD41D54", Slot = "21")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xD42600", Offset = "0xD42600", VA = "0xD42600", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xD425B4", Offset = "0xD425B4", VA = "0xD425B4", Slot = "22")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
