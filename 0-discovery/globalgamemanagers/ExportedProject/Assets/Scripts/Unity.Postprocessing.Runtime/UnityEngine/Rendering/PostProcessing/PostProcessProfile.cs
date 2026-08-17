using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x2000056")]
	public sealed class PostProcessProfile : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8195CC", Offset = "0x8195CC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002B5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002B6")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<PostProcessEffectSettings> _003C_003E9__2_0;

			[Token(Token = "0x6000236")]
			[Address(RVA = "0x122868C", Offset = "0x122868C", VA = "0x122868C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1228694", Offset = "0x1228694", VA = "0x1228694")]
			internal bool _003COnEnable_003Eb__2_0(PostProcessEffectSettings x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x81BC78", Offset = "0x81BC78")]
		public List<PostProcessEffectSettings> settings;

		[NonSerialized]
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x20")]
		public bool isDirty;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1227FA8", Offset = "0x1227FA8", VA = "0x1227FA8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000159")]
		public T AddSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x12280AC", Offset = "0x12280AC", VA = "0x12280AC")]
		public PostProcessEffectSettings AddSettings(Type type)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1226C04", Offset = "0x1226C04", VA = "0x1226C04")]
		public PostProcessEffectSettings AddSettings(PostProcessEffectSettings effect)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		public void RemoveSettings<T>() where T : PostProcessEffectSettings
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1228428", Offset = "0x1228428", VA = "0x1228428")]
		public void RemoveSettings(Type type)
		{
		}

		[Token(Token = "0x600015E")]
		public bool HasSettings<T>() where T : PostProcessEffectSettings
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x12282A8", Offset = "0x12282A8", VA = "0x12282A8")]
		public bool HasSettings(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		public T GetSetting<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		public bool TryGetSettings<T>(out T outSetting) where T : PostProcessEffectSettings
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x12285B0", Offset = "0x12285B0", VA = "0x12285B0")]
		public PostProcessProfile()
		{
		}
	}
}
