using Il2CppDummyDll;

[Token(Token = "0x2000061")]
public abstract class AltUnityCommand
{
	[Token(Token = "0x2000605")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x820328", Offset = "0x820328")]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x4001D4B")]
		[FieldOffset(Offset = "0x10")]
		public AltUnityCommand _003C_003E4__this;

		[Token(Token = "0x4001D4C")]
		[FieldOffset(Offset = "0x18")]
		public AltClientSocketHandler handler;

		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0xAD6CC8", Offset = "0xAD6CC8", VA = "0xAD6CC8")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0xAD6CD8", Offset = "0xAD6CD8", VA = "0xAD6CD8")]
		internal void _003CSendResponse_003Eb__0()
		{
		}
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xAD6BCC", Offset = "0xAD6BCC", VA = "0xAD6BCC")]
	public void SendResponse(AltClientSocketHandler handler)
	{
	}

	[Token(Token = "0x600014E")]
	public abstract string Execute();

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xAD6CD0", Offset = "0xAD6CD0", VA = "0xAD6CD0")]
	protected AltUnityCommand()
	{
	}
}
