using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000044")]
	internal class LoginResult : ResultBase, ILoginResult, IResult
	{
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string UserIdKey;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string ExpirationTimestampKey;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string PermissionsKey;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string AccessTokenKey;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string GraphDomain;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8163F0", Offset = "0x8163F0")]
		private AccessToken _003CAccessToken_003Ek__BackingField;

		[Token(Token = "0x17000052")]
		public AccessToken AccessToken
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xCCD894", Offset = "0xCCD894", VA = "0xCCD894", Slot = "19")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B80", Offset = "0x816B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xCE0A08", Offset = "0xCE0A08", VA = "0xCE0A08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816B90", Offset = "0x816B90")]
			private set
			{
			}
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xCCD62C", Offset = "0xCCD62C", VA = "0xCCD62C")]
		internal LoginResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xCE0A10", Offset = "0xCE0A10", VA = "0xCE0A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
