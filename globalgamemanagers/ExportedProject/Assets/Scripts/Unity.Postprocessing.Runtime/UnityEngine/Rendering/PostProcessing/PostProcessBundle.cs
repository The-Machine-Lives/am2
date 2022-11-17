using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200004A")]
	public sealed class PostProcessBundle
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB38", Offset = "0x81BB38")]
		private PostProcessAttribute _003Cattribute_003Ek__BackingField;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB48", Offset = "0x81BB48")]
		private PostProcessEffectSettings _003Csettings_003Ek__BackingField;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessEffectRenderer m_Renderer;

		[Token(Token = "0x17000004")]
		public PostProcessAttribute attribute
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xD88B0C", Offset = "0xD88B0C", VA = "0xD88B0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C050", Offset = "0x81C050")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xD88B14", Offset = "0xD88B14", VA = "0xD88B14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C060", Offset = "0x81C060")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public PostProcessEffectSettings settings
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xD88B1C", Offset = "0xD88B1C", VA = "0xD88B1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C070", Offset = "0x81C070")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xD88B24", Offset = "0xD88B24", VA = "0xD88B24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C080", Offset = "0x81C080")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		internal PostProcessEffectRenderer renderer
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xD88B2C", Offset = "0xD88B2C", VA = "0xD88B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xD88C68", Offset = "0xD88C68", VA = "0xD88C68")]
		internal PostProcessBundle(PostProcessEffectSettings settings)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xD88D1C", Offset = "0xD88D1C", VA = "0xD88D1C")]
		internal void Release()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xD88D9C", Offset = "0xD88D9C", VA = "0xD88D9C")]
		internal void ResetHistory()
		{
		}

		[Token(Token = "0x60000EB")]
		internal T CastSettings<T>() where T : PostProcessEffectSettings
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		internal T CastRenderer<T>() where T : PostProcessEffectRenderer
		{
			return null;
		}
	}
}
