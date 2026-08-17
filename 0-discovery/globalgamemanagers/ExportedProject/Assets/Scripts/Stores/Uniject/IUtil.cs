using System;
using System.Collections;
using Il2CppDummyDll;

namespace Uniject
{
	[Token(Token = "0x2000022")]
	internal interface IUtil
	{
		[Token(Token = "0x600004A")]
		object InitiateCoroutine(IEnumerator start);

		[Token(Token = "0x600004B")]
		void InitiateCoroutine(IEnumerator start, int delayInSeconds);

		[Token(Token = "0x600004C")]
		void RunOnMainThread(Action runnable);

		[Token(Token = "0x600004D")]
		void AddPauseListener(Action<bool> runnable);
	}
}
