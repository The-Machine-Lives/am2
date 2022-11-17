using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200002A")]
	[Preserve]
	internal sealed class MultiScaleVO : IAmbientOcclusionMethod
	{
		[Token(Token = "0x200006E")]
		internal enum MipLevel
		{
			[Token(Token = "0x4000270")]
			Original = 0,
			[Token(Token = "0x4000271")]
			L1 = 1,
			[Token(Token = "0x4000272")]
			L2 = 2,
			[Token(Token = "0x4000273")]
			L3 = 3,
			[Token(Token = "0x4000274")]
			L4 = 4,
			[Token(Token = "0x4000275")]
			L5 = 5,
			[Token(Token = "0x4000276")]
			L6 = 6
		}

		[Token(Token = "0x200006F")]
		private enum Pass
		{
			[Token(Token = "0x4000278")]
			DepthCopy = 0,
			[Token(Token = "0x4000279")]
			CompositionDeferred = 1,
			[Token(Token = "0x400027A")]
			CompositionForward = 2,
			[Token(Token = "0x400027B")]
			DebugOverlay = 3
		}

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x10")]
		private readonly float[] m_SampleThickness;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x18")]
		private readonly float[] m_InvThicknessTable;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x20")]
		private readonly float[] m_SampleWeightTable;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x28")]
		private readonly int[] m_ScaledWidths;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x30")]
		private readonly int[] m_ScaledHeights;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x38")]
		private AmbientOcclusion m_Settings;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x40")]
		private PropertySheet m_PropertySheet;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x48")]
		private PostProcessResources m_Resources;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture m_AmbientOnlyAO;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x58")]
		private readonly RenderTargetIdentifier[] m_MRT;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xD73D14", Offset = "0xD73D14", VA = "0xD73D14")]
		public MultiScaleVO(AmbientOcclusion settings)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xD84EB4", Offset = "0xD84EB4", VA = "0xD84EB4", Slot = "4")]
		public DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xD84EBC", Offset = "0xD84EBC", VA = "0xD84EBC")]
		public void SetResources(PostProcessResources resources)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xD84EC4", Offset = "0xD84EC4", VA = "0xD84EC4")]
		private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xD8506C", Offset = "0xD8506C", VA = "0xD8506C")]
		private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xD85214", Offset = "0xD85214", VA = "0xD85214")]
		private void Release(CommandBuffer cmd, int id)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xD8524C", Offset = "0xD8524C", VA = "0xD8524C")]
		private Vector4 CalculateZBufferParams(Camera camera)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xD85314", Offset = "0xD85314", VA = "0xD85314")]
		private float CalculateTanHalfFovHeight(Camera camera)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xD8538C", Offset = "0xD8538C", VA = "0xD8538C")]
		private Vector2 GetSize(MipLevel mip)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xD85444", Offset = "0xD85444", VA = "0xD85444")]
		private Vector3 GetSizeArray(MipLevel mip)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xD85508", Offset = "0xD85508", VA = "0xD85508")]
		public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xD85B90", Offset = "0xD85B90", VA = "0xD85B90")]
		private void PushAllocCommands(CommandBuffer cmd, bool isMSAA)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xD8607C", Offset = "0xD8607C", VA = "0xD8607C")]
		private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xD86904", Offset = "0xD86904", VA = "0xD86904")]
		private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD87410", Offset = "0xD87410", VA = "0xD87410")]
		private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD879C0", Offset = "0xD879C0", VA = "0xD879C0")]
		private void PushReleaseCommands(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD87CA4", Offset = "0xD87CA4", VA = "0xD87CA4")]
		private void PreparePropertySheet(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xD87E74", Offset = "0xD87E74", VA = "0xD87E74")]
		private void CheckAOTexture(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xD881AC", Offset = "0xD881AC", VA = "0xD881AC")]
		private void PushDebug(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xD8826C", Offset = "0xD8826C", VA = "0xD8826C", Slot = "5")]
		public void RenderAfterOpaque(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xD88684", Offset = "0xD88684", VA = "0xD88684", Slot = "6")]
		public void RenderAmbientOnly(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD88810", Offset = "0xD88810", VA = "0xD88810", Slot = "7")]
		public void CompositeAmbientOnly(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD889DC", Offset = "0xD889DC", VA = "0xD889DC", Slot = "8")]
		public void Release()
		{
		}
	}
}
