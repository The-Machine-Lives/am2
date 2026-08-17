using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000110")]
	internal class XCommentWrapper : XObjectWrapper
	{
		[Token(Token = "0x170001A7")]
		private XComment Text
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xD40688", Offset = "0xD40688", VA = "0xD40688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A8")]
		public override string Value
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0xD407D0", Offset = "0xD407D0", VA = "0xD407D0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A9")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x600087D")]
			[Address(RVA = "0xD40800", Offset = "0xD40800", VA = "0xD40800", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0xD40754", Offset = "0xD40754", VA = "0xD40754")]
		public XCommentWrapper(XComment text)
		{
		}
	}
}
