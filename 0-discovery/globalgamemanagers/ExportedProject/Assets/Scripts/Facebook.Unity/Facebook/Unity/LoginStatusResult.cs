using Il2CppDummyDll;

namespace Facebook.Unity
{
	[Token(Token = "0x2000045")]
	internal class LoginStatusResult : LoginResult, ILoginStatusResult, ILoginResult, IResult
	{
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string FailedKey;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816400", Offset = "0x816400")]
		private bool _003CFailed_003Ek__BackingField;

		[Token(Token = "0x17000053")]
		public bool Failed
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0xCE0DCC", Offset = "0xCE0DCC", VA = "0xCE0DCC", Slot = "20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BA0", Offset = "0x816BA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xCE0DC0", Offset = "0xCE0DC0", VA = "0xCE0DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816BB0", Offset = "0x816BB0")]
			private set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xCE0C14", Offset = "0xCE0C14", VA = "0xCE0C14")]
		internal LoginStatusResult(ResultContainer resultContainer)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xCE0DD4", Offset = "0xCE0DD4", VA = "0xCE0DD4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
