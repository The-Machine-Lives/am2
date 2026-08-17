using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003D2")]
	public class UkenTimer
	{
		[Token(Token = "0x20007AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FA8", Offset = "0x820FA8")]
		private sealed class _003CSetTimeoutCoroutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002260")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002261")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002262")]
			[FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x4002263")]
			[FieldOffset(Offset = "0x24")]
			public bool realTime;

			[Token(Token = "0x4002264")]
			[FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x4002265")]
			[FieldOffset(Offset = "0x30")]
			private UkenDelay _003Cdelay_003E5__2;

			[Token(Token = "0x17000810")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031C0")]
				[Address(RVA = "0xA1D1C4", Offset = "0xA1D1C4", VA = "0xA1D1C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000811")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031C2")]
				[Address(RVA = "0xA1D234", Offset = "0xA1D234", VA = "0xA1D234", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031BD")]
			[Address(RVA = "0xA1CF10", Offset = "0xA1CF10", VA = "0xA1CF10")]
			[DebuggerHidden]
			public _003CSetTimeoutCoroutine_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031BE")]
			[Address(RVA = "0xA1D0D0", Offset = "0xA1D0D0", VA = "0xA1D0D0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031BF")]
			[Address(RVA = "0xA1D0D4", Offset = "0xA1D0D4", VA = "0xA1D0D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031C1")]
			[Address(RVA = "0xA1D1CC", Offset = "0xA1D1CC", VA = "0xA1D1CC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20007AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820FB8", Offset = "0x820FB8")]
		private sealed class _003CRepeatingCoroutine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002266")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002267")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002268")]
			[FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x4002269")]
			[FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x400226A")]
			[FieldOffset(Offset = "0x30")]
			private UkenDelay _003Cdelay_003E5__2;

			[Token(Token = "0x17000812")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031C6")]
				[Address(RVA = "0xA1D058", Offset = "0xA1D058", VA = "0xA1D058", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000813")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031C8")]
				[Address(RVA = "0xA1D0C8", Offset = "0xA1D0C8", VA = "0xA1D0C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031C3")]
			[Address(RVA = "0xA1CF3C", Offset = "0xA1CF3C", VA = "0xA1CF3C")]
			[DebuggerHidden]
			public _003CRepeatingCoroutine_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031C4")]
			[Address(RVA = "0xA1CF70", Offset = "0xA1CF70", VA = "0xA1CF70", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031C5")]
			[Address(RVA = "0xA1CF74", Offset = "0xA1CF74", VA = "0xA1CF74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031C7")]
			[Address(RVA = "0xA1D060", Offset = "0xA1D060", VA = "0xA1D060", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x6001D91")]
		[Address(RVA = "0xA1CD68", Offset = "0xA1CD68", VA = "0xA1CD68")]
		public static void SetTimeout(float waitTime, Action callback)
		{
		}

		[Token(Token = "0x6001D92")]
		[Address(RVA = "0xA1CE44", Offset = "0xA1CE44", VA = "0xA1CE44")]
		public static void SetRealTimeTimeout(float waitTime, Action callback)
		{
		}

		[Token(Token = "0x6001D93")]
		[Address(RVA = "0xA1CE64", Offset = "0xA1CE64", VA = "0xA1CE64")]
		public static void InvokeRepeating(float waitTime, Action callback)
		{
		}

		[Token(Token = "0x6001D94")]
		[Address(RVA = "0xA1CD88", Offset = "0xA1CD88", VA = "0xA1CD88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838950", Offset = "0x838950")]
		private static IEnumerator SetTimeoutCoroutine(float waitTime, bool realTime, Action callback)
		{
			return null;
		}

		[Token(Token = "0x6001D95")]
		[Address(RVA = "0xA1CE78", Offset = "0xA1CE78", VA = "0xA1CE78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8389B4", Offset = "0x8389B4")]
		private static IEnumerator RepeatingCoroutine(float waitTime, Action callback)
		{
			return null;
		}

		[Token(Token = "0x6001D96")]
		[Address(RVA = "0xA1CF68", Offset = "0xA1CF68", VA = "0xA1CF68")]
		public UkenTimer()
		{
		}
	}
}
