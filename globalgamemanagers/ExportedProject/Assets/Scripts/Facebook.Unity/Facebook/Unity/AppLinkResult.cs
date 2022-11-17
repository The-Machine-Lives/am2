using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000024")]
	internal class AppLinkResult : ResultBase, IAppLinkResult, IResult
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816360", Offset = "0x816360")]
		private string _003CUrl_003Ek__BackingField;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816370", Offset = "0x816370")]
		private string _003CTargetUrl_003Ek__BackingField;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816380", Offset = "0x816380")]
		private string _003CRef_003Ek__BackingField;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816390", Offset = "0x816390")]
		private IDictionary<string, object> _003CExtras_003Ek__BackingField;

		[Token(Token = "0x17000041")]
		public string Url
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xCC81F4", Offset = "0xCC81F4", VA = "0xCC81F4", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816A70", Offset = "0x816A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xCC81D4", Offset = "0xCC81D4", VA = "0xCC81D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816A80", Offset = "0x816A80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public string TargetUrl
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xCC81FC", Offset = "0xCC81FC", VA = "0xCC81FC", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816A90", Offset = "0x816A90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xCC81DC", Offset = "0xCC81DC", VA = "0xCC81DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AA0", Offset = "0x816AA0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public string Ref
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0xCC8204", Offset = "0xCC8204", VA = "0xCC8204", Slot = "21")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AB0", Offset = "0x816AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0xCC81E4", Offset = "0xCC81E4", VA = "0xCC81E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AC0", Offset = "0x816AC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public IDictionary<string, object> Extras
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xCC820C", Offset = "0xCC820C", VA = "0xCC820C", Slot = "22")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AD0", Offset = "0x816AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xCC81EC", Offset = "0xCC81EC", VA = "0xCC81EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816AE0", Offset = "0x816AE0")]
			private set
			{
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xCC8070", Offset = "0xCC8070", VA = "0xCC8070")]
		public AppLinkResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xCC8214", Offset = "0xCC8214", VA = "0xCC8214", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
