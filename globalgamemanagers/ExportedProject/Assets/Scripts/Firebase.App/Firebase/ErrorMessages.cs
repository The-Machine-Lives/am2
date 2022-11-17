using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200001F")]
	internal class ErrorMessages
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		private static string DEPENDENCY_NOT_FOUND_ERROR_ANDROID;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x8")]
		private static string DEPENDENCY_NOT_FOUND_ERROR_IOS;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x10")]
		private static string DEPENDENCY_NOT_FOUND_ERROR_GENERIC;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x18")]
		private static string DLL_NOT_FOUND_ERROR_ANDROID;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x20")]
		private static string DLL_NOT_FOUND_ERROR_IOS;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		private static string DLL_NOT_FOUND_ERROR_GENERIC;

		[Token(Token = "0x1700000E")]
		internal static string DependencyNotFoundErrorMessage
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x179A59C", Offset = "0x179A59C", VA = "0x179A59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		internal static string DllNotFoundExceptionErrorMessage
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x179A674", Offset = "0x179A674", VA = "0x179A674")]
			get
			{
				return null;
			}
		}
	}
}
