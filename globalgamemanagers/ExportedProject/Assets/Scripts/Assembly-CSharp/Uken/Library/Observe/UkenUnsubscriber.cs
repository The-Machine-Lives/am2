using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Observe
{
	[Token(Token = "0x2000409")]
	public class UkenUnsubscriber<T>
	{
		[Token(Token = "0x40012DD")]
		[FieldOffset(Offset = "0x0")]
		private List<IUkenObserver<T>> m_observers;

		[Token(Token = "0x40012DE")]
		[FieldOffset(Offset = "0x0")]
		private IUkenObserver<T> m_observer;

		[Token(Token = "0x6001EB7")]
		public UkenUnsubscriber(List<IUkenObserver<T>> observers, IUkenObserver<T> observer)
		{
		}

		[Token(Token = "0x6001EB8")]
		~UkenUnsubscriber()
		{
		}

		[Token(Token = "0x6001EB9")]
		public void Unsubscribe()
		{
		}
	}
}
