using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Uniject;

namespace UnityEngine.Purchasing.Extension
{
	[Token(Token = "0x200002D")]
	[HideInInspector]
	internal class UnityUtil : MonoBehaviour, IUtil
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8186BC", Offset = "0x8186BC")]
		private sealed class _003CDelayedCoroutine_003Ec__Iterator0 : IEnumerator, IDisposable, IEnumerator<object>
		{
			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x10")]
			internal int delay;

			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x18")]
			internal IEnumerator coroutine;

			[Token(Token = "0x4000055")]
			[FieldOffset(Offset = "0x20")]
			internal UnityUtil _0024this;

			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x28")]
			internal object _0024current;

			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x30")]
			internal bool _0024disposing;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x34")]
			internal int _0024PC;

			[Token(Token = "0x1700000E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x1785D30", Offset = "0x1785D30", VA = "0x1785D30", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x1785D38", Offset = "0x1785D38", VA = "0x1785D38", Slot = "5")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x178563C", Offset = "0x178563C", VA = "0x178563C")]
			[DebuggerHidden]
			public _003CDelayedCoroutine_003Ec__Iterator0()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1785C3C", Offset = "0x1785C3C", VA = "0x1785C3C", Slot = "4")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1785D40", Offset = "0x1785D40", VA = "0x1785D40", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1785D54", Offset = "0x1785D54", VA = "0x1785D54", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		private static List<Action> s_Callbacks;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_CallbacksPending;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		private static List<RuntimePlatform> s_PcControlledPlatforms;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x18")]
		private List<Action<bool>> pauseListeners;

		[Token(Token = "0x17000006")]
		public DateTime currentTime
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x17850C4", Offset = "0x17850C4", VA = "0x17850C4", Slot = "9")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000007")]
		public string persistentDataPath
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1785124", Offset = "0x1785124", VA = "0x1785124", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public RuntimePlatform platform
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x178512C", Offset = "0x178512C", VA = "0x178512C", Slot = "11")]
			get
			{
				return default(RuntimePlatform);
			}
		}

		[Token(Token = "0x17000009")]
		public bool isEditor
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x1785134", Offset = "0x1785134", VA = "0x1785134", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		public string deviceModel
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x178513C", Offset = "0x178513C", VA = "0x178513C", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public string deviceName
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x1785144", Offset = "0x1785144", VA = "0x1785144", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public DeviceType deviceType
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x178514C", Offset = "0x178514C", VA = "0x178514C", Slot = "15")]
			get
			{
				return default(DeviceType);
			}
		}

		[Token(Token = "0x1700000D")]
		public string operatingSystem
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x1785154", Offset = "0x1785154", VA = "0x1785154", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1785054", Offset = "0x1785054", VA = "0x1785054")]
		public UnityUtil()
		{
		}

		[Token(Token = "0x6000082")]
		public T[] GetAnyComponentsOfType<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x178515C", Offset = "0x178515C", VA = "0x178515C", Slot = "4")]
		private object Uniject_002EIUtil_002EInitiateCoroutine(IEnumerator start)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1785164", Offset = "0x1785164", VA = "0x1785164", Slot = "5")]
		private void Uniject_002EIUtil_002EInitiateCoroutine(IEnumerator start, int delay)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1785214", Offset = "0x1785214", VA = "0x1785214", Slot = "6")]
		public void RunOnMainThread(Action runnable)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1785350", Offset = "0x1785350", VA = "0x1785350", Slot = "17")]
		public object GetWaitForSeconds(int seconds)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x17853B4", Offset = "0x17853B4", VA = "0x17853B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000090")]
		public static T FindInstanceOfType<T>() where T : MonoBehaviour
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		public static T LoadResourceInstanceOfType<T>() where T : MonoBehaviour
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1785430", Offset = "0x1785430", VA = "0x1785430")]
		public static bool PcPlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x17854C4", Offset = "0x17854C4", VA = "0x17854C4")]
		public static void DebugLog(string message, params object[] args)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1785168", Offset = "0x1785168", VA = "0x1785168")]
		[DebuggerHidden]
		private IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay)
		{
			return null;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1785644", Offset = "0x1785644", VA = "0x1785644")]
		private void Update()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x17858DC", Offset = "0x17858DC", VA = "0x17858DC", Slot = "7")]
		public void AddPauseListener(Action<bool> runnable)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x178594C", Offset = "0x178594C", VA = "0x178594C")]
		public void OnApplicationPause(bool paused)
		{
		}
	}
}
