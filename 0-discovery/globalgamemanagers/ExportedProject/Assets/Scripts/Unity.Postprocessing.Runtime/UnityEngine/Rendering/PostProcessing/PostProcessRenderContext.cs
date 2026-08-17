using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000057")]
	public sealed class PostProcessRenderContext
	{
		[Token(Token = "0x2000082")]
		public enum StereoRenderingMode
		{
			[Token(Token = "0x40002B8")]
			MultiPass = 0,
			[Token(Token = "0x40002B9")]
			SinglePass = 1,
			[Token(Token = "0x40002BA")]
			SinglePassInstanced = 2,
			[Token(Token = "0x40002BB")]
			SinglePassMultiview = 3
		}

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x10")]
		private Camera m_Camera;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BCB0", Offset = "0x81BCB0")]
		private CommandBuffer _003Ccommand_003Ek__BackingField;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BCC0", Offset = "0x81BCC0")]
		private RenderTargetIdentifier _003Csource_003Ek__BackingField;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BCD0", Offset = "0x81BCD0")]
		private RenderTargetIdentifier _003Cdestination_003Ek__BackingField;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BCE0", Offset = "0x81BCE0")]
		private RenderTextureFormat _003CsourceFormat_003Ek__BackingField;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BCF0", Offset = "0x81BCF0")]
		private bool _003Cflip_003Ek__BackingField;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD00", Offset = "0x81BD00")]
		private PostProcessResources _003Cresources_003Ek__BackingField;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD10", Offset = "0x81BD10")]
		private PropertySheetFactory _003CpropertySheets_003Ek__BackingField;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD20", Offset = "0x81BD20")]
		private Dictionary<string, object> _003CuserData_003Ek__BackingField;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD30", Offset = "0x81BD30")]
		private PostProcessDebugLayer _003CdebugLayer_003Ek__BackingField;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD40", Offset = "0x81BD40")]
		private int _003Cwidth_003Ek__BackingField;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD50", Offset = "0x81BD50")]
		private int _003Cheight_003Ek__BackingField;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD60", Offset = "0x81BD60")]
		private bool _003CstereoActive_003Ek__BackingField;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD70", Offset = "0x81BD70")]
		private int _003CxrActiveEye_003Ek__BackingField;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD80", Offset = "0x81BD80")]
		private int _003CnumberOfEyes_003Ek__BackingField;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BD90", Offset = "0x81BD90")]
		private StereoRenderingMode _003CstereoRenderingMode_003Ek__BackingField;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BDA0", Offset = "0x81BDA0")]
		private int _003CscreenWidth_003Ek__BackingField;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BDB0", Offset = "0x81BDB0")]
		private int _003CscreenHeight_003Ek__BackingField;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BDC0", Offset = "0x81BDC0")]
		private bool _003CisSceneView_003Ek__BackingField;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0xBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BDD0", Offset = "0x81BDD0")]
		private PostProcessLayer.Antialiasing _003Cantialiasing_003Ek__BackingField;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BDE0", Offset = "0x81BDE0")]
		private TemporalAntialiasing _003CtemporalAntialiasing_003Ek__BackingField;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0xC8")]
		internal PropertySheet uberSheet;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0xD0")]
		internal Texture autoExposureTexture;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xD8")]
		internal LogHistogram logHistogram;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0xE0")]
		internal Texture logLut;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xE8")]
		internal AutoExposure autoExposure;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0xF0")]
		internal int bloomBufferNameID;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0xF4")]
		internal bool physicalCamera;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTextureDescriptor m_sourceDescriptor;

		[Token(Token = "0x1700000F")]
		public Camera camera
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x1228700", Offset = "0x1228700", VA = "0x1228700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x1228708", Offset = "0x1228708", VA = "0x1228708")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public CommandBuffer command
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1228914", Offset = "0x1228914", VA = "0x1228914")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C180", Offset = "0x81C180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x122891C", Offset = "0x122891C", VA = "0x122891C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C190", Offset = "0x81C190")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public RenderTargetIdentifier source
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1228924", Offset = "0x1228924", VA = "0x1228924")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1A0", Offset = "0x81C1A0")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1228940", Offset = "0x1228940", VA = "0x1228940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1B0", Offset = "0x81C1B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public RenderTargetIdentifier destination
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x1228954", Offset = "0x1228954", VA = "0x1228954")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1C0", Offset = "0x81C1C0")]
			get
			{
				return default(RenderTargetIdentifier);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x1228970", Offset = "0x1228970", VA = "0x1228970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1D0", Offset = "0x81C1D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public RenderTextureFormat sourceFormat
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x1228988", Offset = "0x1228988", VA = "0x1228988")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1E0", Offset = "0x81C1E0")]
			get
			{
				return default(RenderTextureFormat);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x1228990", Offset = "0x1228990", VA = "0x1228990")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C1F0", Offset = "0x81C1F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool flip
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1228998", Offset = "0x1228998", VA = "0x1228998")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C200", Offset = "0x81C200")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x12289A0", Offset = "0x12289A0", VA = "0x12289A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C210", Offset = "0x81C210")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public PostProcessResources resources
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x12289AC", Offset = "0x12289AC", VA = "0x12289AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C220", Offset = "0x81C220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x12289B4", Offset = "0x12289B4", VA = "0x12289B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C230", Offset = "0x81C230")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public PropertySheetFactory propertySheets
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x12289BC", Offset = "0x12289BC", VA = "0x12289BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C240", Offset = "0x81C240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x12289C4", Offset = "0x12289C4", VA = "0x12289C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C250", Offset = "0x81C250")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Dictionary<string, object> userData
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x12289CC", Offset = "0x12289CC", VA = "0x12289CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C260", Offset = "0x81C260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x12289D4", Offset = "0x12289D4", VA = "0x12289D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C270", Offset = "0x81C270")]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public PostProcessDebugLayer debugLayer
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x12289DC", Offset = "0x12289DC", VA = "0x12289DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C280", Offset = "0x81C280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x12289E4", Offset = "0x12289E4", VA = "0x12289E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C290", Offset = "0x81C290")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int width
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1228904", Offset = "0x1228904", VA = "0x1228904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2A0", Offset = "0x81C2A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x12288D0", Offset = "0x12288D0", VA = "0x12288D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2B0", Offset = "0x81C2B0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public int height
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x122890C", Offset = "0x122890C", VA = "0x122890C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2C0", Offset = "0x81C2C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x12288D8", Offset = "0x12288D8", VA = "0x12288D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2D0", Offset = "0x81C2D0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool stereoActive
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x12289EC", Offset = "0x12289EC", VA = "0x12289EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2E0", Offset = "0x81C2E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x12288F8", Offset = "0x12288F8", VA = "0x12288F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C2F0", Offset = "0x81C2F0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int xrActiveEye
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x12289F4", Offset = "0x12289F4", VA = "0x12289F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C300", Offset = "0x81C300")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x12288E0", Offset = "0x12288E0", VA = "0x12288E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C310", Offset = "0x81C310")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public int numberOfEyes
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x12289FC", Offset = "0x12289FC", VA = "0x12289FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C320", Offset = "0x81C320")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x12288C0", Offset = "0x12288C0", VA = "0x12288C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C330", Offset = "0x81C330")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public StereoRenderingMode stereoRenderingMode
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x12288C8", Offset = "0x12288C8", VA = "0x12288C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C340", Offset = "0x81C340")]
			get
			{
				return default(StereoRenderingMode);
			}
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x12288B8", Offset = "0x12288B8", VA = "0x12288B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C350", Offset = "0x81C350")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public int screenWidth
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1228A04", Offset = "0x1228A04", VA = "0x1228A04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C360", Offset = "0x81C360")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x12288E8", Offset = "0x12288E8", VA = "0x12288E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C370", Offset = "0x81C370")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public int screenHeight
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x1228A0C", Offset = "0x1228A0C", VA = "0x1228A0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C380", Offset = "0x81C380")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x12288F0", Offset = "0x12288F0", VA = "0x12288F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C390", Offset = "0x81C390")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public bool isSceneView
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x1228A14", Offset = "0x1228A14", VA = "0x1228A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3A0", Offset = "0x81C3A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x1228A1C", Offset = "0x1228A1C", VA = "0x1228A1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3B0", Offset = "0x81C3B0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public PostProcessLayer.Antialiasing antialiasing
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x1228A28", Offset = "0x1228A28", VA = "0x1228A28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3C0", Offset = "0x81C3C0")]
			get
			{
				return default(PostProcessLayer.Antialiasing);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1228A30", Offset = "0x1228A30", VA = "0x1228A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3D0", Offset = "0x81C3D0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public TemporalAntialiasing temporalAntialiasing
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1228A38", Offset = "0x1228A38", VA = "0x1228A38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3E0", Offset = "0x81C3E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1228A40", Offset = "0x1228A40", VA = "0x1228A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C3F0", Offset = "0x81C3F0")]
			internal set
			{
			}
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1228A48", Offset = "0x1228A48", VA = "0x1228A48")]
		public void Reset()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1228BC0", Offset = "0x1228BC0", VA = "0x1228BC0")]
		public bool IsTemporalAntialiasingActive()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1228C44", Offset = "0x1228C44", VA = "0x1228C44")]
		public bool IsDebugOverlayEnabled(DebugOverlay overlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1228C84", Offset = "0x1228C84", VA = "0x1228C84")]
		public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1228D0C", Offset = "0x1228D0C", VA = "0x1228D0C")]
		internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
		{
			return default(RenderTextureDescriptor);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1228EE8", Offset = "0x1228EE8", VA = "0x1228EE8")]
		public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1229098", Offset = "0x1229098", VA = "0x1229098")]
		public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1229124", Offset = "0x1229124", VA = "0x1229124")]
		public PostProcessRenderContext()
		{
		}
	}
}
