using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Serializable]
	[Token(Token = "0x2000051")]
	public class PostProcessEffectSettings : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81955C", Offset = "0x81955C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x8")]
			public static Func<FieldInfo, bool> _003C_003E9__3_0;

			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x10")]
			public static Func<FieldInfo, int> _003C_003E9__3_1;

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xD8BA6C", Offset = "0xD8BA6C", VA = "0xD8BA6C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0xD8BA74", Offset = "0xD8BA74", VA = "0xD8BA74")]
			internal bool _003COnEnable_003Eb__3_0(FieldInfo t)
			{
				return default(bool);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xD8BB38", Offset = "0xD8BB38", VA = "0xD8BB38")]
			internal int _003COnEnable_003Eb__3_1(FieldInfo t)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x18")]
		public bool active;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		public BoolParameter enabled;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		internal ReadOnlyCollection<ParameterOverride> parameters;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD8AD74", Offset = "0xD8AD74", VA = "0xD8AD74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD8B1EC", Offset = "0xD8B1EC", VA = "0xD8B1EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD8B428", Offset = "0xD8B428", VA = "0xD8B428")]
		public void SetAllOverridesTo(bool state, bool excludeEnabled = true)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD8B698", Offset = "0xD8B698", VA = "0xD8B698", Slot = "4")]
		public virtual bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD8B6C4", Offset = "0xD8B6C4", VA = "0xD8B6C4")]
		public int GetHash()
		{
			return default(int);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD73B00", Offset = "0xD73B00", VA = "0xD73B00")]
		public PostProcessEffectSettings()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD8B918", Offset = "0xD8B918", VA = "0xD8B918")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C110", Offset = "0x81C110")]
		private ParameterOverride _003COnEnable_003Eb__3_2(FieldInfo t)
		{
			return null;
		}
	}
}
