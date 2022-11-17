using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.LogHistory
{
	[Token(Token = "0x2000006")]
	public class LogHistory : IDisposable
	{
		[Serializable]
		[Token(Token = "0x2000007")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811D20", Offset = "0x811D20")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x8")]
			public static Action<LogHistoryItem> _003C_003E9__47_0;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x10")]
			public static Action<LogHistoryItem> _003C_003E9__47_1;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x18")]
			public static Action _003C_003E9__47_2;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x180BC7C", Offset = "0x180BC7C", VA = "0x180BC7C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x180BC84", Offset = "0x180BC84", VA = "0x180BC84")]
			internal void _003C_002Ector_003Eb__47_0(LogHistoryItem _003Cp0_003E)
			{
			}

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x180BC88", Offset = "0x180BC88", VA = "0x180BC88")]
			internal void _003C_002Ector_003Eb__47_1(LogHistoryItem _003Cp0_003E)
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x180BC8C", Offset = "0x180BC8C", VA = "0x180BC8C")]
			internal void _003C_002Ector_003Eb__47_2()
			{
			}
		}

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		private int _itemLimit;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<LogHistoryItem> _deferredLogItems;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<LogHistoryItem> _logItems;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		private DateTime _gameStartTime;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x811D30", Offset = "0x811D30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811D30", Offset = "0x811D30")]
		private int _003CInfoCount_003Ek__BackingField;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811D6C", Offset = "0x811D6C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x811D6C", Offset = "0x811D6C")]
		private int _003CWarningCount_003Ek__BackingField;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x811DA8", Offset = "0x811DA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811DA8", Offset = "0x811DA8")]
		private int _003CErrorCount_003Ek__BackingField;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811DE4", Offset = "0x811DE4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x811DE4", Offset = "0x811DE4")]
		private int _003CExceptionCount_003Ek__BackingField;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E20", Offset = "0x811E20")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x811E20", Offset = "0x811E20")]
		private int _003CAssertCount_003Ek__BackingField;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		private object _deferredLogItemListMutex;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		private Action<LogHistoryItem> _logHistoryItemAdded;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		private Action<LogHistoryItem> _logHistoryItemRemoved;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		private Action _logHistoryCleared;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private static LogHistory _instance;

		[Token(Token = "0x17000001")]
		public int InfoCount
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x180A43C", Offset = "0x180A43C", VA = "0x180A43C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E5C", Offset = "0x811E5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x180A444", Offset = "0x180A444", VA = "0x180A444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E6C", Offset = "0x811E6C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public int WarningCount
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x180A44C", Offset = "0x180A44C", VA = "0x180A44C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E7C", Offset = "0x811E7C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x180A454", Offset = "0x180A454", VA = "0x180A454")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E8C", Offset = "0x811E8C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public int ErrorCount
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x180A45C", Offset = "0x180A45C", VA = "0x180A45C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811E9C", Offset = "0x811E9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x180A464", Offset = "0x180A464", VA = "0x180A464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811EAC", Offset = "0x811EAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int ExceptionCount
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x180A46C", Offset = "0x180A46C", VA = "0x180A46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811EBC", Offset = "0x811EBC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x180A474", Offset = "0x180A474", VA = "0x180A474")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811ECC", Offset = "0x811ECC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public int AssertCount
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x180A47C", Offset = "0x180A47C", VA = "0x180A47C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811EDC", Offset = "0x811EDC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x180A484", Offset = "0x180A484", VA = "0x180A484")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x811EEC", Offset = "0x811EEC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public DateTime GameStartTime
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x180A48C", Offset = "0x180A48C", VA = "0x180A48C")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x17000007")]
		public IList<LogHistoryItem> LogItems
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x180A92C", Offset = "0x180A92C", VA = "0x180A92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static LogHistory Instance
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x180A98C", Offset = "0x180A98C", VA = "0x180A98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<LogHistoryItem> LogHistoryItemAdded
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x180A494", Offset = "0x180A494", VA = "0x180A494")]
			add
			{
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x180A558", Offset = "0x180A558", VA = "0x180A558")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<LogHistoryItem> LogHistoryItemRemoved
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x180A61C", Offset = "0x180A61C", VA = "0x180A61C")]
			add
			{
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x180A6E0", Offset = "0x180A6E0", VA = "0x180A6E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action LogHistoryCleared
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x180A7A4", Offset = "0x180A7A4", VA = "0x180A7A4")]
			add
			{
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x180A868", Offset = "0x180A868", VA = "0x180A868")]
			remove
			{
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x180A9F4", Offset = "0x180A9F4", VA = "0x180A9F4")]
		public LogHistory()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x180ADB8", Offset = "0x180ADB8", VA = "0x180ADB8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x180AEA0", Offset = "0x180AEA0", VA = "0x180AEA0")]
		public void Update()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x180B2A8", Offset = "0x180B2A8", VA = "0x180B2A8")]
		private void UpdateTypeCounter(LogHistoryLogType type, int change)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x180B318", Offset = "0x180B318", VA = "0x180B318")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x180B420", Offset = "0x180B420", VA = "0x180B420")]
		private string FilterStackTrace(string stackTrace)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x180B63C", Offset = "0x180B63C", VA = "0x180B63C")]
		public LogHistoryLogType ConvertFromUnityLogType(LogType logType)
		{
			return default(LogHistoryLogType);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x180B708", Offset = "0x180B708", VA = "0x180B708")]
		private void HandleLoggingEvent(string logString, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x180B74C", Offset = "0x180B74C", VA = "0x180B74C")]
		private void InternalHandleLoggingEvent(string logString, string stackTrace, LogHistoryLogType type)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x180BA44", Offset = "0x180BA44", VA = "0x180BA44")]
		public void LogMessage(string message, LogHistoryLogType type = LogHistoryLogType.Log)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x180BAAC", Offset = "0x180BAAC", VA = "0x180BAAC")]
		private void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
		}
	}
}
