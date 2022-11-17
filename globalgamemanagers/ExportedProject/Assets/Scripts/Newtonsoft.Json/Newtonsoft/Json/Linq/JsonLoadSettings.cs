using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000BB")]
	[Preserve]
	public class JsonLoadSettings
	{
		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x10")]
		private CommentHandling _commentHandling;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x14")]
		private LineInfoHandling _lineInfoHandling;

		[Token(Token = "0x17000105")]
		public CommentHandling CommentHandling
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xD0202C", Offset = "0xD0202C", VA = "0xD0202C")]
			get
			{
				return default(CommentHandling);
			}
		}

		[Token(Token = "0x17000106")]
		public LineInfoHandling LineInfoHandling
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xD02034", Offset = "0xD02034", VA = "0xD02034")]
			get
			{
				return default(LineInfoHandling);
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xD0203C", Offset = "0xD0203C", VA = "0xD0203C")]
		public JsonLoadSettings()
		{
		}
	}
}
