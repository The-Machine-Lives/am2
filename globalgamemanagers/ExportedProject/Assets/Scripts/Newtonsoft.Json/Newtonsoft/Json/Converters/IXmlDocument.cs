using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000107")]
	internal interface IXmlDocument : IXmlNode
	{
		[Token(Token = "0x17000186")]
		IXmlElement DocumentElement
		{
			[Token(Token = "0x6000844")]
			get;
		}

		[Token(Token = "0x6000838")]
		IXmlNode CreateComment(string text);

		[Token(Token = "0x6000839")]
		IXmlNode CreateTextNode(string text);

		[Token(Token = "0x600083A")]
		IXmlNode CreateCDataSection(string data);

		[Token(Token = "0x600083B")]
		IXmlNode CreateWhitespace(string text);

		[Token(Token = "0x600083C")]
		IXmlNode CreateSignificantWhitespace(string text);

		[Token(Token = "0x600083D")]
		IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

		[Token(Token = "0x600083E")]
		IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

		[Token(Token = "0x600083F")]
		IXmlNode CreateProcessingInstruction(string target, string data);

		[Token(Token = "0x6000840")]
		IXmlElement CreateElement(string elementName);

		[Token(Token = "0x6000841")]
		IXmlElement CreateElement(string qualifiedName, string namespaceUri);

		[Token(Token = "0x6000842")]
		IXmlNode CreateAttribute(string name, string value);

		[Token(Token = "0x6000843")]
		IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);
	}
}
