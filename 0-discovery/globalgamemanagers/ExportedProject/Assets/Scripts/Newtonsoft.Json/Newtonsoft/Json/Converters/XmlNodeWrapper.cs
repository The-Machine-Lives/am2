using System.Collections.Generic;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000106")]
	internal class XmlNodeWrapper : IXmlNode
	{
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x10")]
		private readonly XmlNode _node;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x18")]
		private List<IXmlNode> _childNodes;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x20")]
		private List<IXmlNode> _attributes;

		[Token(Token = "0x1700017E")]
		public object WrappedNode
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0xD43878", Offset = "0xD43878", VA = "0xD43878", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017F")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0xD4B5F4", Offset = "0xD4B5F4", VA = "0xD4B5F4", Slot = "4")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000180")]
		public virtual string LocalName
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0xD4B628", Offset = "0xD4B628", VA = "0xD4B628", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		public List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0xD4B660", Offset = "0xD4B660", VA = "0xD4B660", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		public List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0xD4B9EC", Offset = "0xD4B9EC", VA = "0xD4B9EC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public IXmlNode ParentNode
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0xD4BDA8", Offset = "0xD4BDA8", VA = "0xD4BDA8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		public string Value
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xD4BE50", Offset = "0xD4BE50", VA = "0xD4BE50", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xD43524", Offset = "0xD43524", VA = "0xD43524", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public string NamespaceUri
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0xD4BF90", Offset = "0xD4BF90", VA = "0xD4BF90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xD42B74", Offset = "0xD42B74", VA = "0xD42B74")]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xD45D64", Offset = "0xD45D64", VA = "0xD45D64")]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xD4BE84", Offset = "0xD4BE84", VA = "0xD4BE84", Slot = "10")]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
