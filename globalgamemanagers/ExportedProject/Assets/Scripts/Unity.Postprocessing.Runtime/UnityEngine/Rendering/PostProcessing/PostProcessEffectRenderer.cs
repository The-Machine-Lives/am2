using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200004F")]
	public abstract class PostProcessEffectRenderer
	{
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_ResetHistory;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD8AD40", Offset = "0xD8AD40", VA = "0xD8AD40", Slot = "4")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD8AD44", Offset = "0xD8AD44", VA = "0xD8AD44", Slot = "5")]
		public virtual DepthTextureMode GetCameraFlags()
		{
			return default(DepthTextureMode);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD8AD4C", Offset = "0xD8AD4C", VA = "0xD8AD4C", Slot = "6")]
		public virtual void ResetHistory()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD8AD58", Offset = "0xD8AD58", VA = "0xD8AD58", Slot = "7")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x600010C")]
		public abstract void Render(PostProcessRenderContext context);

		[Token(Token = "0x600010D")]
		internal abstract void SetSettings(PostProcessEffectSettings settings);

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD8AD64", Offset = "0xD8AD64", VA = "0xD8AD64")]
		protected PostProcessEffectRenderer()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
	{
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB88", Offset = "0x81BB88")]
		private T _003Csettings_003Ek__BackingField;

		[Token(Token = "0x1700000A")]
		public T settings
		{
			[Token(Token = "0x600010F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C0F0", Offset = "0x81C0F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C100", Offset = "0x81C100")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000111")]
		internal override void SetSettings(PostProcessEffectSettings settings)
		{
		}

		[Token(Token = "0x6000112")]
		protected PostProcessEffectRenderer()
		{
		}
	}
}
