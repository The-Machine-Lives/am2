using Il2CppDummyDll;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200056F")]
	public class UserSegment
	{
		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x10")]
		private RDUserSegment m_userSegment;

		[Token(Token = "0x60029AE")]
		[Address(RVA = "0xAA0430", Offset = "0xAA0430", VA = "0xAA0430")]
		public UserSegment(RDUserSegment userSegment)
		{
		}

		[Token(Token = "0x60029AF")]
		[Address(RVA = "0xAA045C", Offset = "0xAA045C", VA = "0xAA045C", Slot = "4")]
		public virtual bool Evaluates(UserProfiler userProfiler)
		{
			return default(bool);
		}

		[Token(Token = "0x60029B0")]
		[Address(RVA = "0xAA05BC", Offset = "0xAA05BC", VA = "0xAA05BC", Slot = "5")]
		public virtual bool IsValid()
		{
			return default(bool);
		}
	}
}
