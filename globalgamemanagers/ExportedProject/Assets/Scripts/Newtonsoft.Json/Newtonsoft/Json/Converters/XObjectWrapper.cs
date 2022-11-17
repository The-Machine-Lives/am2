using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000113")]
	internal class XObjectWrapper : IXmlNode
	{
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<IXmlNode> EmptyChildNodes;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x10")]
		private readonly XObject _xmlObject;

		[Token(Token = "0x170001B0")]
		public object WrappedNode
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0xD3FE64", Offset = "0xD3FE64", VA = "0xD3FE64", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B1")]
		public virtual XmlNodeType NodeType
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0xD42714", Offset = "0xD42714", VA = "0xD42714", Slot = "13")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x170001B2")]
		public virtual string LocalName
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0xD42748", Offset = "0xD42748", VA = "0xD42748", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B3")]
		public virtual List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0xD42750", Offset = "0xD42750", VA = "0xD42750", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public virtual List<IXmlNode> Attributes
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0xD427B8", Offset = "0xD427B8", VA = "0xD427B8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B5")]
		public virtual IXmlNode ParentNode
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0xD427C0", Offset = "0xD427C0", VA = "0xD427C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B6")]
		public virtual string Value
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xD427C8", Offset = "0xD427C8", VA = "0xD427C8", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B7")]
		public virtual string NamespaceUri
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xD42838", Offset = "0xD42838", VA = "0xD42838", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0xD3FEE8", Offset = "0xD3FEE8", VA = "0xD3FEE8")]
		public XObjectWrapper(XObject xmlObject)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xD427D0", Offset = "0xD427D0", VA = "0xD427D0", Slot = "19")]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
