using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818C6C", Offset = "0x818C6C")]
	public sealed class MinAttribute : Attribute
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xD83C78", Offset = "0xD83C78", VA = "0xD83C78")]
		public MinAttribute(float min)
		{
		}
	}
}
