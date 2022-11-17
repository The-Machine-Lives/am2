using System;
using Il2CppDummyDll;

namespace Firebase
{
	[Token(Token = "0x200001D")]
	public sealed class InitializationException : Exception
	{
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D228", Offset = "0x80D228")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x80D228", Offset = "0x80D228")]
		private InitResult _003CInitResult_003Ek__BackingField;

		[Token(Token = "0x1700000C")]
		public InitResult InitResult
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x179E1D4", Offset = "0x179E1D4", VA = "0x179E1D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80D9F4", Offset = "0x80D9F4")]
			get
			{
				return default(InitResult);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x17A0498", Offset = "0x17A0498", VA = "0x17A0498")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80DA04", Offset = "0x80DA04")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x179B074", Offset = "0x179B074", VA = "0x179B074")]
		public InitializationException(InitResult result, string message)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x179D1E8", Offset = "0x179D1E8", VA = "0x179D1E8")]
		public InitializationException(InitResult result, string message, Exception inner)
		{
		}
	}
}
