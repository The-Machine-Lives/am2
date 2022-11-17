using Il2CppDummyDll;

namespace UnityEngine.UI.Extensions
{
	[Token(Token = "0x200030A")]
	[ExecuteInEditMode]
	[Attribute(Name = "RequireComponent", RVA = "0x81EB00", Offset = "0x81EB00")]
	[Attribute(Name = "RequireComponent", RVA = "0x81EB00", Offset = "0x81EB00")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x81EB00", Offset = "0x81EB00")]
	public class UIParticleSystem : MaskableGraphic
	{
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0xB0")]
		public Texture particleTexture;

		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite particleSprite;

		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0xC0")]
		public bool m_respectFancyToggle;

		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0xC8")]
		private Transform _transform;

		[Token(Token = "0x4000E22")]
		[FieldOffset(Offset = "0xD0")]
		private ParticleSystem _particleSystem;

		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0xD8")]
		private ParticleSystem.Particle[] _particles;

		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0xE0")]
		private UIVertex[] _quad;

		[Token(Token = "0x4000E25")]
		[FieldOffset(Offset = "0xE8")]
		private Vector4 _uv;

		[Token(Token = "0x4000E26")]
		[FieldOffset(Offset = "0xF8")]
		private ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;

		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x100")]
		private int _textureSheetAnimationFrames;

		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x104")]
		private Vector2 _textureSheedAnimationFrameSize;

		[Token(Token = "0x17000323")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60017E0")]
			[Address(RVA = "0xAB2C50", Offset = "0xAB2C50", VA = "0xAB2C50", Slot = "35")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60017E1")]
		[Address(RVA = "0xAB2D24", Offset = "0xAB2D24", VA = "0xAB2D24")]
		protected bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x60017E2")]
		[Address(RVA = "0xAB3288", Offset = "0xAB3288", VA = "0xAB3288", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60017E3")]
		[Address(RVA = "0xAB32D0", Offset = "0xAB32D0", VA = "0xAB32D0", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x60017E4")]
		[Address(RVA = "0xAB3204", Offset = "0xAB3204", VA = "0xAB3204")]
		private void SetMaxParticles(ParticleSystem.MainModule main)
		{
		}

		[Token(Token = "0x60017E5")]
		[Address(RVA = "0xAB404C", Offset = "0xAB404C", VA = "0xAB404C")]
		private void Update()
		{
		}

		[Token(Token = "0x60017E6")]
		[Address(RVA = "0xAB40D0", Offset = "0xAB40D0", VA = "0xAB40D0")]
		public UIParticleSystem()
		{
		}
	}
}
