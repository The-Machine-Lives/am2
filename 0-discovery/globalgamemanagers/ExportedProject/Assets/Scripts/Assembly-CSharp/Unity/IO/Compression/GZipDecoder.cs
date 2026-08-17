using System;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F0")]
	internal class GZipDecoder : IFileFormatReader
	{
		[Token(Token = "0x2000879")]
		internal enum GzipHeaderState
		{
			[Token(Token = "0x4002433")]
			ReadingID1 = 0,
			[Token(Token = "0x4002434")]
			ReadingID2 = 1,
			[Token(Token = "0x4002435")]
			ReadingCM = 2,
			[Token(Token = "0x4002436")]
			ReadingFLG = 3,
			[Token(Token = "0x4002437")]
			ReadingMMTime = 4,
			[Token(Token = "0x4002438")]
			ReadingXFL = 5,
			[Token(Token = "0x4002439")]
			ReadingOS = 6,
			[Token(Token = "0x400243A")]
			ReadingXLen1 = 7,
			[Token(Token = "0x400243B")]
			ReadingXLen2 = 8,
			[Token(Token = "0x400243C")]
			ReadingXLenData = 9,
			[Token(Token = "0x400243D")]
			ReadingFileName = 10,
			[Token(Token = "0x400243E")]
			ReadingComment = 11,
			[Token(Token = "0x400243F")]
			ReadingCRC16Part1 = 12,
			[Token(Token = "0x4002440")]
			ReadingCRC16Part2 = 13,
			[Token(Token = "0x4002441")]
			Done = 14,
			[Token(Token = "0x4002442")]
			ReadingCRC = 15,
			[Token(Token = "0x4002443")]
			ReadingFileSize = 16
		}

		[Token(Token = "0x200087A")]
		[Flags]
		internal enum GZipOptionalHeaderFlags
		{
			[Token(Token = "0x4002445")]
			CRCFlag = 2,
			[Token(Token = "0x4002446")]
			ExtraFieldsFlag = 4,
			[Token(Token = "0x4002447")]
			FileNameFlag = 8,
			[Token(Token = "0x4002448")]
			CommentFlag = 0x10
		}

		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0x10")]
		private GzipHeaderState gzipHeaderSubstate;

		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x14")]
		private GzipHeaderState gzipFooterSubstate;

		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0x18")]
		private int gzip_header_flag;

		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x1C")]
		private int gzip_header_xlen;

		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x20")]
		private uint expectedCrc32;

		[Token(Token = "0x4001CAB")]
		[FieldOffset(Offset = "0x24")]
		private uint expectedOutputStreamSizeModulo;

		[Token(Token = "0x4001CAC")]
		[FieldOffset(Offset = "0x28")]
		private int loopCounter;

		[Token(Token = "0x4001CAD")]
		[FieldOffset(Offset = "0x2C")]
		private uint actualCrc32;

		[Token(Token = "0x4001CAE")]
		[FieldOffset(Offset = "0x30")]
		private long actualStreamSizeModulo;

		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0xAAEB4C", Offset = "0xAAEB4C", VA = "0xAAEB4C")]
		public GZipDecoder()
		{
		}

		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0xAAEB7C", Offset = "0xAAEB7C", VA = "0xAAEB7C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0xAAEB8C", Offset = "0xAAEB8C", VA = "0xAAEB8C", Slot = "4")]
		public bool ReadHeader(InputBuffer input)
		{
			return default(bool);
		}

		[Token(Token = "0x6002BED")]
		[Address(RVA = "0xAAF0C4", Offset = "0xAAF0C4", VA = "0xAAF0C4", Slot = "5")]
		public bool ReadFooter(InputBuffer input)
		{
			return default(bool);
		}

		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0xAAF238", Offset = "0xAAF238", VA = "0xAAF238", Slot = "6")]
		public void UpdateWithBytesRead(byte[] buffer, int offset, int copied)
		{
		}

		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0xAAF300", Offset = "0xAAF300", VA = "0xAAF300", Slot = "7")]
		public void Validate()
		{
		}
	}
}
