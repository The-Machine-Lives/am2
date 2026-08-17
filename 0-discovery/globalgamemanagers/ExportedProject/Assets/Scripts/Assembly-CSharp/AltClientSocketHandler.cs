using System.Net.Sockets;
using System.Text;
using Il2CppDummyDll;

[Token(Token = "0x2000058")]
public class AltClientSocketHandler
{
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x10")]
	protected readonly TcpClient Client;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x18")]
	protected readonly string SeparatorSequence;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	protected readonly char[] SeparatorSequenceChars;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	protected readonly Encoding Encoding;

	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x30")]
	protected AltIClientSocketHandlerDelegate ClientSocketHandlerDelegate;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x38")]
	public bool ToBeKilled;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xAD31AC", Offset = "0xAD31AC", VA = "0xAD31AC")]
	public AltClientSocketHandler(TcpClient client, AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, string separatorString, Encoding encoding)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xAD321C", Offset = "0xAD321C", VA = "0xAD321C")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xAD323C", Offset = "0xAD323C", VA = "0xAD323C")]
	public void SendResponse(string response)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xAD35DC", Offset = "0xAD35DC", VA = "0xAD35DC")]
	public void SendResponse(byte[] response)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xAD382C", Offset = "0xAD382C", VA = "0xAD382C")]
	public void Run()
	{
	}
}
