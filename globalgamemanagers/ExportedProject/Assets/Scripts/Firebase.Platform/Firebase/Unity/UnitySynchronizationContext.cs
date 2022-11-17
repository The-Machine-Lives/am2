using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace Firebase.Unity
{
	[Token(Token = "0x200000C")]
	[Preserve]
	internal class UnitySynchronizationContext : SynchronizationContext
	{
		[Token(Token = "0x200000D")]
		private class SynchronizationContextBehavoir : MonoBehaviour
		{
			[Token(Token = "0x200000E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80776C", Offset = "0x80776C")]
			private sealed class _003CStart_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
			{
				[Token(Token = "0x400001D")]
				[FieldOffset(Offset = "0x10")]
				internal Tuple<SendOrPostCallback, object> _003Centry_003E__0;

				[Token(Token = "0x400001E")]
				[FieldOffset(Offset = "0x18")]
				internal object _0024locvar0;

				[Token(Token = "0x400001F")]
				[FieldOffset(Offset = "0x20")]
				internal SynchronizationContextBehavoir _0024this;

				[Token(Token = "0x4000020")]
				[FieldOffset(Offset = "0x28")]
				internal object _0024current;

				[Token(Token = "0x4000021")]
				[FieldOffset(Offset = "0x30")]
				internal bool _0024disposing;

				[Token(Token = "0x4000022")]
				[FieldOffset(Offset = "0x34")]
				internal int _0024PC;

				[Token(Token = "0x17000015")]
				private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
				{
					[Token(Token = "0x600004B")]
					[Address(RVA = "0x17D325C", Offset = "0x17D325C", VA = "0x17D325C", Slot = "8")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x17000016")]
				private object System_002ECollections_002EIEnumerator_002ECurrent
				{
					[Token(Token = "0x600004C")]
					[Address(RVA = "0x17D3264", Offset = "0x17D3264", VA = "0x17D3264", Slot = "5")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x6000049")]
				[Address(RVA = "0x17D2F8C", Offset = "0x17D2F8C", VA = "0x17D2F8C")]
				[DebuggerHidden]
				public _003CStart_003Ec__Iterator0()
				{
				}

				[Token(Token = "0x600004A")]
				[Address(RVA = "0x17D2F94", Offset = "0x17D2F94", VA = "0x17D2F94", Slot = "4")]
				public bool MoveNext()
				{
					return default(bool);
				}

				[Token(Token = "0x600004D")]
				[Address(RVA = "0x17D326C", Offset = "0x17D326C", VA = "0x17D326C", Slot = "7")]
				[DebuggerHidden]
				public void Dispose()
				{
				}

				[Token(Token = "0x600004E")]
				[Address(RVA = "0x17D3280", Offset = "0x17D3280", VA = "0x17D3280", Slot = "6")]
				[DebuggerHidden]
				public void Reset()
				{
				}
			}

			[Token(Token = "0x400001C")]
			[FieldOffset(Offset = "0x18")]
			private Queue<Tuple<SendOrPostCallback, object>> callbackQueue;

			[Token(Token = "0x17000014")]
			public Queue<Tuple<SendOrPostCallback, object>> CallbackQueue
			{
				[Token(Token = "0x6000047")]
				[Address(RVA = "0x17D2644", Offset = "0x17D2644", VA = "0x17D2644")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x17D2F14", Offset = "0x17D2F14", VA = "0x17D2F14")]
			public SynchronizationContextBehavoir()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x17D2F1C", Offset = "0x17D2F1C", VA = "0x17D2F1C")]
			[DebuggerHidden]
			[Preserve]
			private IEnumerator Start()
			{
				return null;
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80777C", Offset = "0x80777C")]
		private sealed class _003CSignaledCoroutine_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x10")]
			internal Func<IEnumerator> coroutine;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x18")]
			internal ManualResetEvent newSignal;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x20")]
			internal object _0024current;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x28")]
			internal bool _0024disposing;

			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x2C")]
			internal int _0024PC;

			[Token(Token = "0x17000017")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x17D2E88", Offset = "0x17D2E88", VA = "0x17D2E88", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000018")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x17D2E90", Offset = "0x17D2E90", VA = "0x17D2E90", Slot = "5")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x17D2DA0", Offset = "0x17D2DA0", VA = "0x17D2DA0")]
			[DebuggerHidden]
			public _003CSignaledCoroutine_003Ec__Iterator0()
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x17D2DA8", Offset = "0x17D2DA8", VA = "0x17D2DA8", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x17D2E98", Offset = "0x17D2E98", VA = "0x17D2E98", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x17D2EAC", Offset = "0x17D2EAC", VA = "0x17D2EAC", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80778C", Offset = "0x80778C")]
		private sealed class _003CSendCoroutine_003Ec__AnonStorey1
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x17D2D90", Offset = "0x17D2D90", VA = "0x17D2D90")]
			public _003CSendCoroutine_003Ec__AnonStorey1()
			{
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x80779C", Offset = "0x80779C")]
		private sealed class _003CSendCoroutine_003Ec__AnonStorey2
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x17D2D98", Offset = "0x17D2D98", VA = "0x17D2D98")]
			public _003CSendCoroutine_003Ec__AnonStorey2()
			{
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8077AC", Offset = "0x8077AC")]
		private sealed class _003CSend_003Ec__AnonStorey3
		{
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x10")]
			internal SendOrPostCallback d;

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x17D2BA8", Offset = "0x17D2BA8", VA = "0x17D2BA8")]
			public _003CSend_003Ec__AnonStorey3()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8077BC", Offset = "0x8077BC")]
		private sealed class _003CSend_003Ec__AnonStorey4
		{
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x10")]
			internal ManualResetEvent newSignal;

			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x18")]
			internal _003CSend_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x17D2BB0", Offset = "0x17D2BB0", VA = "0x17D2BB0")]
			public _003CSend_003Ec__AnonStorey4()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x17D2C38", Offset = "0x17D2C38", VA = "0x17D2C38")]
			internal void _003C_003Em__0(object x)
			{
			}
		}

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		private static UnitySynchronizationContext _instance;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private Queue<Tuple<SendOrPostCallback, object>> queue;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		private SynchronizationContextBehavoir behavior;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x28")]
		private int mainThreadId;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, ManualResetEvent> signalDictionary;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17D258C", Offset = "0x17D258C", VA = "0x17D258C")]
		private UnitySynchronizationContext(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x17D1094", Offset = "0x17D1094", VA = "0x17D1094")]
		public static void Create(GameObject gameObject)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17D16B4", Offset = "0x17D16B4", VA = "0x17D16B4")]
		public static void Destroy()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17D26B8", Offset = "0x17D26B8", VA = "0x17D26B8")]
		private ManualResetEvent GetThreadEvent()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17D28DC", Offset = "0x17D28DC", VA = "0x17D28DC", Slot = "5")]
		public override void Post(SendOrPostCallback d, object state)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17D2A04", Offset = "0x17D2A04", VA = "0x17D2A04", Slot = "4")]
		public override void Send(SendOrPostCallback d, object state)
		{
		}
	}
}
