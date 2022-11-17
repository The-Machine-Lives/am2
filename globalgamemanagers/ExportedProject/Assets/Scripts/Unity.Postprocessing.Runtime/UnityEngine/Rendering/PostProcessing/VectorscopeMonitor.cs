using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public sealed class VectorscopeMonitor : Monitor
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x1C")]
		public int size;

		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x20")]
		public float exposure;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x28")]
		private ComputeBuffer m_Data;

		[Token(Token = "0x40000F0")]
		private const int k_ThreadGroupSizeX = 16;

		[Token(Token = "0x40000F1")]
		private const int k_ThreadGroupSizeY = 16;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1238AF0", Offset = "0x1238AF0", VA = "0x1238AF0", Slot = "7")]
		internal override void OnDisable()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1238B28", Offset = "0x1238B28", VA = "0x1238B28", Slot = "5")]
		internal override bool NeedsHalfRes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1238B30", Offset = "0x1238B30", VA = "0x1238B30", Slot = "4")]
		internal override bool ShaderResourcesAvailable(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1238BC8", Offset = "0x1238BC8", VA = "0x1238BC8", Slot = "8")]
		internal override void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1239188", Offset = "0x1239188", VA = "0x1239188")]
		public VectorscopeMonitor()
		{
		}
	}
}
