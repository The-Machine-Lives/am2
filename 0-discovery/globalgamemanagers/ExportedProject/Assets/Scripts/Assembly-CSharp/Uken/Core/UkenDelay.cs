using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Uken.Core
{
	[Token(Token = "0x20003CF")]
	public class UkenDelay
	{
		[Token(Token = "0x20007AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F88", Offset = "0x820F88")]
		private sealed class _003CWaitForTime_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4002259")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400225A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400225B")]
			[FieldOffset(Offset = "0x20")]
			public float secondsLeft;

			[Token(Token = "0x1700080C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031B4")]
				[Address(RVA = "0xA1B6B4", Offset = "0xA1B6B4", VA = "0xA1B6B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700080D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031B6")]
				[Address(RVA = "0xA1B724", Offset = "0xA1B724", VA = "0xA1B724", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031B1")]
			[Address(RVA = "0xA1B4F0", Offset = "0xA1B4F0", VA = "0xA1B4F0")]
			[DebuggerHidden]
			public _003CWaitForTime_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031B2")]
			[Address(RVA = "0xA1B648", Offset = "0xA1B648", VA = "0xA1B648", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031B3")]
			[Address(RVA = "0xA1B64C", Offset = "0xA1B64C", VA = "0xA1B64C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031B5")]
			[Address(RVA = "0xA1B6BC", Offset = "0xA1B6BC", VA = "0xA1B6BC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x20007AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820F98", Offset = "0x820F98")]
		private sealed class _003CWaitForRealTime_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400225C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400225D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400225E")]
			[FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x400225F")]
			[FieldOffset(Offset = "0x24")]
			private float _003CfRealTime_003E5__2;

			[Token(Token = "0x1700080E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60031BA")]
				[Address(RVA = "0xA1B5D0", Offset = "0xA1B5D0", VA = "0xA1B5D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700080F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60031BC")]
				[Address(RVA = "0xA1B640", Offset = "0xA1B640", VA = "0xA1B640", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60031B7")]
			[Address(RVA = "0xA1B51C", Offset = "0xA1B51C", VA = "0xA1B51C")]
			[DebuggerHidden]
			public _003CWaitForRealTime_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60031B8")]
			[Address(RVA = "0xA1B548", Offset = "0xA1B548", VA = "0xA1B548", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60031B9")]
			[Address(RVA = "0xA1B54C", Offset = "0xA1B54C", VA = "0xA1B54C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60031BB")]
			[Address(RVA = "0xA1B5D8", Offset = "0xA1B5D8", VA = "0xA1B5D8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x10")]
		private UkenSubroutine action;

		[Token(Token = "0x6001D84")]
		[Address(RVA = "0xA1B240", Offset = "0xA1B240", VA = "0xA1B240")]
		public UkenDelay(float seconds, bool bRealTime = false)
		{
		}

		[Token(Token = "0x6001D85")]
		[Address(RVA = "0xA1B408", Offset = "0xA1B408", VA = "0xA1B408")]
		public bool Run()
		{
			return default(bool);
		}

		[Token(Token = "0x6001D86")]
		[Address(RVA = "0xA1B38C", Offset = "0xA1B38C", VA = "0xA1B38C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838888", Offset = "0x838888")]
		public IEnumerator WaitForTime(float secondsLeft)
		{
			return null;
		}

		[Token(Token = "0x6001D87")]
		[Address(RVA = "0xA1B2E4", Offset = "0xA1B2E4", VA = "0xA1B2E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8388EC", Offset = "0x8388EC")]
		public IEnumerator WaitForRealTime(float seconds)
		{
			return null;
		}
	}
}
