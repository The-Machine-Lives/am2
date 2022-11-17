using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;

namespace Uken.Library.Metrics
{
	[Token(Token = "0x2000414")]
	public class MetricsController : UkenController
	{
		[Token(Token = "0x20007CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821088", Offset = "0x821088")]
		private sealed class _003CDispatch_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40022C7")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40022C8")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40022C9")]
			[FieldOffset(Offset = "0x20")]
			public MetricsPayload m_metricsPayload;

			[Token(Token = "0x40022CA")]
			[FieldOffset(Offset = "0x28")]
			public MetricsController _003C_003E4__this;

			[Token(Token = "0x40022CB")]
			[FieldOffset(Offset = "0x30")]
			private float _003Ctimer_003E5__2;

			[Token(Token = "0x40022CC")]
			[FieldOffset(Offset = "0x34")]
			private bool _003CtimedOut_003E5__3;

			[Token(Token = "0x40022CD")]
			[FieldOffset(Offset = "0x38")]
			private WWW _003Cwww_003E5__4;

			[Token(Token = "0x1700081B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6003226")]
				[Address(RVA = "0xBAC2A0", Offset = "0xBAC2A0", VA = "0xBAC2A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700081C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003228")]
				[Address(RVA = "0xBAC310", Offset = "0xBAC310", VA = "0xBAC310", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003223")]
			[Address(RVA = "0xBABEC8", Offset = "0xBABEC8", VA = "0xBABEC8")]
			[DebuggerHidden]
			public _003CDispatch_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6003224")]
			[Address(RVA = "0xBABFD0", Offset = "0xBABFD0", VA = "0xBABFD0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6003225")]
			[Address(RVA = "0xBABFD4", Offset = "0xBABFD4", VA = "0xBABFD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003227")]
			[Address(RVA = "0xBAC2A8", Offset = "0xBAC2A8", VA = "0xBAC2A8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40012F1")]
		private const float NOT_SET = -1f;

		[Token(Token = "0x40012F2")]
		private const float DISPATCH_DELAY = 2f;

		[Token(Token = "0x40012F3")]
		private const float REQUEST_TIMEOUT = 10f;

		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x18")]
		private readonly string m_endpoint;

		[Token(Token = "0x40012F5")]
		[FieldOffset(Offset = "0x20")]
		private readonly string m_apiKey;

		[Token(Token = "0x40012F6")]
		[FieldOffset(Offset = "0x28")]
		private float m_timeSinceMetricSet;

		[Token(Token = "0x40012F7")]
		[FieldOffset(Offset = "0x30")]
		private MetricsPayload m_metricsPayload;

		[Token(Token = "0x40012F8")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> m_requestHeaders;

		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0xBAB778", Offset = "0xBAB778", VA = "0xBAB778")]
		public MetricsController(string endpoint, string apiKey)
		{
		}

		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0xBAB8C0", Offset = "0xBAB8C0", VA = "0xBAB8C0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0xBAB97C", Offset = "0xBAB97C", VA = "0xBAB97C", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0xBAB990", Offset = "0xBAB990", VA = "0xBAB990")]
		public bool IsReady()
		{
			return default(bool);
		}

		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0xBAB9E4", Offset = "0xBAB9E4", VA = "0xBAB9E4")]
		public void IncrementCounter(string name, int delta = 1)
		{
		}

		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0xBABB9C", Offset = "0xBABB9C", VA = "0xBABB9C")]
		public void SetGauge(string name, int value)
		{
		}

		[Token(Token = "0x6001EF5")]
		[Address(RVA = "0xBABCA0", Offset = "0xBABCA0", VA = "0xBABCA0", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0xBABDB8", Offset = "0xBABDB8", VA = "0xBABDB8")]
		private void DispatchMetrics()
		{
		}

		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0xBABE30", Offset = "0xBABE30", VA = "0xBABE30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x838F60", Offset = "0x838F60")]
		private IEnumerator Dispatch(MetricsPayload m_metricsPayload)
		{
			return null;
		}

		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0xBABEF4", Offset = "0xBABEF4", VA = "0xBABEF4")]
		private void OnFailure(MetricsPayload m_metricsPayload)
		{
		}
	}
}
