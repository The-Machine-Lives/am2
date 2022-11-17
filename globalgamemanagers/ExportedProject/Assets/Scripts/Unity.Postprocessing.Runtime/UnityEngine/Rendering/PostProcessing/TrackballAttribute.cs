using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x818D20", Offset = "0x818D20")]
	public sealed class TrackballAttribute : Attribute
	{
		[Token(Token = "0x2000068")]
		public enum Mode
		{
			[Token(Token = "0x4000249")]
			None = 0,
			[Token(Token = "0x400024A")]
			Lift = 1,
			[Token(Token = "0x400024B")]
			Gamma = 2,
			[Token(Token = "0x400024C")]
			Gain = 3
		}

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		public readonly Mode mode;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x12385E4", Offset = "0x12385E4", VA = "0x12385E4")]
		public TrackballAttribute(Mode mode)
		{
		}
	}
}
