using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity
{
	[Token(Token = "0x200005B")]
	internal class FacebookScheduler : MonoBehaviour, IFacebookScheduler
	{
		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816100", Offset = "0x816100")]
		private sealed class _003CDelayEvent_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000084")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000085")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x20")]
			public long delay;

			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x17000066")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0xCDE784", Offset = "0xCDE784", VA = "0xCDE784", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60001B5")]
				[Address(RVA = "0xCDE7F4", Offset = "0xCDE7F4", VA = "0xCDE7F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xCDE690", Offset = "0xCDE690", VA = "0xCDE690")]
			[DebuggerHidden]
			public _003CDelayEvent_003Ed__1(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xCDE6C4", Offset = "0xCDE6C4", VA = "0xCDE6C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xCDE6C8", Offset = "0xCDE6C8", VA = "0xCDE6C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xCDE78C", Offset = "0xCDE78C", VA = "0xCDE78C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCDE5CC", Offset = "0xCDE5CC", VA = "0xCDE5CC", Slot = "4")]
		public void Schedule(Action action, long delay)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xCDE5F8", Offset = "0xCDE5F8", VA = "0xCDE5F8")]
		public IEnumerator DelayEvent(Action action, long delay)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xCDE6BC", Offset = "0xCDE6BC", VA = "0xCDE6BC")]
		public FacebookScheduler()
		{
		}
	}
}
