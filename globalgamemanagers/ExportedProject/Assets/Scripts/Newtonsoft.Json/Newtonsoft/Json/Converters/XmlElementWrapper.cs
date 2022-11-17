using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000103")]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;

		[Token(Token = "0x17000175")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xD438C0", Offset = "0xD438C0", VA = "0xD438C0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xD4337C", Offset = "0xD4337C", VA = "0xD4337C")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xD436F8", Offset = "0xD436F8", VA = "0xD436F8", Slot = "15")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xD43880", Offset = "0xD43880", VA = "0xD43880", Slot = "16")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}
	}
}
