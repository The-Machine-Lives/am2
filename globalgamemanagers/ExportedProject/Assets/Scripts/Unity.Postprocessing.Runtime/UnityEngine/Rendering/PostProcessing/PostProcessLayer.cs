using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000054")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x819420", Offset = "0x819420")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x819420", Offset = "0x819420")]
	public sealed class PostProcessLayer : MonoBehaviour
	{
		[Token(Token = "0x2000079")]
		public enum Antialiasing
		{
			[Token(Token = "0x40002A6")]
			None = 0,
			[Token(Token = "0x40002A7")]
			FastApproximateAntialiasing = 1,
			[Token(Token = "0x40002A8")]
			SubpixelMorphologicalAntialiasing = 2,
			[Token(Token = "0x40002A9")]
			TemporalAntialiasing = 3
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public sealed class SerializedBundleRef
		{
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x10")]
			public string assemblyQualifiedName;

			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x18")]
			public PostProcessBundle bundle;

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x122527C", Offset = "0x122527C", VA = "0x122527C")]
			public SerializedBundleRef()
			{
			}
		}

		[Token(Token = "0x200007B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81956C", Offset = "0x81956C")]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			[Token(Token = "0x40002AC")]
			[FieldOffset(Offset = "0x10")]
			public PostProcessEvent evt;

			[Token(Token = "0x40002AD")]
			[FieldOffset(Offset = "0x18")]
			public List<PostProcessBundle> effects;

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x1224F68", Offset = "0x1224F68", VA = "0x1224F68")]
			public _003C_003Ec__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1224F70", Offset = "0x1224F70", VA = "0x1224F70")]
			internal bool _003CUpdateBundleSortList_003Eb__0(KeyValuePair<Type, PostProcessBundle> kvp)
			{
				return default(bool);
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x1225050", Offset = "0x1225050", VA = "0x1225050")]
			internal bool _003CUpdateBundleSortList_003Eb__2(SerializedBundleRef x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81957C", Offset = "0x81957C")]
		private sealed class _003C_003Ec__DisplayClass52_1
		{
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x10")]
			public string searchStr;

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x122513C", Offset = "0x122513C", VA = "0x122513C")]
			public _003C_003Ec__DisplayClass52_1()
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1225144", Offset = "0x1225144", VA = "0x1225144")]
			internal bool _003CUpdateBundleSortList_003Eb__3(PostProcessBundle b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81958C", Offset = "0x81958C")]
		private sealed class _003C_003Ec__DisplayClass52_2
		{
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x12251BC", Offset = "0x12251BC", VA = "0x12251BC")]
			public _003C_003Ec__DisplayClass52_2()
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x12251C4", Offset = "0x12251C4", VA = "0x12251C4")]
			internal bool _003CUpdateBundleSortList_003Eb__4(SerializedBundleRef b)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81959C", Offset = "0x81959C")]
		private sealed class _003C_003Ec__DisplayClass52_3
		{
			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x12251FC", Offset = "0x12251FC", VA = "0x12251FC")]
			public _003C_003Ec__DisplayClass52_3()
			{
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x1225204", Offset = "0x1225204", VA = "0x1225204")]
			internal bool _003CUpdateBundleSortList_003Eb__5(PostProcessBundle b)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195AC", Offset = "0x8195AC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<Type, PostProcessBundle>, PostProcessBundle> _003C_003E9__52_1;

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1224F04", Offset = "0x1224F04", VA = "0x1224F04")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x1224F0C", Offset = "0x1224F0C", VA = "0x1224F0C")]
			internal PostProcessBundle _003CUpdateBundleSortList_003Eb__52_1(KeyValuePair<Type, PostProcessBundle> kvp)
			{
				return null;
			}
		}

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x18")]
		public Transform volumeTrigger;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask volumeLayer;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x24")]
		public bool stopNaNPropagation;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x25")]
		public bool finalBlitToCameraTarget;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x28")]
		public Antialiasing antialiasingMode;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x30")]
		public TemporalAntialiasing temporalAntialiasing;

		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x38")]
		public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x40")]
		public FastApproximateAntialiasing fastApproximateAntialiasing;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x48")]
		public Fog fog;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x50")]
		private Dithering dithering;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x58")]
		public PostProcessDebugLayer debugLayer;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PostProcessResources m_Resources;

		[NonSerialized]
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x68")]
		private PostProcessResources m_OldResources;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x70")]
		[Preserve]
		[SerializeField]
		private bool m_ShowToolkit;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x71")]
		[Preserve]
		[SerializeField]
		private bool m_ShowCustomSorter;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x72")]
		public bool breakBeforeColorGrading;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<SerializedBundleRef> m_BeforeTransparentBundles;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<SerializedBundleRef> m_BeforeStackBundles;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<SerializedBundleRef> m_AfterStackBundles;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BC48", Offset = "0x81BC48")]
		private Dictionary<PostProcessEvent, List<SerializedBundleRef>> _003CsortedBundles_003Ek__BackingField;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BC58", Offset = "0x81BC58")]
		private DepthTextureMode _003CcameraDepthFlags_003Ek__BackingField;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BC68", Offset = "0x81BC68")]
		private bool _003ChaveBundlesBeenInited_003Ek__BackingField;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<Type, PostProcessBundle> m_Bundles;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xA8")]
		private PropertySheetFactory m_PropertySheetFactory;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xB0")]
		private CommandBuffer m_LegacyCmdBufferBeforeReflections;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xB8")]
		private CommandBuffer m_LegacyCmdBufferBeforeLighting;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0xC0")]
		private CommandBuffer m_LegacyCmdBufferOpaque;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0xC8")]
		private CommandBuffer m_LegacyCmdBuffer;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0xD0")]
		private Camera m_Camera;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0xD8")]
		private PostProcessRenderContext m_CurrentContext;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0xE0")]
		private LogHistogram m_LogHistogram;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_SettingsUpdateNeeded;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_IsRenderingInSceneView;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0xF0")]
		private TargetPool m_TargetPool;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_NaNKilled;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<RenderTargetIdentifier> m_Targets;

		[Token(Token = "0x1700000B")]
		public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xD8BB84", Offset = "0xD8BB84", VA = "0xD8BB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C120", Offset = "0x81C120")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xD8BB8C", Offset = "0xD8BB8C", VA = "0xD8BB8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C130", Offset = "0x81C130")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public DepthTextureMode cameraDepthFlags
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xD8BB94", Offset = "0xD8BB94", VA = "0xD8BB94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C140", Offset = "0x81C140")]
			get
			{
				return default(DepthTextureMode);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xD8BB9C", Offset = "0xD8BB9C", VA = "0xD8BB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C150", Offset = "0x81C150")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool haveBundlesBeenInited
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xD8BBA4", Offset = "0xD8BBA4", VA = "0xD8BBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C160", Offset = "0x81C160")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xD8BBAC", Offset = "0xD8BBAC", VA = "0xD8BBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C170", Offset = "0x81C170")]
			private set
			{
			}
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD8BBB8", Offset = "0xD8BBB8", VA = "0xD8BBB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD8C1D4", Offset = "0xD8C1D4", VA = "0xD8C1D4")]
		private void InitLegacy()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD8BCD4", Offset = "0xD8BCD4", VA = "0xD8BCD4")]
		public void Init(PostProcessResources resources)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD8BDF0", Offset = "0xD8BDF0", VA = "0xD8BDF0")]
		public void InitBundles()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD8C3FC", Offset = "0xD8C3FC", VA = "0xD8C3FC")]
		private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD8C9BC", Offset = "0xD8C9BC", VA = "0xD8C9BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD8CC98", Offset = "0xD8CC98", VA = "0xD8CC98")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD8CCC0", Offset = "0xD8CCC0", VA = "0xD8CCC0")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD8DCCC", Offset = "0xD8DCCC", VA = "0xD8DCCC")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD8DD6C", Offset = "0xD8DD6C", VA = "0xD8DD6C")]
		private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD8DD74", Offset = "0xD8DD74", VA = "0xD8DD74")]
		private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD8D048", Offset = "0xD8D048", VA = "0xD8D048")]
		private void BuildCommandBuffers()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD8F2EC", Offset = "0xD8F2EC", VA = "0xD8F2EC")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x600012F")]
		public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD8F45C", Offset = "0xD8F45C", VA = "0xD8F45C")]
		public PostProcessBundle GetBundle(Type settingsType)
		{
			return null;
		}

		[Token(Token = "0x6000131")]
		public T GetSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD8F4CC", Offset = "0xD8F4CC", VA = "0xD8F4CC")]
		public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD8F624", Offset = "0xD8F624", VA = "0xD8F624")]
		internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD8F8A4", Offset = "0xD8F8A4", VA = "0xD8F8A4")]
		private void SetLegacyCameraFlags(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD8FBB8", Offset = "0xD8FBB8", VA = "0xD8FBB8")]
		public void ResetHistory()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD8E3F8", Offset = "0xD8E3F8", VA = "0xD8E3F8")]
		public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD8FD38", Offset = "0xD8FD38", VA = "0xD8FD38")]
		public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD8DFCC", Offset = "0xD8DFCC", VA = "0xD8DFCC")]
		private void SetupContext(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD8E2AC", Offset = "0xD8E2AC", VA = "0xD8E2AC")]
		public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD8E408", Offset = "0xD8E408", VA = "0xD8E408")]
		public void RenderOpaqueOnly(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD8E544", Offset = "0xD8E544", VA = "0xD8E544")]
		public void Render(PostProcessRenderContext context)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD90574", Offset = "0xD90574", VA = "0xD90574")]
		private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
		{
			return default(int);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD8FF4C", Offset = "0xD8FF4C", VA = "0xD8FF4C")]
		private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD91D68", Offset = "0xD91D68", VA = "0xD91D68")]
		private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD91E7C", Offset = "0xD91E7C", VA = "0xD91E7C")]
		private void ApplyDefaultFlip(MaterialPropertyBlock properties)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD907E8", Offset = "0xD907E8", VA = "0xD907E8")]
		private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD91124", Offset = "0xD91124", VA = "0xD91124")]
		private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
		{
		}

		[Token(Token = "0x6000142")]
		private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
		{
			return default(int);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD91F7C", Offset = "0xD91F7C", VA = "0xD91F7C")]
		private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD92044", Offset = "0xD92044", VA = "0xD92044")]
		public PostProcessLayer()
		{
		}
	}
}
