using System;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005E8")]
	internal class DeflaterManaged : IDeflater, IDisposable
	{
		[Token(Token = "0x2000876")]
		private enum DeflaterState
		{
			[Token(Token = "0x4002428")]
			NotStarted = 0,
			[Token(Token = "0x4002429")]
			SlowDownForIncompressible1 = 1,
			[Token(Token = "0x400242A")]
			SlowDownForIncompressible2 = 2,
			[Token(Token = "0x400242B")]
			StartingSmallData = 3,
			[Token(Token = "0x400242C")]
			CompressThenCheck = 4,
			[Token(Token = "0x400242D")]
			CheckingForIncompressible = 5,
			[Token(Token = "0x400242E")]
			HandlingSmallData = 6
		}

		[Token(Token = "0x4001C5D")]
		private const int MinBlockSize = 256;

		[Token(Token = "0x4001C5E")]
		private const int MaxHeaderFooterGoo = 120;

		[Token(Token = "0x4001C5F")]
		private const int CleanCopySize = 8072;

		[Token(Token = "0x4001C60")]
		private const double BadCompressionThreshold = 1.0;

		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x10")]
		private FastEncoder deflateEncoder;

		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x18")]
		private CopyEncoder copyEncoder;

		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0x20")]
		private DeflateInput input;

		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x28")]
		private OutputBuffer output;

		[Token(Token = "0x4001C65")]
		[FieldOffset(Offset = "0x30")]
		private DeflaterState processingState;

		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0x38")]
		private DeflateInput inputFromHistory;

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0xAA9880", Offset = "0xAA9880", VA = "0xAA9880")]
		internal DeflaterManaged()
		{
		}

		[Token(Token = "0x6002B88")]
		[Address(RVA = "0xAACAC0", Offset = "0xAACAC0", VA = "0xAACAC0")]
		private bool NeedsInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B89")]
		[Address(RVA = "0xAACB64", Offset = "0xAACB64", VA = "0xAACB64", Slot = "4")]
		private bool Unity_002EIO_002ECompression_002EIDeflater_002ENeedsInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0xAACBFC", Offset = "0xAACBFC", VA = "0xAACBFC", Slot = "5")]
		private void Unity_002EIO_002ECompression_002EIDeflater_002ESetInput(byte[] inputBuffer, int startIndex, int count)
		{
		}

		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0xAACCA4", Offset = "0xAACCA4", VA = "0xAACCA4", Slot = "6")]
		private int Unity_002EIO_002ECompression_002EIDeflater_002EGetDeflateOutput(byte[] outputBuffer)
		{
			return default(int);
		}

		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0xAAD1A4", Offset = "0xAAD1A4", VA = "0xAAD1A4", Slot = "7")]
		private bool Unity_002EIO_002ECompression_002EIDeflater_002EFinish(byte[] outputBuffer, out int bytesRead)
		{
			return default(bool);
		}

		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0xAAD28C", Offset = "0xAAD28C", VA = "0xAAD28C", Slot = "8")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0xAAD290", Offset = "0xAAD290", VA = "0xAAD290")]
		protected void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0xAAD0A4", Offset = "0xAAD0A4", VA = "0xAAD0A4")]
		private bool UseCompressed(double ratio)
		{
			return default(bool);
		}

		[Token(Token = "0x6002B90")]
		[Address(RVA = "0xAAD0C4", Offset = "0xAAD0C4", VA = "0xAAD0C4")]
		private void FlushInputWindows()
		{
		}

		[Token(Token = "0x6002B91")]
		[Address(RVA = "0xAAD250", Offset = "0xAAD250", VA = "0xAAD250")]
		private void WriteFinal()
		{
		}
	}
}
