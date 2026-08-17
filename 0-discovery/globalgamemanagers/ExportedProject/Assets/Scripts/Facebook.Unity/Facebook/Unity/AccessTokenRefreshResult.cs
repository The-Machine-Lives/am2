using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000023")]
	internal class AccessTokenRefreshResult : ResultBase, IAccessTokenRefreshResult, IResult
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816350", Offset = "0x816350")]
		private AccessToken _003CAccessToken_003Ek__BackingField;

		[Token(Token = "0x17000040")]
		public AccessToken AccessToken
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xCC7F6C", Offset = "0xCC7F6C", VA = "0xCC7F6C", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816A50", Offset = "0x816A50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xCC7F64", Offset = "0xCC7F64", VA = "0xCC7F64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816A60", Offset = "0x816A60")]
			private set
			{
			}
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xCC7E14", Offset = "0xCC7E14", VA = "0xCC7E14")]
		public AccessTokenRefreshResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xCC7F74", Offset = "0xCC7F74", VA = "0xCC7F74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
