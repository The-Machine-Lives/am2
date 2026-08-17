using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x200004E")]
	internal class ShareResult : ResultBase, IShareResult, IResult
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8164C0", Offset = "0x8164C0")]
		private string _003CPostId_003Ek__BackingField;

		[Token(Token = "0x17000060")]
		public string PostId
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x17C30F4", Offset = "0x17C30F4", VA = "0x17C30F4", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D20", Offset = "0x816D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x17C30EC", Offset = "0x17C30EC", VA = "0x17C30EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816D30", Offset = "0x816D30")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		internal static string PostIDKey
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x17C308C", Offset = "0x17C308C", VA = "0x17C308C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17BD504", Offset = "0x17BD504", VA = "0x17BD504")]
		internal ShareResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17C30FC", Offset = "0x17C30FC", VA = "0x17C30FC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
