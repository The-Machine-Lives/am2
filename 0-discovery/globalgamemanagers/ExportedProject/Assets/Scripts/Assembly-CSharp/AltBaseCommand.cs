using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000011")]
public class AltBaseCommand
{
	[Serializable]
	[Token(Token = "0x20005FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8202E8", Offset = "0x8202E8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001D31")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001D32")]
		[FieldOffset(Offset = "0x8")]
		public static Func<byte[], IEnumerable<byte>> _003C_003E9__4_0;

		[Token(Token = "0x6002C55")]
		[Address(RVA = "0xAD319C", Offset = "0xAD319C", VA = "0xAD319C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002C56")]
		[Address(RVA = "0xAD31A4", Offset = "0xAD31A4", VA = "0xAD31A4")]
		internal IEnumerable<byte> _003CRecvall_003Eb__4_0(byte[] x)
		{
			return null;
		}
	}

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x0")]
	private static int BUFFER_SIZE;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x10")]
	protected SocketSettings SocketSettings;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x30")]
	protected TcpClient Socket;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xAD182C", Offset = "0xAD182C", VA = "0xAD182C")]
	public AltBaseCommand(SocketSettings socketSettings)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xAD1864", Offset = "0xAD1864", VA = "0xAD1864")]
	public string Recvall()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xAD1F80", Offset = "0xAD1F80", VA = "0xAD1F80")]
	protected void WriteInLogFile(string logMessage)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xAD2028", Offset = "0xAD2028", VA = "0xAD2028")]
	public string CreateCommand(params string[] arguments)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xAD20F0", Offset = "0xAD20F0", VA = "0xAD20F0")]
	protected byte[] toBytes(string text)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xAD1F3C", Offset = "0xAD1F3C", VA = "0xAD1F3C")]
	protected string fromBytes(byte[] text)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xAD2134", Offset = "0xAD2134", VA = "0xAD2134")]
	protected string PositionToJson(AltUnityVector2 position)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xAD2214", Offset = "0xAD2214", VA = "0xAD2214")]
	protected string PositionToJson(float x, float y)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xAD2244", Offset = "0xAD2244", VA = "0xAD2244")]
	public static void HandleErrors(string data)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xAD2748", Offset = "0xAD2748", VA = "0xAD2748")]
	public AltUnityTextureInformation ReceiveImage()
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xAD2C10", Offset = "0xAD2C10", VA = "0xAD2C10")]
	public static byte[] DeCompressScreenshot(byte[] screenshotCompressed)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	public static T[] SubArray<T>(T[] data, int index, long length)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xAD3004", Offset = "0xAD3004", VA = "0xAD3004")]
	public static void CopyTo(Stream src, Stream dest)
	{
	}
}
