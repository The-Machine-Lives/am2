using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000104")]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDeclaration _declaration;

		[Token(Token = "0x17000176")]
		public string Version
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0xD42BA0", Offset = "0xD42BA0", VA = "0xD42BA0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		public string Encoding
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0xD42BD0", Offset = "0xD42BD0", VA = "0xD42BD0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000178")]
		public string Standalone
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0xD42C00", Offset = "0xD42C00", VA = "0xD42C00", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD42B44", Offset = "0xD42B44", VA = "0xD42B44")]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}
	}
}
