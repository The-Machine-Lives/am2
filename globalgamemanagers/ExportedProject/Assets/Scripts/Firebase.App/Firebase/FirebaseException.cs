using System;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200001E")]
	public sealed class FirebaseException : Exception
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80D264", Offset = "0x80D264")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D264", Offset = "0x80D264")]
		private int _003CErrorCode_003Ek__BackingField;

		[Token(Token = "0x1700000D")]
		private int ErrorCode
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x179EB40", Offset = "0x179EB40", VA = "0x179EB40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DA14", Offset = "0x80DA14")]
			set
			{
			}
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x179EABC", Offset = "0x179EABC", VA = "0x179EABC")]
		public FirebaseException(int errorCode, string message)
		{
		}
	}
}
