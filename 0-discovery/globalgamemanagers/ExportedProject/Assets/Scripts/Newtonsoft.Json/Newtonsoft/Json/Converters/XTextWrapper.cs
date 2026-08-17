using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010F")]
	internal class XTextWrapper : XObjectWrapper
	{
		[Token(Token = "0x170001A4")]
		private XText Text
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xD429E0", Offset = "0xD429E0", VA = "0xD429E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A5")]
		public override string Value
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xD42AAC", Offset = "0xD42AAC", VA = "0xD42AAC", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		public override IXmlNode ParentNode
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xD42ADC", Offset = "0xD42ADC", VA = "0xD42ADC", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xD40DA0", Offset = "0xD40DA0", VA = "0xD40DA0")]
		public XTextWrapper(XText text)
		{
		}
	}
}
