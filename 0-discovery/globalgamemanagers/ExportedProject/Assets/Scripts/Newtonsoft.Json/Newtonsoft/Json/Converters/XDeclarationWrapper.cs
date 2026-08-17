using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010C")]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FD18", Offset = "0x80FD18")]
		private XDeclaration _003CDeclaration_003Ek__BackingField;

		[Token(Token = "0x17000197")]
		internal XDeclaration Declaration
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xD40F90", Offset = "0xD40F90", VA = "0xD40F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811734", Offset = "0x811734")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xD40F98", Offset = "0xD40F98", VA = "0xD40F98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811744", Offset = "0x811744")]
			private set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xD4101C", Offset = "0xD4101C", VA = "0xD4101C", Slot = "13")]
			get
			{
				return default(XmlNodeType);
			}
		}

		[Token(Token = "0x17000199")]
		public string Version
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xD41024", Offset = "0xD41024", VA = "0xD41024", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public string Encoding
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xD41054", Offset = "0xD41054", VA = "0xD41054", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		public string Standalone
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xD41084", Offset = "0xD41084", VA = "0xD41084", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xD40FA0", Offset = "0xD40FA0", VA = "0xD40FA0")]
		public XDeclarationWrapper(XDeclaration declaration)
		{
		}
	}
}
