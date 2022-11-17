using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000F0")]
	[Preserve]
	internal class CompositeExpression : QueryExpression
	{
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC78", Offset = "0x80FC78")]
		private List<QueryExpression> _003CExpressions_003Ek__BackingField;

		[Token(Token = "0x17000163")]
		public List<QueryExpression> Expressions
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xD04E40", Offset = "0xD04E40", VA = "0xD04E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811564", Offset = "0x811564")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xD04E48", Offset = "0xD04E48", VA = "0xD04E48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811574", Offset = "0x811574")]
			set
			{
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD04E50", Offset = "0xD04E50", VA = "0xD04E50")]
		public CompositeExpression()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD04EC4", Offset = "0xD04EC4", VA = "0xD04EC4", Slot = "4")]
		public override bool IsMatch(JToken t)
		{
			return default(bool);
		}
	}
}
