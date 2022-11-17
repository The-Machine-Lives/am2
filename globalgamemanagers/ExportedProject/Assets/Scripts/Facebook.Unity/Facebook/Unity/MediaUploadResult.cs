using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000068")]
	internal class MediaUploadResult : ResultBase, IMediaUploadResult, IResult
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8165F0", Offset = "0x8165F0")]
		private string _003CMediaId_003Ek__BackingField;

		[Token(Token = "0x17000079")]
		public string MediaId
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xCE0F48", Offset = "0xCE0F48", VA = "0xCE0F48", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817020", Offset = "0x817020")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0xCE0F40", Offset = "0xCE0F40", VA = "0xCE0F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817030", Offset = "0x817030")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xCD5684", Offset = "0xCD5684", VA = "0xCD5684")]
		internal MediaUploadResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xCE0F50", Offset = "0xCE0F50", VA = "0xCE0F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
