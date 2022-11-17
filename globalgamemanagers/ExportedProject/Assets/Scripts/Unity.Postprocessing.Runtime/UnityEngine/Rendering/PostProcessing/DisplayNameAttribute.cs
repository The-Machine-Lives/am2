using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818BF4", Offset = "0x818BF4")]
	public sealed class DisplayNameAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		public readonly string displayName;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xD7FAF0", Offset = "0xD7FAF0", VA = "0xD7FAF0")]
		public DisplayNameAttribute(string displayName)
		{
		}
	}
}
