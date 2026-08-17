using System;
using System.Collections;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

[Token(Token = "0x200005D")]
public class AltSocketServer
{
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected AltTcpListener Listener;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected readonly AltIClientSocketHandlerDelegate ClientSocketHandlerDelegate;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected readonly string SeparatorString;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly Encoding Encoding;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected ArrayList ClientHandlerThreads;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly int portNumber;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected readonly IPEndPoint localEndPoint;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected readonly int maxClients;

	[Token(Token = "0x17000004")]
	public int PortNumber
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xAD45F0", Offset = "0xAD45F0", VA = "0xAD45F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public IPEndPoint LocalEndPoint
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xAD45F8", Offset = "0xAD45F8", VA = "0xAD45F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public int MaxClients
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xAD4600", Offset = "0xAD4600", VA = "0xAD4600")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000007")]
	public int ClientCount
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xAD4608", Offset = "0xAD4608", VA = "0xAD4608")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xAD4640", Offset = "0xAD4640", VA = "0xAD4640")]
	public bool IsServerStopped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xAD47E4", Offset = "0xAD47E4", VA = "0xAD47E4")]
	public AltSocketServer(AltIClientSocketHandlerDelegate clientSocketHandlerDelegate, int portNumber = 13000, int maxClients = 1, string separatorString = "\n", [Optional] Encoding encoding)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xAD49AC", Offset = "0xAD49AC", VA = "0xAD49AC")]
	public void StartListeningForConnections()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xAD4DDC", Offset = "0xAD4DDC", VA = "0xAD4DDC")]
	protected void ListenForConnection()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xAD4E74", Offset = "0xAD4E74", VA = "0xAD4E74")]
	protected void AcceptCallback(IAsyncResult ar)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xAD5608", Offset = "0xAD5608", VA = "0xAD5608")]
	public void StopListeningForConnections()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xAD5694", Offset = "0xAD5694", VA = "0xAD5694")]
	public void Cleanup()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xAD5AD4", Offset = "0xAD5AD4", VA = "0xAD5AD4")]
	public bool IsStarted()
	{
		return default(bool);
	}
}
