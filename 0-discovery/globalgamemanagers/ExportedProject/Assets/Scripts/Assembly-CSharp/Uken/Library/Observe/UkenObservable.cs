using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Uken.Library.Observe
{
	[Token(Token = "0x200040B")]
	public class UkenObservable<T>
	{
		[Token(Token = "0x40012DF")]
		[FieldOffset(Offset = "0x0")]
		private List<IUkenObserver<T>> m_observers;

		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x0")]
		private Func<T> m_getObservedFunc;

		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isDirty;

		[Token(Token = "0x6001EBB")]
		public UkenObservable(Func<T> getObservedFunc)
		{
		}

		[Token(Token = "0x6001EBC")]
		public void InitializeWithObservedFunc(Func<T> getObservedFunc)
		{
		}

		[Token(Token = "0x6001EBD")]
		public void Cleanup()
		{
		}

		[Token(Token = "0x6001EBE")]
		public void MarkDirty()
		{
		}

		[Token(Token = "0x6001EBF")]
		public void EmitIfDirty()
		{
		}

		[Token(Token = "0x6001EC0")]
		public void Emit()
		{
		}

		[Token(Token = "0x6001EC1")]
		public void Emit(T observedData)
		{
		}

		[Token(Token = "0x6001EC2")]
		public UkenUnsubscriber<T> Subscribe(IUkenObserver<T> observer, bool ReceiveEmitOnSubscribe)
		{
			return null;
		}
	}
}
