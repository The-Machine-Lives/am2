using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818CA8", Offset = "0x818CA8")]
	public sealed class MinMaxAttribute : Attribute
	{
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x14")]
		public readonly float max;

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xD83CAC", Offset = "0xD83CAC", VA = "0xD83CAC")]
		public MinMaxAttribute(float min, float max)
		{
		}
	}
}
