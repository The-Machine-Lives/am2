using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	[Token(Token = "0x200003B")]
	public abstract class Monitor
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81BB28", Offset = "0x81BB28")]
		private RenderTexture _003Coutput_003Ek__BackingField;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		internal bool requested;

		[Token(Token = "0x17000003")]
		public RenderTexture output
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xD82418", Offset = "0xD82418", VA = "0xD82418")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C030", Offset = "0x81C030")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xD83CE4", Offset = "0xD83CE4", VA = "0xD83CE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C040", Offset = "0x81C040")]
			protected set
			{
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD83CEC", Offset = "0xD83CEC", VA = "0xD83CEC")]
		public bool IsRequestedAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD83D9C", Offset = "0xD83D9C", VA = "0xD83D9C", Slot = "5")]
		internal virtual bool NeedsHalfRes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xD82228", Offset = "0xD82228", VA = "0xD82228")]
		protected void CheckOutput(int width, int height)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD83DA4", Offset = "0xD83DA4", VA = "0xD83DA4", Slot = "6")]
		internal virtual void OnEnable()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD81AE8", Offset = "0xD81AE8", VA = "0xD81AE8", Slot = "7")]
		internal virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000AD")]
		internal abstract void Render(PostProcessRenderContext context);

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xD8243C", Offset = "0xD8243C", VA = "0xD8243C")]
		protected Monitor()
		{
		}
	}
}
