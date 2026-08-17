using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818C30", Offset = "0x818C30")]
	public sealed class MaxAttribute : Attribute
	{
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		public readonly float max;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xD836E4", Offset = "0xD836E4", VA = "0xD836E4")]
		public MaxAttribute(float max)
		{
		}
	}
}
