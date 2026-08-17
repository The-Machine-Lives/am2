using System;
using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005F5")]
	internal interface IDeflater : IDisposable
	{
		[Token(Token = "0x6002C13")]
		bool NeedsInput();

		[Token(Token = "0x6002C14")]
		void SetInput(byte[] inputBuffer, int startIndex, int count);

		[Token(Token = "0x6002C15")]
		int GetDeflateOutput(byte[] outputBuffer);

		[Token(Token = "0x6002C16")]
		bool Finish(byte[] outputBuffer, out int bytesRead);
	}
}
