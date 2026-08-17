using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;
using Uken.Core;
using Uken.Library.Network;
using Uken.Library.UkenTime;
using UnityEngine;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x200055E")]
	public class NetworkStatusCentre : UkenController, INetworkStatus
	{
		[Serializable]
		[Token(Token = "0x2000853")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8214F8", Offset = "0x8214F8")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40023E8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40023E9")]
			[FieldOffset(Offset = "0x8")]
			public static RemoteCertificateValidationCallback _003C_003E9__15_0;

			[Token(Token = "0x6003379")]
			[Address(RVA = "0xA7550C", Offset = "0xA7550C", VA = "0xA7550C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600337A")]
			[Address(RVA = "0xA75514", Offset = "0xA75514", VA = "0xA75514")]
			internal bool _003CLoadContent_003Eb__15_0(object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000854")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821508", Offset = "0x821508")]
		private sealed class _003CTryStatusPing_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40023EA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40023EB")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40023EC")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onComplete;

			[Token(Token = "0x40023ED")]
			[FieldOffset(Offset = "0x28")]
			private DateTime _003CwwwEnd_003E5__2;

			[Token(Token = "0x40023EE")]
			[FieldOffset(Offset = "0x30")]
			private WWW _003Cwww_003E5__3;

			[Token(Token = "0x17000837")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600337E")]
				[Address(RVA = "0xA75768", Offset = "0xA75768", VA = "0xA75768", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000838")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003380")]
				[Address(RVA = "0xA757D8", Offset = "0xA757D8", VA = "0xA757D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600337B")]
			[Address(RVA = "0xA75478", Offset = "0xA75478", VA = "0xA75478")]
			[DebuggerHidden]
			public _003CTryStatusPing_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600337C")]
			[Address(RVA = "0xA7551C", Offset = "0xA7551C", VA = "0xA7551C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600337D")]
			[Address(RVA = "0xA75520", Offset = "0xA75520", VA = "0xA75520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600337F")]
			[Address(RVA = "0xA75770", Offset = "0xA75770", VA = "0xA75770", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400197D")]
		[FieldOffset(Offset = "0x0")]
		public static bool DebugOffline;

		[Token(Token = "0x400197E")]
		[FieldOffset(Offset = "0x18")]
		public string host;

		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x20")]
		private float lastPingTime;

		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x24")]
		private float lobbyPingInterval;

		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0x28")]
		private float offlinePingInterval;

		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x2C")]
		public float networkAvailableDelay;

		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0x30")]
		public float networkUnavailableDelay;

		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0x34")]
		private float timeSinceAvailabilityUpdate;

		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x38")]
		private WWW internetStatusChecker;

		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x40")]
		private bool acceptedAvailabliity;

		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x41")]
		private bool reportedAvailability;

		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x42")]
		private bool initialized;

		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x43")]
		private bool firstReply;

		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x48")]
		private UkenTimeController m_time;

		[Token(Token = "0x600290B")]
		[Address(RVA = "0xA74C0C", Offset = "0xA74C0C", VA = "0xA74C0C")]
		public NetworkStatusCentre(UkenTimeController time)
		{
		}

		[Token(Token = "0x600290C")]
		[Address(RVA = "0xA74CC8", Offset = "0xA74CC8", VA = "0xA74CC8", Slot = "5")]
		public override bool LoadContent()
		{
			return default(bool);
		}

		[Token(Token = "0x600290D")]
		[Address(RVA = "0xA74EE4", Offset = "0xA74EE4", VA = "0xA74EE4", Slot = "9")]
		public override void OnDataUpdated()
		{
		}

		[Token(Token = "0x600290E")]
		[Address(RVA = "0xA74F14", Offset = "0xA74F14", VA = "0xA74F14", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600290F")]
		[Address(RVA = "0xA75304", Offset = "0xA75304", VA = "0xA75304")]
		public bool IsOnlineAndTimeValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6002910")]
		[Address(RVA = "0xA75368", Offset = "0xA75368", VA = "0xA75368", Slot = "11")]
		public virtual void RefreshPollIntervals()
		{
		}

		[Token(Token = "0x6002911")]
		[Address(RVA = "0xA7536C", Offset = "0xA7536C", VA = "0xA7536C")]
		public void SetHost(string host)
		{
		}

		[Token(Token = "0x6002912")]
		[Address(RVA = "0xA753AC", Offset = "0xA753AC", VA = "0xA753AC")]
		public void ResetTimer()
		{
		}

		[Token(Token = "0x6002913")]
		[Address(RVA = "0xA75360", Offset = "0xA75360", VA = "0xA75360", Slot = "10")]
		public bool IsNetworkAvailable()
		{
			return default(bool);
		}

		[Token(Token = "0x6002914")]
		[Address(RVA = "0xA753BC", Offset = "0xA753BC", VA = "0xA753BC")]
		public void ReportSuccessfulRequest()
		{
		}

		[Token(Token = "0x6002915")]
		[Address(RVA = "0xA75230", Offset = "0xA75230", VA = "0xA75230")]
		private void ReportAvailability(bool availability)
		{
		}

		[Token(Token = "0x6002916")]
		[Address(RVA = "0xA74CA8", Offset = "0xA74CA8", VA = "0xA74CA8")]
		public bool GetNetworkReachability()
		{
			return default(bool);
		}

		[Token(Token = "0x6002917")]
		[Address(RVA = "0xA7502C", Offset = "0xA7502C", VA = "0xA7502C")]
		public void TryConnection(bool asyncCall = true, bool bUseSpeedLimit = true)
		{
		}

		[Token(Token = "0x6002918")]
		[Address(RVA = "0xA753EC", Offset = "0xA753EC", VA = "0xA753EC")]
		public void VerifyConnectionWithStatusPing(Action<bool> onComplete)
		{
		}

		[Token(Token = "0x6002919")]
		[Address(RVA = "0xA75404", Offset = "0xA75404", VA = "0xA75404")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x83A428", Offset = "0x83A428")]
		private IEnumerator TryStatusPing(Action<bool> onComplete)
		{
			return null;
		}
	}
}
