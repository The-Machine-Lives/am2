using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

[Token(Token = "0x200005C")]
public class AltTcpListener : TcpListener
{
	[Token(Token = "0x17000003")]
	public new bool Active
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xAD5AE8", Offset = "0xAD5AE8", VA = "0xAD5AE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xAD5AF0", Offset = "0xAD5AF0", VA = "0xAD5AF0")]
	public AltTcpListener(IPEndPoint localEp)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xAD49A4", Offset = "0xAD49A4", VA = "0xAD49A4")]
	public AltTcpListener(IPAddress localaddr, int port)
	{
	}
}
