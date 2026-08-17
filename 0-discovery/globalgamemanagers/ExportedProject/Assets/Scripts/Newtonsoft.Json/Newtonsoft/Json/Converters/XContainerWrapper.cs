using System.Collections.Generic;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000112")]
	internal class XContainerWrapper : XObjectWrapper
	{
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;

		[Token(Token = "0x170001AD")]
		private XContainer Container
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0xD40868", Offset = "0xD40868", VA = "0xD40868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AE")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0xD409B0", Offset = "0xD409B0", VA = "0xD409B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0xD40CB4", Offset = "0xD40CB4", VA = "0xD40CB4", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0xD40934", Offset = "0xD40934", VA = "0xD40934")]
		public XContainerWrapper(XContainer container)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xD4003C", Offset = "0xD4003C", VA = "0xD4003C")]
		internal static IXmlNode WrapNode(XObject node)
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0xD40E98", Offset = "0xD40E98", VA = "0xD40E98", Slot = "19")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
