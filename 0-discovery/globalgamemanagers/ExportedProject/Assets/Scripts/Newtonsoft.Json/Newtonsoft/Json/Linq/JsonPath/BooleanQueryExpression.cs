using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000F1")]
	[Preserve]
	internal class BooleanQueryExpression : QueryExpression
	{
		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC88", Offset = "0x80FC88")]
		private List<PathFilter> _003CPath_003Ek__BackingField;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC98", Offset = "0x80FC98")]
		private JValue _003CValue_003Ek__BackingField;

		[Token(Token = "0x17000164")]
		public List<PathFilter> Path
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xD042DC", Offset = "0xD042DC", VA = "0xD042DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811584", Offset = "0x811584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		public JValue Value
		{
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0xD042E4", Offset = "0xD042E4", VA = "0xD042E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811594", Offset = "0x811594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD042EC", Offset = "0xD042EC", VA = "0xD042EC", Slot = "4")]
		public override bool IsMatch(JToken t)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD048D4", Offset = "0xD048D4", VA = "0xD048D4")]
		private bool EqualsWithStringCoercion(JValue value, JValue queryValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD04E30", Offset = "0xD04E30", VA = "0xD04E30")]
		public BooleanQueryExpression()
		{
		}
	}
}
