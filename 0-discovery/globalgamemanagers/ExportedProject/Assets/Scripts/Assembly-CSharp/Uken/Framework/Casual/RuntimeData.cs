using Il2CppDummyDll;
using Uken.Library.ReferenceData;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x2000572")]
	public class RuntimeData<T> where T : BaseEntityDocument
	{
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x0")]
		protected T m_referenceData;

		[Token(Token = "0x17000752")]
		public virtual string reference
		{
			[Token(Token = "0x60029C1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029BF")]
		public RuntimeData()
		{
		}

		[Token(Token = "0x60029C0")]
		public virtual void Initialize(T referenceData)
		{
		}
	}
}
