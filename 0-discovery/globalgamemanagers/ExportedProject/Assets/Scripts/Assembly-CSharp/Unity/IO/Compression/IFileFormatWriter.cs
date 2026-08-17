using Il2CppDummyDll;

namespace Unity.IO.Compression
{
	[Token(Token = "0x20005EE")]
	internal interface IFileFormatWriter
	{
		[Token(Token = "0x6002BE3")]
		byte[] GetHeader();

		[Token(Token = "0x6002BE4")]
		void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

		[Token(Token = "0x6002BE5")]
		byte[] GetFooter();
	}
}
