using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200002B")]
	[Preserve]
	internal sealed class ScalableAO : IAmbientOcclusionMethod
	{
		[Token(Token = "0x2000070")]
		private enum Pass
		{
			[Token(Token = "0x400027D")]
			OcclusionEstimationForward = 0,
			[Token(Token = "0x400027E")]
			OcclusionEstimationDeferred = 1,
			[Token(Token = "0x400027F")]
			HorizontalBlurForward = 2,
			[Token(Token = "0x4000280")]
			HorizontalBlurDeferred = 3,
			[Token(Token = "0x4000281")]
			VerticalBlur = 4,
			[Token(Token = "0x4000282")]
			CompositionForward = 5,
			[Token(Token = "0x4000283")]
			CompositionDeferred = 6,
			[Token(Token = "0x4000284")]
			DebugOverlay = 7
		}

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10")]
		private RenderTexture m_Result;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		private PropertySheet m_PropertySheet;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x20")]
		private AmbientOcclusion m_Settings;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x28")]
		private readonly RenderTargetIdentifier[] m_MRT;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x30")]
		private readonly int[] m_SampleCount;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x122EE50", Offset = "0x122EE50", VA = "0x122EE50")]
		public ScalableAO(AmbientOcclusion settings)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x122EFB8", Offset = "0x122EFB8", VA = "0x122EFB8", Slot = "4")]
		public DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x122EFC0", Offset = "0x122EFC0", VA = "0x122EFC0")]
		private void DoLazyInitialization(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x122F238", Offset = "0x122F238", VA = "0x122F238")]
		private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x122F918", Offset = "0x122F918", VA = "0x122F918", Slot = "5")]
		public void RenderAfterOpaque(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x122FAE4", Offset = "0x122FAE4", VA = "0x122FAE4", Slot = "6")]
		public void RenderAmbientOnly(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x122FBC4", Offset = "0x122FBC4", VA = "0x122FBC4", Slot = "7")]
		public void CompositeAmbientOnly(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x122FD84", Offset = "0x122FD84", VA = "0x122FD84", Slot = "8")]
		public void Release()
		{
		}
	}
}
