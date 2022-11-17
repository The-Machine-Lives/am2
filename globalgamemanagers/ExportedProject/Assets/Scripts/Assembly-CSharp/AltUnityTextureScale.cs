using System.Threading;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000060")]
public class AltUnityTextureScale
{
	[Token(Token = "0x2000604")]
	public class AltUnityThreadData
	{
		[Token(Token = "0x4001D49")]
		[FieldOffset(Offset = "0x10")]
		public int start;

		[Token(Token = "0x4001D4A")]
		[FieldOffset(Offset = "0x14")]
		public int end;

		[Token(Token = "0x6002C69")]
		[Address(RVA = "0xC198F0", Offset = "0xC198F0", VA = "0xC198F0")]
		public AltUnityThreadData(int s, int e)
		{
		}
	}

	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x0")]
	private static Color[] texColors;

	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x8")]
	private static Color[] newColors;

	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x10")]
	private static int w;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x14")]
	private static float ratioX;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x18")]
	private static float ratioY;

	[Token(Token = "0x400013C")]
	[FieldOffset(Offset = "0x1C")]
	private static int w2;

	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x20")]
	private static int finishCount;

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x28")]
	private static Mutex mutex;

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xC19490", Offset = "0xC19490", VA = "0xC19490")]
	public static void Point(Texture2D tex, int newWidth, int newHeight)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xC198E8", Offset = "0xC198E8", VA = "0xC198E8")]
	public static void Bilinear(Texture2D tex, int newWidth, int newHeight)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xC19498", Offset = "0xC19498", VA = "0xC19498")]
	private static void ThreadedScale(Texture2D tex, int newWidth, int newHeight, bool useBilinear)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xC19928", Offset = "0xC19928", VA = "0xC19928")]
	public static void BilinearScale(object obj)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xC19D88", Offset = "0xC19D88", VA = "0xC19D88")]
	public static void PointScale(object obj)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xC19FE0", Offset = "0xC19FE0", VA = "0xC19FE0")]
	private static Color ColorLerpUnclamped(Color c1, Color c2, float value)
	{
		return default(Color);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xC1A044", Offset = "0xC1A044", VA = "0xC1A044")]
	public AltUnityTextureScale()
	{
	}
}
