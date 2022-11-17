using System;
using System.IO;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F1")]
	public class GZipStream : Stream
	{
		[Token(Token = "0x4001CAF")]
		[FieldOffset(Offset = "0x28")]
		private DeflateStream deflateStream;

		[Token(Token = "0x17000796")]
		public override bool CanRead
		{
			[Token(Token = "0x6002BF3")]
			[Address(RVA = "0xAAF864", Offset = "0xAAF864", VA = "0xAAF864", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000797")]
		public override bool CanWrite
		{
			[Token(Token = "0x6002BF4")]
			[Address(RVA = "0xAAF87C", Offset = "0xAAF87C", VA = "0xAAF87C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000798")]
		public override bool CanSeek
		{
			[Token(Token = "0x6002BF5")]
			[Address(RVA = "0xAAF894", Offset = "0xAAF894", VA = "0xAAF894", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000799")]
		public override long Length
		{
			[Token(Token = "0x6002BF6")]
			[Address(RVA = "0xAAF8AC", Offset = "0xAAF8AC", VA = "0xAAF8AC", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700079A")]
		public override long Position
		{
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0xAAF924", Offset = "0xAAF924", VA = "0xAAF924", Slot = "11")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002BF8")]
			[Address(RVA = "0xAAF99C", Offset = "0xAAF99C", VA = "0xAAF99C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700079B")]
		public Stream BaseStream
		{
			[Token(Token = "0x6002C03")]
			[Address(RVA = "0xAB00D8", Offset = "0xAB00D8", VA = "0xAB00D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002BF0")]
		[Address(RVA = "0xAAF6BC", Offset = "0xAAF6BC", VA = "0xAAF6BC")]
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		[Token(Token = "0x6002BF1")]
		[Address(RVA = "0xAAF6C4", Offset = "0xAAF6C4", VA = "0xAAF6C4")]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		[Token(Token = "0x6002BF2")]
		[Address(RVA = "0xAAF77C", Offset = "0xAAF77C", VA = "0xAAF77C")]
		private void SetDeflateStreamFileFormatter(CompressionMode mode)
		{
		}

		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0xAAFA14", Offset = "0xAAFA14", VA = "0xAAFA14", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0xAAFAB4", Offset = "0xAAFAB4", VA = "0xAAFAB4", Slot = "24")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0xAAFB2C", Offset = "0xAAFB2C", VA = "0xAAFB2C", Slot = "25")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0xAAFBA4", Offset = "0xAAFBA4", VA = "0xAAFBA4", Slot = "18")]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0xAAFC80", Offset = "0xAAFC80", VA = "0xAAFC80", Slot = "19")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0xAAFD2C", Offset = "0xAAFD2C", VA = "0xAAFD2C", Slot = "21")]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0xAAFE08", Offset = "0xAAFE08", VA = "0xAAFE08", Slot = "22")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x6002C00")]
		[Address(RVA = "0xAAFEB4", Offset = "0xAAFEB4", VA = "0xAAFEB4", Slot = "26")]
		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6002C01")]
		[Address(RVA = "0xAAFF7C", Offset = "0xAAFF7C", VA = "0xAAFF7C", Slot = "28")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x6002C02")]
		[Address(RVA = "0xAB0044", Offset = "0xAB0044", VA = "0xAB0044", Slot = "16")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
