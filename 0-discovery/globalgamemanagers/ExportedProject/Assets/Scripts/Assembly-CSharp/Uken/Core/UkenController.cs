using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003CB")]
	public abstract class UkenController
	{
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82E218", Offset = "0x82E218")]
		private bool _003Cm_bInitialized_003Ek__BackingField;

		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x11")]
		protected bool m_contentLoaded;

		[Token(Token = "0x1700057E")]
		public bool m_bInitialized
		{
			[Token(Token = "0x6001D5B")]
			[Address(RVA = "0xA1A2E8", Offset = "0xA1A2E8", VA = "0xA1A2E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838848", Offset = "0x838848")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D5C")]
			[Address(RVA = "0xA1A2F0", Offset = "0xA1A2F0", VA = "0xA1A2F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x838858", Offset = "0x838858")]
			protected set
			{
			}
		}

		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0xA1A2FC", Offset = "0xA1A2FC", VA = "0xA1A2FC", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0xA1A308", Offset = "0xA1A308", VA = "0xA1A308", Slot = "5")]
		public virtual bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0xA1A310", Offset = "0xA1A310", VA = "0xA1A310", Slot = "6")]
		public virtual bool PostLoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D60")]
		[Address(RVA = "0xA1A318", Offset = "0xA1A318", VA = "0xA1A318", Slot = "7")]
		public virtual void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001D61")]
		[Address(RVA = "0xA1A31C", Offset = "0xA1A31C", VA = "0xA1A31C", Slot = "8")]
		public virtual void Cleanup()
		{
		}

		[Token(Token = "0x6001D62")]
		[Address(RVA = "0xA1A324", Offset = "0xA1A324", VA = "0xA1A324", Slot = "9")]
		public virtual void OnDataUpdated()
		{
		}

		[Token(Token = "0x6001D63")]
		[Address(RVA = "0xA1A330", Offset = "0xA1A330", VA = "0xA1A330")]
		protected UkenController()
		{
		}
	}
}
