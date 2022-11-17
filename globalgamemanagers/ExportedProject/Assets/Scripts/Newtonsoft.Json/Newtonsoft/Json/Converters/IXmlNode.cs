using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010B")]
	internal interface IXmlNode
	{
		[Token(Token = "0x1700018F")]
		XmlNodeType NodeType
		{
			[Token(Token = "0x600084F")]
			get;
		}

		[Token(Token = "0x17000190")]
		string LocalName
		{
			[Token(Token = "0x6000850")]
			get;
		}

		[Token(Token = "0x17000191")]
		List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000851")]
			get;
		}

		[Token(Token = "0x17000192")]
		List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000852")]
			get;
		}

		[Token(Token = "0x17000193")]
		IXmlNode ParentNode
		{
			[Token(Token = "0x6000853")]
			get;
		}

		[Token(Token = "0x17000194")]
		string Value
		{
			[Token(Token = "0x6000854")]
			get;
		}

		[Token(Token = "0x17000195")]
		string NamespaceUri
		{
			[Token(Token = "0x6000856")]
			get;
		}

		[Token(Token = "0x17000196")]
		object WrappedNode
		{
			[Token(Token = "0x6000857")]
			get;
		}

		[Token(Token = "0x6000855")]
		IXmlNode AppendChild(IXmlNode newChild);
	}
}
