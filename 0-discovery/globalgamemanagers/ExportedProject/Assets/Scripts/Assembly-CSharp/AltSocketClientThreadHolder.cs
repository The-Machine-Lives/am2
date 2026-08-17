using System.Threading;
using Il2CppDummyDll;

[Token(Token = "0x200005B")]
public class AltSocketClientThreadHolder
{
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x10")]
	protected readonly Thread thread;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x18")]
	protected readonly AltClientSocketHandler handler;

	[Token(Token = "0x17000001")]
	public Thread Thread
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xAD45A8", Offset = "0xAD45A8", VA = "0xAD45A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public AltClientSocketHandler Handler
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xAD45B0", Offset = "0xAD45B0", VA = "0xAD45B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xAD45B8", Offset = "0xAD45B8", VA = "0xAD45B8")]
	public AltSocketClientThreadHolder(Thread thread, AltClientSocketHandler handler)
	{
	}
}
