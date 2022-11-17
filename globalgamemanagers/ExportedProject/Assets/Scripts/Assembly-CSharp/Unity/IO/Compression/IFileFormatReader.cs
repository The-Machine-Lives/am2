using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005EF")]
	internal interface IFileFormatReader
	{
		[Token(Token = "0x6002BE6")]
		bool ReadHeader(InputBuffer input);

		[Token(Token = "0x6002BE7")]
		bool ReadFooter(InputBuffer input);

		[Token(Token = "0x6002BE8")]
		void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

		[Token(Token = "0x6002BE9")]
		void Validate();
	}
}
