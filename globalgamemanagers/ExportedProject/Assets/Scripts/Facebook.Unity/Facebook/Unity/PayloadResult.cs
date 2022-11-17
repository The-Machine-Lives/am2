using System.Collections.Generic;
using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000046")]
	internal class PayloadResult : ResultBase, IPayloadResult, IResult
	{
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816410", Offset = "0x816410")]
		private IDictionary<string, string> _003CPayload_003Ek__BackingField;

		[Token(Token = "0x17000054")]
		public IDictionary<string, string> Payload
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x17C0868", Offset = "0x17C0868", VA = "0x17C0868", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BC0", Offset = "0x816BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x17C0860", Offset = "0x17C0860", VA = "0x17C0860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BD0", Offset = "0x816BD0")]
			private set
			{
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x17BE1B4", Offset = "0x17BE1B4", VA = "0x17BE1B4")]
		public PayloadResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x17C0870", Offset = "0x17C0870", VA = "0x17C0870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
