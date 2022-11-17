using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000032")]
	[Preserve]
	public sealed class SubpixelMorphologicalAntialiasing
	{
		[Token(Token = "0x2000073")]
		private enum Pass
		{
			[Token(Token = "0x400028E")]
			EdgeDetection = 0,
			[Token(Token = "0x400028F")]
			BlendWeights = 3,
			[Token(Token = "0x4000290")]
			NeighborhoodBlending = 6
		}

		[Token(Token = "0x2000074")]
		public enum Quality
		{
			[Token(Token = "0x4000292")]
			Low = 0,
			[Token(Token = "0x4000293")]
			Medium = 1,
			[Token(Token = "0x4000294")]
			High = 2
		}

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81B708", Offset = "0x81B708")]
		public Quality quality;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1233918", Offset = "0x1233918", VA = "0x1233918")]
		public bool IsSupported()
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x12339BC", Offset = "0x12339BC", VA = "0x12339BC")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1233EF4", Offset = "0x1233EF4", VA = "0x1233EF4")]
		public SubpixelMorphologicalAntialiasing()
		{
		}
	}
}
