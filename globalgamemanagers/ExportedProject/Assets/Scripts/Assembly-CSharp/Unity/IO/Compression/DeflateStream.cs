using System;
using System.IO;
using System.Security;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005E9")]
	public class DeflateStream : Stream
	{
		[Token(Token = "0x2000877")]
		internal delegate void AsyncWriteDelegate(byte[] array, int offset, int count, bool isAsync);

		[Token(Token = "0x2000878")]
		private enum WorkerType : byte
		{
			[Token(Token = "0x4002430")]
			Managed = 0,
			[Token(Token = "0x4002431")]
			Unknown = 1
		}

		[Token(Token = "0x4001C67")]
		internal const int DefaultBufferSize = 8192;

		[Token(Token = "0x4001C68")]
		[FieldOffset(Offset = "0x28")]
		private Stream _stream;

		[Token(Token = "0x4001C69")]
		[FieldOffset(Offset = "0x30")]
		private CompressionMode _mode;

		[Token(Token = "0x4001C6A")]
		[FieldOffset(Offset = "0x34")]
		private bool _leaveOpen;

		[Token(Token = "0x4001C6B")]
		[FieldOffset(Offset = "0x38")]
		private Inflater inflater;

		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x40")]
		private IDeflater deflater;

		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x48")]
		private byte[] buffer;

		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x50")]
		private int asyncOperations;

		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x58")]
		private readonly AsyncCallback m_CallBack;

		[Token(Token = "0x4001C70")]
		[FieldOffset(Offset = "0x60")]
		private readonly AsyncWriteDelegate m_AsyncWriterDelegate;

		[Token(Token = "0x4001C71")]
		[FieldOffset(Offset = "0x68")]
		private IFileFormatWriter formatWriter;

		[Token(Token = "0x4001C72")]
		[FieldOffset(Offset = "0x70")]
		private bool wroteHeader;

		[Token(Token = "0x4001C73")]
		[FieldOffset(Offset = "0x71")]
		private bool wroteBytes;

		[Token(Token = "0x17000785")]
		public Stream BaseStream
		{
			[Token(Token = "0x6002B98")]
			[Address(RVA = "0xAA99AC", Offset = "0xAA99AC", VA = "0xAA99AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000786")]
		public override bool CanRead
		{
			[Token(Token = "0x6002B99")]
			[Address(RVA = "0xAA99B4", Offset = "0xAA99B4", VA = "0xAA99B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000787")]
		public override bool CanWrite
		{
			[Token(Token = "0x6002B9A")]
			[Address(RVA = "0xAA99DC", Offset = "0xAA99DC", VA = "0xAA99DC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000788")]
		public override bool CanSeek
		{
			[Token(Token = "0x6002B9B")]
			[Address(RVA = "0xAA9A08", Offset = "0xAA9A08", VA = "0xAA9A08", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000789")]
		public override long Length
		{
			[Token(Token = "0x6002B9C")]
			[Address(RVA = "0xAA9A10", Offset = "0xAA9A10", VA = "0xAA9A10", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700078A")]
		public override long Position
		{
			[Token(Token = "0x6002B9D")]
			[Address(RVA = "0xAA9A88", Offset = "0xAA9A88", VA = "0xAA9A88", Slot = "11")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6002B9E")]
			[Address(RVA = "0xAA9B00", Offset = "0xAA9B00", VA = "0xAA9B00", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x6002B92")]
		[Address(RVA = "0xAA94AC", Offset = "0xAA94AC", VA = "0xAA94AC")]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		[Token(Token = "0x6002B93")]
		[Address(RVA = "0xAA94B4", Offset = "0xAA94B4", VA = "0xAA94B4")]
		public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		[Token(Token = "0x6002B94")]
		[Address(RVA = "0xAA9810", Offset = "0xAA9810", VA = "0xAA9810")]
		private static IDeflater CreateDeflater()
		{
			return null;
		}

		[Token(Token = "0x6002B95")]
		[Address(RVA = "0xAA9878", Offset = "0xAA9878", VA = "0xAA9878")]
		[SecuritySafeCritical]
		private static WorkerType GetDeflaterType()
		{
			return default(WorkerType);
		}

		[Token(Token = "0x6002B96")]
		[Address(RVA = "0xAA994C", Offset = "0xAA994C", VA = "0xAA994C")]
		internal void SetFileFormatReader(IFileFormatReader reader)
		{
		}

		[Token(Token = "0x6002B97")]
		[Address(RVA = "0xAA99A0", Offset = "0xAA99A0", VA = "0xAA99A0")]
		internal void SetFileFormatWriter(IFileFormatWriter writer)
		{
		}

		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0xAA9B78", Offset = "0xAA9B78", VA = "0xAA9B78", Slot = "17")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0xAA9C10", Offset = "0xAA9C10", VA = "0xAA9C10", Slot = "24")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0xAA9C88", Offset = "0xAA9C88", VA = "0xAA9C88", Slot = "25")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6002BA2")]
		[Address(RVA = "0xAA9D00", Offset = "0xAA9D00", VA = "0xAA9D00", Slot = "26")]
		public override int Read(byte[] array, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0xAA9ED4", Offset = "0xAA9ED4", VA = "0xAA9ED4")]
		private void ValidateParameters(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0xAA9B7C", Offset = "0xAA9B7C", VA = "0xAA9B7C")]
		private void EnsureNotDisposed()
		{
		}

		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0xAA9E44", Offset = "0xAA9E44", VA = "0xAA9E44")]
		private void EnsureDecompressionMode()
		{
		}

		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0xAAA254", Offset = "0xAAA254", VA = "0xAAA254")]
		private void EnsureCompressionMode()
		{
		}

		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0xAAA2E8", Offset = "0xAAA2E8", VA = "0xAAA2E8", Slot = "18")]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0xAAA670", Offset = "0xAAA670", VA = "0xAAA670")]
		private void ReadCallback(IAsyncResult baseStreamResult)
		{
		}

		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0xAAAA7C", Offset = "0xAAAA7C", VA = "0xAAAA7C", Slot = "19")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return default(int);
		}

		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0xAAADDC", Offset = "0xAAADDC", VA = "0xAAADDC", Slot = "28")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0xAAAE3C", Offset = "0xAAAE3C", VA = "0xAAAE3C")]
		internal void InternalWrite(byte[] array, int offset, int count, bool isAsync)
		{
		}

		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0xAAB114", Offset = "0xAAB114", VA = "0xAAB114")]
		private void WriteDeflaterOutput(bool isAsync)
		{
		}

		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0xAAB284", Offset = "0xAAB284", VA = "0xAAB284")]
		private void DoWrite(byte[] array, int offset, int count, bool isAsync)
		{
		}

		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0xAAAF4C", Offset = "0xAAAF4C", VA = "0xAAAF4C")]
		private void DoMaintenance(byte[] array, int offset, int count)
		{
		}

		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0xAAB350", Offset = "0xAAB350", VA = "0xAAB350")]
		private void PurgeBuffers(bool disposing)
		{
		}

		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0xAAB574", Offset = "0xAAB574", VA = "0xAAB574", Slot = "16")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0xAAB7B8", Offset = "0xAAB7B8", VA = "0xAAB7B8", Slot = "21")]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		[Token(Token = "0x6002BB2")]
		[Address(RVA = "0xAABAA8", Offset = "0xAABAA8", VA = "0xAABAA8")]
		private void WriteCallback(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x6002BB3")]
		[Address(RVA = "0xAABD28", Offset = "0xAABD28", VA = "0xAABD28", Slot = "22")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x6002BB4")]
		[Address(RVA = "0xAAABE0", Offset = "0xAAABE0", VA = "0xAAABE0")]
		private void CheckEndXxxxLegalStateAndParams(IAsyncResult asyncResult)
		{
		}

		[Token(Token = "0x6002BB5")]
		[Address(RVA = "0xAAACF8", Offset = "0xAAACF8", VA = "0xAAACF8")]
		private void AwaitAsyncResultCompletion(DeflateStreamAsyncResult asyncResult)
		{
		}
	}
}
