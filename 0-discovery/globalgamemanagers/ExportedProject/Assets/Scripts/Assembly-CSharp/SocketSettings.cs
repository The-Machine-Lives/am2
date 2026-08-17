using System.Net.Sockets;
using Il2CppDummyDll;

[Token(Token = "0x200000F")]
public struct SocketSettings
{
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x0")]
	public TcpClient socket;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x8")]
	public string requestSeparator;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x10")]
	public string requestEnding;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x18")]
	public bool logFlag;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x89BAB0", Offset = "0x89BAB0", VA = "0x89BAB0")]
	public SocketSettings(TcpClient socket, string requestSeparator, string requestEnding, bool logFlag)
	{
	}
}
