using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F4")]
	internal class HuffmanTree
	{
		[Token(Token = "0x4001CBC")]
		internal const int MaxLiteralTreeElements = 288;

		[Token(Token = "0x4001CBD")]
		internal const int MaxDistTreeElements = 32;

		[Token(Token = "0x4001CBE")]
		internal const int EndOfBlockCode = 256;

		[Token(Token = "0x4001CBF")]
		internal const int NumberOfCodeLengthTreeElements = 19;

		[Token(Token = "0x4001CC0")]
		[FieldOffset(Offset = "0x10")]
		private int tableBits;

		[Token(Token = "0x4001CC1")]
		[FieldOffset(Offset = "0x18")]
		private short[] table;

		[Token(Token = "0x4001CC2")]
		[FieldOffset(Offset = "0x20")]
		private short[] left;

		[Token(Token = "0x4001CC3")]
		[FieldOffset(Offset = "0x28")]
		private short[] right;

		[Token(Token = "0x4001CC4")]
		[FieldOffset(Offset = "0x30")]
		private byte[] codeLengthArray;

		[Token(Token = "0x4001CC5")]
		[FieldOffset(Offset = "0x38")]
		private int tableMask;

		[Token(Token = "0x4001CC6")]
		[FieldOffset(Offset = "0x0")]
		private static HuffmanTree staticLiteralLengthTree;

		[Token(Token = "0x4001CC7")]
		[FieldOffset(Offset = "0x8")]
		private static HuffmanTree staticDistanceTree;

		[Token(Token = "0x1700079C")]
		public static HuffmanTree StaticLiteralLengthTree
		{
			[Token(Token = "0x6002C0B")]
			[Address(RVA = "0xAB03F4", Offset = "0xAB03F4", VA = "0xAB03F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079D")]
		public static HuffmanTree StaticDistanceTree
		{
			[Token(Token = "0x6002C0C")]
			[Address(RVA = "0xAB045C", Offset = "0xAB045C", VA = "0xAB045C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0xAB00F0", Offset = "0xAB00F0", VA = "0xAB00F0")]
		static HuffmanTree()
		{
		}

		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0xAB02EC", Offset = "0xAB02EC", VA = "0xAB02EC")]
		public HuffmanTree(byte[] codeLengths)
		{
		}

		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0xAB0194", Offset = "0xAB0194", VA = "0xAB0194")]
		private static byte[] GetStaticLiteralTreeLength()
		{
			return null;
		}

		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0xAB0350", Offset = "0xAB0350", VA = "0xAB0350")]
		private static byte[] GetStaticDistanceTreeLength()
		{
			return null;
		}

		[Token(Token = "0x6002C10")]
		[Address(RVA = "0xAB0810", Offset = "0xAB0810", VA = "0xAB0810")]
		private uint[] CalculateHuffmanCode()
		{
			return null;
		}

		[Token(Token = "0x6002C11")]
		[Address(RVA = "0xAB04C4", Offset = "0xAB04C4", VA = "0xAB04C4")]
		private void CreateTable()
		{
		}

		[Token(Token = "0x6002C12")]
		[Address(RVA = "0xAB0B0C", Offset = "0xAB0B0C", VA = "0xAB0B0C")]
		public int GetNextSymbol(InputBuffer input)
		{
			return default(int);
		}
	}
}
