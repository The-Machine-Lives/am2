using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200003D")]
	public sealed class WaveformMonitor : Monitor
	{
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x1C")]
		public float exposure;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x20")]
		public int height;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_Data;

		[Token(Token = "0x40000F5")]
		private const int k_ThreadGroupSize = 256;

		[Token(Token = "0x40000F6")]
		private const int k_ThreadGroupSizeX = 16;

		[Token(Token = "0x40000F7")]
		private const int k_ThreadGroupSizeY = 16;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1239AC0", Offset = "0x1239AC0", VA = "0x1239AC0", Slot = "7")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1239AF8", Offset = "0x1239AF8", VA = "0x1239AF8", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1239B00", Offset = "0x1239B00", VA = "0x1239B00", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1239B98", Offset = "0x1239B98", VA = "0x1239B98", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x123A2C4", Offset = "0x123A2C4", VA = "0x123A2C4")]
		public WaveformMonitor()
		{
		}
	}
}
