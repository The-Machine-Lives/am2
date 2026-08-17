using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x200004E")]
	public sealed class PostProcessDebugLayer
	{
		[Serializable]
		[Token(Token = "0x2000077")]
		public class OverlaySettings
		{
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x10")]
			public bool linearDepth;

			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81BFA4", Offset = "0x81BFA4")]
			public float motionColorIntensity;

			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81BFBC", Offset = "0x81BFBC")]
			public int motionGridSize;

			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x1C")]
			public ColorBlindnessType colorBlindnessType;

			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x81BFD8", Offset = "0x81BFD8")]
			public float colorBlindnessStrength;

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xD8AD24", Offset = "0xD8AD24", VA = "0xD8AD24")]
			public OverlaySettings()
			{
			}
		}

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		public LightMeterMonitor lightMeter;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		public HistogramMonitor histogram;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		public WaveformMonitor waveform;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		public VectorscopeMonitor vectorscope;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<MonitorType, Monitor> m_Monitors;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x38")]
		private int frameWidth;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x3C")]
		private int frameHeight;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB58", Offset = "0x81BB58")]
		private RenderTexture _003CdebugOverlayTarget_003Ek__BackingField;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB68", Offset = "0x81BB68")]
		private bool _003CdebugOverlayActive_003Ek__BackingField;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB78", Offset = "0x81BB78")]
		private DebugOverlay _003CdebugOverlay_003Ek__BackingField;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x50")]
		public OverlaySettings overlaySettings;

		[Token(Token = "0x17000007")]
		public RenderTexture debugOverlayTarget
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xD893C8", Offset = "0xD893C8", VA = "0xD893C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C090", Offset = "0x81C090")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xD89700", Offset = "0xD89700", VA = "0xD89700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0A0", Offset = "0x81C0A0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool debugOverlayActive
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xD893C0", Offset = "0xD893C0", VA = "0xD893C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0B0", Offset = "0x81C0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xD89708", Offset = "0xD89708", VA = "0xD89708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0C0", Offset = "0x81C0C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public DebugOverlay debugOverlay
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xD89714", Offset = "0xD89714", VA = "0xD89714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0D0", Offset = "0x81C0D0")]
			get
			{
				return default(DebugOverlay);
			}
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xD8971C", Offset = "0xD8971C", VA = "0xD8971C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0E0", Offset = "0x81C0E0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xD89724", Offset = "0xD89724", VA = "0xD89724")]
		internal void OnEnable()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD899F4", Offset = "0xD899F4", VA = "0xD899F4")]
		internal void OnDisable()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD89B5C", Offset = "0xD89B5C", VA = "0xD89B5C")]
		private void DestroyDebugOverlayTarget()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD891E0", Offset = "0xD891E0", VA = "0xD891E0")]
		public void RequestMonitorPass(MonitorType monitor)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD89268", Offset = "0xD89268", VA = "0xD89268")]
		public void RequestDebugOverlay(DebugOverlay mode)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD89BD0", Offset = "0xD89BD0", VA = "0xD89BD0")]
		internal void SetFrameSize(int width, int height)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD89BDC", Offset = "0xD89BDC", VA = "0xD89BDC")]
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD89F10", Offset = "0xD89F10", VA = "0xD89F10")]
		internal DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD89F44", Offset = "0xD89F44", VA = "0xD89F44")]
		internal void RenderMonitors(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD8A438", Offset = "0xD8A438", VA = "0xD8A438")]
		internal void RenderSpecialOverlays(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD8ABB4", Offset = "0xD8ABB4", VA = "0xD8ABB4")]
		internal void EndFrame()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD8AD1C", Offset = "0xD8AD1C", VA = "0xD8AD1C")]
		public PostProcessDebugLayer()
		{
		}
	}
}
