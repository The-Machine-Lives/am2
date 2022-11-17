using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	[Token(Token = "0x20000EF")]
	[Preserve]
	internal abstract class QueryExpression
	{
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x80FC68", Offset = "0x80FC68")]
		private QueryOperator _003COperator_003Ek__BackingField;

		[Token(Token = "0x17000162")]
		public QueryOperator Operator
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xD048CC", Offset = "0xD048CC", VA = "0xD048CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x811554", Offset = "0x811554")]
			get
			{
				return default(QueryOperator);
			}
		}

		[Token(Token = "0x60007A4")]
		public abstract bool IsMatch(JToken t);

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD04E38", Offset = "0xD04E38", VA = "0xD04E38")]
		protected QueryExpression()
		{
		}
	}
}
