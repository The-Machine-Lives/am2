using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010A")]
	internal interface IXmlElement : IXmlNode
	{
		[Token(Token = "0x1700018E")]
		bool IsEmpty
		{
			[Token(Token = "0x600084E")]
			get;
		}

		[Token(Token = "0x600084C")]
		void SetAttributeNode(IXmlNode attribute);

		[Token(Token = "0x600084D")]
		string GetPrefixOfNamespace(string namespaceUri);
	}
}
