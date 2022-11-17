using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000111")]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		[Token(Token = "0x170001AA")]
		private XProcessingInstruction ProcessingInstruction
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0xD428B4", Offset = "0xD428B4", VA = "0xD428B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AB")]
		public override string LocalName
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0xD42980", Offset = "0xD42980", VA = "0xD42980", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AC")]
		public override string Value
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0xD429B0", Offset = "0xD429B0", VA = "0xD429B0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0xD40D24", Offset = "0xD40D24", VA = "0xD40D24")]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
		}
	}
}
