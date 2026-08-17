using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public sealed class HistogramMonitor : Monitor
	{
		[Token(Token = "0x2000076")]
		public enum Channel
		{
			[Token(Token = "0x4000299")]
			Red = 0,
			[Token(Token = "0x400029A")]
			Green = 1,
			[Token(Token = "0x400029B")]
			Blue = 2,
			[Token(Token = "0x400029C")]
			Master = 3
		}

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x1C")]
		public int width;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		public int height;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x24")]
		public Channel channel;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_Data;

		[Token(Token = "0x40000E0")]
		private const int k_NumBins = 256;

		[Token(Token = "0x40000E1")]
		private const int k_ThreadGroupSizeX = 16;

		[Token(Token = "0x40000E2")]
		private const int k_ThreadGroupSizeY = 16;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD81AB4", Offset = "0xD81AB4", VA = "0xD81AB4", Slot = "7")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD81B54", Offset = "0xD81B54", VA = "0xD81B54", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD81B5C", Offset = "0xD81B5C", VA = "0xD81B5C", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD81BFC", Offset = "0xD81BFC", VA = "0xD81BFC", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD82420", Offset = "0xD82420", VA = "0xD82420")]
		public HistogramMonitor()
		{
		}
	}
}
