using Il2CppDummyDll;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x200057E")]
	public class CasualViewItem : CasualViewBase
	{
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x80")]
		public CasualOffsetObject m_offsetScript;

		[Token(Token = "0x4001A2D")]
		[FieldOffset(Offset = "0x88")]
		protected CasualViewBase m_parent;

		[Token(Token = "0x6002A26")]
		[Address(RVA = "0xAE78B8", Offset = "0xAE78B8", VA = "0xAE78B8", Slot = "12")]
		public virtual void Initialize(CasualViewBase parentView)
		{
		}

		[Token(Token = "0x6002A27")]
		[Address(RVA = "0xAE77D4", Offset = "0xAE77D4", VA = "0xAE77D4")]
		public CasualViewItem()
		{
		}
	}
}
