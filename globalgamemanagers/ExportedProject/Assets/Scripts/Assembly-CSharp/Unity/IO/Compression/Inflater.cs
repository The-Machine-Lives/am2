using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F6")]
	internal class Inflater
	{
		[Token(Token = "0x4001CC8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] extraLengthBits;

		[Token(Token = "0x4001CC9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] lengthBase;

		[Token(Token = "0x4001CCA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] distanceBasePosition;

		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] codeOrder;

		[Token(Token = "0x4001CCC")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] staticDistanceTreeTable;

		[Token(Token = "0x4001CCD")]
		[FieldOffset(Offset = "0x10")]
		private OutputWindow output;

		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0x18")]
		private InputBuffer input;

		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x20")]
		private HuffmanTree literalLengthTree;

		[Token(Token = "0x4001CD0")]
		[FieldOffset(Offset = "0x28")]
		private HuffmanTree distanceTree;

		[Token(Token = "0x4001CD1")]
		[FieldOffset(Offset = "0x30")]
		private InflaterState state;

		[Token(Token = "0x4001CD2")]
		[FieldOffset(Offset = "0x34")]
		private bool hasFormatReader;

		[Token(Token = "0x4001CD3")]
		[FieldOffset(Offset = "0x38")]
		private int bfinal;

		[Token(Token = "0x4001CD4")]
		[FieldOffset(Offset = "0x3C")]
		private BlockType blockType;

		[Token(Token = "0x4001CD5")]
		[FieldOffset(Offset = "0x40")]
		private byte[] blockLengthBuffer;

		[Token(Token = "0x4001CD6")]
		[FieldOffset(Offset = "0x48")]
		private int blockLength;

		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x4C")]
		private int length;

		[Token(Token = "0x4001CD8")]
		[FieldOffset(Offset = "0x50")]
		private int distanceCode;

		[Token(Token = "0x4001CD9")]
		[FieldOffset(Offset = "0x54")]
		private int extraBits;

		[Token(Token = "0x4001CDA")]
		[FieldOffset(Offset = "0x58")]
		private int loopCounter;

		[Token(Token = "0x4001CDB")]
		[FieldOffset(Offset = "0x5C")]
		private int literalLengthCodeCount;

		[Token(Token = "0x4001CDC")]
		[FieldOffset(Offset = "0x60")]
		private int distanceCodeCount;

		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x64")]
		private int codeLengthCodeCount;

		[Token(Token = "0x4001CDE")]
		[FieldOffset(Offset = "0x68")]
		private int codeArraySize;

		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x6C")]
		private int lengthCode;

		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x70")]
		private byte[] codeList;

		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x78")]
		private byte[] codeLengthTreeCodeLength;

		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x80")]
		private HuffmanTree codeLengthTree;

		[Token(Token = "0x4001CE3")]
		[FieldOffset(Offset = "0x88")]
		private IFileFormatReader formatReader;

		[Token(Token = "0x1700079E")]
		public int AvailableOutput
		{
			[Token(Token = "0x6002C1C")]
			[Address(RVA = "0xAB0EF4", Offset = "0xAB0EF4", VA = "0xAB0EF4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6002C17")]
		[Address(RVA = "0xAA9734", Offset = "0xAA9734", VA = "0xAA9734")]
		public Inflater()
		{
		}

		[Token(Token = "0x6002C18")]
		[Address(RVA = "0xAA998C", Offset = "0xAA998C", VA = "0xAA998C")]
		internal void SetFileFormatReader(IFileFormatReader reader)
		{
		}

		[Token(Token = "0x6002C19")]
		[Address(RVA = "0xAB0ECC", Offset = "0xAB0ECC", VA = "0xAB0ECC")]
		private void Reset()
		{
		}

		[Token(Token = "0x6002C1A")]
		[Address(RVA = "0xAAA20C", Offset = "0xAAA20C", VA = "0xAAA20C")]
		public void SetInput(byte[] inputBytes, int offset, int length)
		{
		}

		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0xAAA1F8", Offset = "0xAAA1F8", VA = "0xAAA1F8")]
		public bool Finished()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0xAB0F28", Offset = "0xAB0F28", VA = "0xAB0F28")]
		public bool NeedsInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0xAAA008", Offset = "0xAAA008", VA = "0xAAA008")]
		public int Inflate(byte[] bytes, int offset, int length)
		{
			return default(int);
		}

		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0xAB1028", Offset = "0xAB1028", VA = "0xAB1028")]
		private bool Decode()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C20")]
		[Address(RVA = "0xAB2240", Offset = "0xAB2240", VA = "0xAB2240")]
		private bool DecodeUncompressedBlock(out bool end_of_block)
		{
			return default(bool);
		}

		[Token(Token = "0x6002C21")]
		[Address(RVA = "0xAB1D44", Offset = "0xAB1D44", VA = "0xAB1D44")]
		private bool DecodeBlock(out bool end_of_block_code_seen)
		{
			return default(bool);
		}

		[Token(Token = "0x6002C22")]
		[Address(RVA = "0xAB1510", Offset = "0xAB1510", VA = "0xAB1510")]
		private bool DecodeDynamicBlockHeader()
		{
			return default(bool);
		}
	}
}
