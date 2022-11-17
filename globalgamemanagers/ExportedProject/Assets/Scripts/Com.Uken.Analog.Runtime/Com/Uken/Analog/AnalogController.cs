using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Com.Uken.NativeHelpers;
using Il2CppDummyDll;
using UnityEngine;

namespace Com.Uken.Analog
{
	[Token(Token = "0x2000009")]
	public class AnalogController : UkenController
	{
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813ACC", Offset = "0x813ACC")]
		private sealed class _003CDispatch_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400002E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400002F")]
			[FieldOffset(Offset = "0x20")]
			public AnalogRequest analogRequest;

			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x28")]
			public AnalogController _003C_003E4__this;

			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x30")]
			private float _003Ctimer_003E5__2;

			[Token(Token = "0x4000032")]
			[FieldOffset(Offset = "0x34")]
			private bool _003CtimedOut_003E5__3;

			[Token(Token = "0x17000009")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x16D3E80", Offset = "0x16D3E80", VA = "0x16D3E80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600005C")]
				[Address(RVA = "0x16D3EF0", Offset = "0x16D3EF0", VA = "0x16D3EF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x16D3778", Offset = "0x16D3778", VA = "0x16D3778")]
			[DebuggerHidden]
			public _003CDispatch_003Ed__41(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x16D3BAC", Offset = "0x16D3BAC", VA = "0x16D3BAC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x16D3BB0", Offset = "0x16D3BB0", VA = "0x16D3BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x16D3E88", Offset = "0x16D3E88", VA = "0x16D3E88", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		private string serverEndpoint;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, string> requestHeaders;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		private float timeSinceFirstQueuedLog;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x2C")]
		private float timeSinceLastLog;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x30")]
		private float adjustFetchStopwatchTime;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x38")]
		private EventQueue eventQueue;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x40")]
		private bool initialized;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x48")]
		private Action sessionRefreshCB;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		private float dispatchBackoff;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x54")]
		private int dispatchBackoffMultiplier;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x58")]
		private int maxEventQueueSize;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x60")]
		private MonoBehaviour monoBehaviour;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x68")]
		private float timeSinceDiskSave;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x6C")]
		private float minimumTimeBetweenSaves;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x70")]
		private float thirdPartyFetchTimeout;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x813DD8", Offset = "0x813DD8")]
		private float _003CTimeUntilNextSaveAttempt_003Ek__BackingField;

		[Token(Token = "0x17000007")]
		public float TimeUntilNextSaveAttempt
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x16D1A3C", Offset = "0x16D1A3C", VA = "0x16D1A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815730", Offset = "0x815730")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x16D1A44", Offset = "0x16D1A44", VA = "0x16D1A44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x815740", Offset = "0x815740")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public float TimeSinceFirstQueuedLog
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x16D1A4C", Offset = "0x16D1A4C", VA = "0x16D1A4C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16D0474", Offset = "0x16D0474", VA = "0x16D0474")]
		public AnalogController()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x16D1A54", Offset = "0x16D1A54", VA = "0x16D1A54")]
		public void SetLogLevel(UkenLogger.LogLevel level)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x16D0F3C", Offset = "0x16D0F3C", VA = "0x16D0F3C")]
		public void SetMinimumSaveInterval(int seconds)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x16D1AA8", Offset = "0x16D1AA8", VA = "0x16D1AA8", Slot = "4")]
		public override void Initialize(MonoBehaviour monoBehaviour)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x16D1BC8", Offset = "0x16D1BC8", VA = "0x16D1BC8", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x16D212C", Offset = "0x16D212C", VA = "0x16D212C", Slot = "6")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x16D2AC8", Offset = "0x16D2AC8", VA = "0x16D2AC8", Slot = "7")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x16CF984", Offset = "0x16CF984", VA = "0x16CF984")]
		public void SetServerEndpoint(string serverEndpoint)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x16CF98C", Offset = "0x16CF98C", VA = "0x16CF98C")]
		public void SetApiKey(string apiKey)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x16D2AF0", Offset = "0x16D2AF0", VA = "0x16D2AF0")]
		public string GetApiKey()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x16CFA2C", Offset = "0x16CFA2C", VA = "0x16CFA2C")]
		public void SetSessionRefreshCB(Action sessionRefreshCB)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x16CFA34", Offset = "0x16CFA34", VA = "0x16CFA34")]
		public void SetMaxEventQueueSize(int size)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x16D055C", Offset = "0x16D055C", VA = "0x16D055C")]
		public void SetThirdPartyFetchTimeout(float timeout)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x16CFFAC", Offset = "0x16CFFAC", VA = "0x16CFFAC")]
		public void QueueLog(BaseEvent log)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16D2EE8", Offset = "0x16D2EE8", VA = "0x16D2EE8")]
		public string DispatchBatch()
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x16D1BC0", Offset = "0x16D1BC0", VA = "0x16D1BC0")]
		public void CancelSaveToDiskRequest()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x16D36C0", Offset = "0x16D36C0", VA = "0x16D36C0")]
		public void TestOnSuccess(string requestID)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x16D374C", Offset = "0x16D374C", VA = "0x16D374C")]
		public bool TestIsTimeForSaveToDisk(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x16D2CAC", Offset = "0x16D2CAC", VA = "0x16D2CAC")]
		protected void ScheduleSaveToDiskOnNextFrame()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x16D2274", Offset = "0x16D2274", VA = "0x16D2274")]
		private void TryToDispatch(float deltaTime)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x16D3628", Offset = "0x16D3628", VA = "0x16D3628")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x815750", Offset = "0x815750")]
		private IEnumerator Dispatch(AnalogRequest analogRequest)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x16D36C4", Offset = "0x16D36C4", VA = "0x16D36C4")]
		private void OnSuccess(string requestId)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x16D38DC", Offset = "0x16D38DC", VA = "0x16D38DC")]
		private void OnFailure(string requestId)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x16D31B0", Offset = "0x16D31B0", VA = "0x16D31B0")]
		private void UpdateThirdPartyForBatch(EventBatch batch)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16D33D0", Offset = "0x16D33D0", VA = "0x16D33D0")]
		private byte[] SerializeLogsForServer(EventBatch batch)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x16D1B6C", Offset = "0x16D1B6C", VA = "0x16D1B6C")]
		private void ResetExponentialDispatchBackoff()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x16D3A40", Offset = "0x16D3A40", VA = "0x16D3A40")]
		private void BumpExponentialDispatchBackoff()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x16D23D8", Offset = "0x16D23D8", VA = "0x16D23D8")]
		private bool IsTimeForSaveToDisk(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x16D386C", Offset = "0x16D386C", VA = "0x16D386C")]
		private void ScheduleSaveToDiskAfterTimeout()
		{
		}
	}
}
