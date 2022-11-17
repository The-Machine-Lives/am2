using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000021")]
	[Preserve]
	internal sealed class Dithering
	{
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x10")]
		private int m_NoiseTextureIndex;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x18")]
		private System.Random m_Random;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xD7FB1C", Offset = "0xD7FB1C", VA = "0xD7FB1C")]
		internal void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xD7FDA4", Offset = "0xD7FDA4", VA = "0xD7FDA4")]
		public Dithering()
		{
		}
	}
}
