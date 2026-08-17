using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000055")]
	public sealed class PostProcessManager
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195BC", Offset = "0x8195BC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002B4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Type, bool> _003C_003E9__12_0;

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1227EE4", Offset = "0x1227EE4", VA = "0x1227EE4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1227EEC", Offset = "0x1227EEC", VA = "0x1227EEC")]
			internal bool _003CReloadBaseTypes_003Eb__12_0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		private static PostProcessManager s_Instance;

		[Token(Token = "0x4000157")]
		private const int k_MaxLayerCount = 32;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<PostProcessVolume> m_Volumes;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, bool> m_SortNeeded;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<PostProcessEffectSettings> m_BaseSettings;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Collider> m_TempColliders;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x38")]
		public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

		[Token(Token = "0x1700000E")]
		public static PostProcessManager instance
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1225284", Offset = "0x1225284", VA = "0x1225284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1225300", Offset = "0x1225300", VA = "0x1225300")]
		private PostProcessManager()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1225910", Offset = "0x1225910", VA = "0x1225910")]
		private void CleanBaseTypes()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1225444", Offset = "0x1225444", VA = "0x1225444")]
		private void ReloadBaseTypes()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1225B38", Offset = "0x1225B38", VA = "0x1225B38")]
		public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x12265A0", Offset = "0x12265A0", VA = "0x12265A0")]
		public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1226678", Offset = "0x1226678", VA = "0x1226678")]
		public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1226810", Offset = "0x1226810", VA = "0x1226810")]
		public PostProcessVolume QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings)
		{
			return null;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1226CF4", Offset = "0x1226CF4", VA = "0x1226CF4")]
		internal void SetLayerDirty(int layer)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1226E84", Offset = "0x1226E84", VA = "0x1226E84")]
		internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1227080", Offset = "0x1227080", VA = "0x1227080")]
		private void Register(PostProcessVolume volume, int layer)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1227254", Offset = "0x1227254", VA = "0x1227254")]
		internal void Register(PostProcessVolume volume)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1226EC0", Offset = "0x1226EC0", VA = "0x1226EC0")]
		private void Unregister(PostProcessVolume volume, int layer)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x12272B8", Offset = "0x12272B8", VA = "0x12272B8")]
		internal void Unregister(PostProcessVolume volume)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x122731C", Offset = "0x122731C", VA = "0x122731C")]
		private void ReplaceData(PostProcessLayer postProcessLayer)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1227598", Offset = "0x1227598", VA = "0x1227598")]
		internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x12261B4", Offset = "0x12261B4", VA = "0x12261B4")]
		private List<PostProcessVolume> GrabVolumes(LayerMask mask)
		{
			return null;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1227CC4", Offset = "0x1227CC4", VA = "0x1227CC4")]
		private static void SortByPriority(List<PostProcessVolume> volumes)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1227E78", Offset = "0x1227E78", VA = "0x1227E78")]
		private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
		{
			return default(bool);
		}
	}
}
