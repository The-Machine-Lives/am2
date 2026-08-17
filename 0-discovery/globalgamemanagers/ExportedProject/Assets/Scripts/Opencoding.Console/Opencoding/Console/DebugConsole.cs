using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Opencoding.CommandHandlerSystem;
using Opencoding.Console.TouchDetectors;
using Opencoding.LogHistory;
using Opencoding.Shared.Utils;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000002")]
	public class DebugConsole : MonoBehaviour
	{
		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C8DC", Offset = "0x81C8DC")]
		private sealed class _003CAnimateConsoleIn_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000121")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebugConsole _003C_003E4__this;

			[Token(Token = "0x4000122")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _003ClastTime_003E5__1;

			[Token(Token = "0x4000123")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003CdeltaTime_003E5__2;

			[Token(Token = "0x1700007F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60001C2")]
				[Address(RVA = "0xE8138C", Offset = "0xE8138C", VA = "0xE8138C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000080")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60001C4")]
				[Address(RVA = "0xE813FC", Offset = "0xE813FC", VA = "0xE813FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE791F8", Offset = "0xE791F8", VA = "0xE791F8")]
			[DebuggerHidden]
			public _003CAnimateConsoleIn_003Ed__56(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE81218", Offset = "0xE81218", VA = "0xE81218", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xE8121C", Offset = "0xE8121C", VA = "0xE8121C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xE81394", Offset = "0xE81394", VA = "0xE81394", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C8EC", Offset = "0x81C8EC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000124")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000125")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, bool> _003C_003E9__91_0;

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xE810CC", Offset = "0xE810CC", VA = "0xE810CC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xE810D4", Offset = "0xE810D4", VA = "0xE810D4")]
			internal bool _003CInitialize_003Eb__91_0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C8FC", Offset = "0x81C8FC")]
		private sealed class _003C_003Ec__DisplayClass114_0
		{
			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DebugConsole _003C_003E4__this;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string filename;

			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string> callback;

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xE7FC9C", Offset = "0xE7FC9C", VA = "0xE7FC9C")]
			public _003C_003Ec__DisplayClass114_0()
			{
			}

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xE81128", Offset = "0xE81128", VA = "0xE81128")]
			internal void _003CEmailLog_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C90C", Offset = "0x81C90C")]
		private sealed class _003C_003Ec__DisplayClass115_0
		{
			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DebugConsole _003C_003E4__this;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string filename;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action callback;

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xE7FDD0", Offset = "0xE7FDD0", VA = "0xE7FDD0")]
			public _003C_003Ec__DisplayClass115_0()
			{
			}

			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xE811B4", Offset = "0xE811B4", VA = "0xE811B4")]
			internal void _003CExportLog_003Eb__0(byte[] data)
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector2 OFF_SCREEN_MOUSE_POSITION;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ImageFilesContainer _imageFiles;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EmailTemplateFilesContainer _emailTemplateFiles;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Opencoding.LogHistory.LogHistory _logHistory;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FilteredLogHistoryViewModel _logHistoryViewModel;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputHistory _inputHistory;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HeaderBar _headerBar;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private FilterBar _filterBar;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SettingsOverlay _settingsOverlay;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private LogHistoryView _logHistoryView;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LogItemPopupMenu _logItemPopupMenu;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private InputField _inputField;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CommandInformation _commandInformation;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Suggestions _suggestions;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private HelpOverlay _helpOverlay;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TouchDetector _touchDetector;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<string> _recentCommands;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _previousScreenHeight;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _previousScreenWidth;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _visible;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _timescaleWhenConsoleOpened;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LogSearch _logSearch;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Email, bool> CompleteLogEmailPreprocessor;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<IEnumerable<SaveFileData>> SaveFileProvider;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<IEnumerable<KeyValuePair<string, string>>> GameInfoProvider;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<bool> ConsoleAboutToOpen;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<bool> ConsoleAboutToClose;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _consoleTop;

		[NonSerialized]
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool _hasInitialized;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MonoBehaviour _eventSystemWhenConsoleOpened;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C99C", Offset = "0x81C99C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81C99C", Offset = "0x81C99C")]
		private static DebugConsole _003CInstance_003Ek__BackingField;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81C9D8", Offset = "0x81C9D8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81C9D8", Offset = "0x81C9D8")]
		private bool _003CShowOnException_003Ek__BackingField;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CA14", Offset = "0x81CA14")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CA14", Offset = "0x81CA14")]
		private bool _003CJustMadeVisible_003Ek__BackingField;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static PropertyInfo _currentUGUIEventSystemProperty;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CA50", Offset = "0x81CA50")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CA50", Offset = "0x81CA50")]
		private bool _003CIsMaximized_003Ek__BackingField;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CA8C", Offset = "0x81CA8C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CA8C", Offset = "0x81CA8C")]
		private Rect _003CRect_003Ek__BackingField;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CAC8", Offset = "0x81CAC8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CAC8", Offset = "0x81CAC8")]
		private int _003CConsoleWidth_003Ek__BackingField;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Rect _safeArea;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _screenWidth;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int _screenHeight;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool _showLogHistory;

		[Token(Token = "0x17000001")]
		public static DebugConsole Instance
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0xE78818", Offset = "0xE78818", VA = "0xE78818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DBC8", Offset = "0x81DBC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xE78880", Offset = "0xE78880", VA = "0xE78880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DBD8", Offset = "0x81DBD8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool ShowOnException
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0xE788EC", Offset = "0xE788EC", VA = "0xE788EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DBE8", Offset = "0x81DBE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xE788F4", Offset = "0xE788F4", VA = "0xE788F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DBF8", Offset = "0x81DBF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public Settings Settings
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xE78900", Offset = "0xE78900", VA = "0xE78900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public EmailTemplateFilesContainer EmailTemplateFiles
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xE78908", Offset = "0xE78908", VA = "0xE78908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public ImageFilesContainer ImageFiles
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xE78910", Offset = "0xE78910", VA = "0xE78910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public bool JustMadeVisible
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xE78918", Offset = "0xE78918", VA = "0xE78918")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC08", Offset = "0x81DC08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0xE78920", Offset = "0xE78920", VA = "0xE78920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC18", Offset = "0x81DC18")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public static bool IsVisible
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xE7892C", Offset = "0xE7892C", VA = "0xE7892C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xE78A0C", Offset = "0xE78A0C", VA = "0xE78A0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		private bool _IsVisible
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xE78A04", Offset = "0xE78A04", VA = "0xE78A04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xE78B28", Offset = "0xE78B28", VA = "0xE78B28")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool IsMaximized
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xE79328", Offset = "0xE79328", VA = "0xE79328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC28", Offset = "0x81DC28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xE79330", Offset = "0xE79330", VA = "0xE79330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC38", Offset = "0x81DC38")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Rect Rect
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xE7933C", Offset = "0xE7933C", VA = "0xE7933C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC48", Offset = "0x81DC48")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xE79038", Offset = "0xE79038", VA = "0xE79038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC58", Offset = "0x81DC58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public IEnumerable<string> RecentCommands
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xE79348", Offset = "0xE79348", VA = "0xE79348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public bool IsPopupMenuOpen
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xE79350", Offset = "0xE79350", VA = "0xE79350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public float ConsoleTop
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xE771C4", Offset = "0xE771C4", VA = "0xE771C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xE79384", Offset = "0xE79384", VA = "0xE79384")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public TouchDetector CustomTouchDetector
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xE7938C", Offset = "0xE7938C", VA = "0xE7938C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xE79394", Offset = "0xE79394", VA = "0xE79394")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int ConsoleWidth
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xE795E8", Offset = "0xE795E8", VA = "0xE795E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC68", Offset = "0x81DC68")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xE795F0", Offset = "0xE795F0", VA = "0xE795F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DC78", Offset = "0x81DC78")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public float ActualConsoleWidth
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xE77718", Offset = "0xE77718", VA = "0xE77718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float ConsoleLeft
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xE7C4D0", Offset = "0xE7C4D0", VA = "0xE7C4D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xE791D0", Offset = "0xE791D0", VA = "0xE791D0")]
		public void ShowConsoleInstantly()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xE78FC4", Offset = "0xE78FC4", VA = "0xE78FC4")]
		private IEnumerator AnimateConsoleIn()
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xE79224", Offset = "0xE79224", VA = "0xE79224")]
		private static void CacheCurrentUGUIEventSystemProperty()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xE78DA0", Offset = "0xE78DA0", VA = "0xE78DA0")]
		private static void DisableUGUIEventSystem()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xE79044", Offset = "0xE79044", VA = "0xE79044")]
		private static void EnableUGUIEventSystem()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE79410", Offset = "0xE79410", VA = "0xE79410")]
		public void SelectBuiltInTouchDetector(Settings.SelectedTouchDetector touchDetector)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE795F8", Offset = "0xE795F8", VA = "0xE795F8")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE79A50", Offset = "0xE79A50", VA = "0xE79A50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE79A54", Offset = "0xE79A54", VA = "0xE79A54")]
		private void UpdateSafeArea()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE796E8", Offset = "0xE796E8", VA = "0xE796E8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE7A1D4", Offset = "0xE7A1D4", VA = "0xE7A1D4")]
		private void InitUIElements()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE7AD1C", Offset = "0xE7AD1C", VA = "0xE7AD1C")]
		protected void OnDestroy()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE7B120", Offset = "0xE7B120", VA = "0xE7B120")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE7B580", Offset = "0xE7B580", VA = "0xE7B580")]
		public static bool IsOnUnityVersionWithBrokenKeyboardInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE7B6F8", Offset = "0xE7B6F8", VA = "0xE7B6F8")]
		private void UpdateRecentCommandsListAfterCommandExecuted(CommandHandler handler)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE79190", Offset = "0xE79190", VA = "0xE79190")]
		private void OnConsoleHidden()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE7B8E0", Offset = "0xE7B8E0", VA = "0xE7B8E0")]
		public void HidePopups()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE7BA94", Offset = "0xE7BA94", VA = "0xE7BA94")]
		public void SetCommandInputTextAsIfTyped(string text)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE7BB74", Offset = "0xE7BB74", VA = "0xE7BB74")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE7CB94", Offset = "0xE7CB94", VA = "0xE7CB94")]
		private void DrawSuggestionsUI()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xE7C244", Offset = "0xE7C244", VA = "0xE7C244")]
		public float GetConsoleHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE7C018", Offset = "0xE7C018", VA = "0xE7C018")]
		private void OnScreenRotated()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE7DA7C", Offset = "0xE7DA7C", VA = "0xE7DA7C")]
		private void OnLogHistoryItemAdded(LogHistoryItem logHistoryItem)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE7DB1C", Offset = "0xE7DB1C", VA = "0xE7DB1C")]
		private void WindowFunc(int windowId)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE7E504", Offset = "0xE7E504", VA = "0xE7E504")]
		private void DrawMainWindow(int windowId, bool inFocus)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE7F974", Offset = "0xE7F974", VA = "0xE7F974")]
		public void Minimize()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE7F97C", Offset = "0xE7F97C", VA = "0xE7F97C")]
		public string DetectCloseKeyInInputText(string input)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE7FAD0", Offset = "0xE7FAD0", VA = "0xE7FAD0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE7FB20", Offset = "0xE7FB20", VA = "0xE7FB20")]
		public void EmailLog([Optional] Action<string> callback)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE7FCA4", Offset = "0xE7FCA4", VA = "0xE7FCA4")]
		public void ExportLog(string filename, bool captureScreenshot, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE7FEC4", Offset = "0xE7FEC4", VA = "0xE7FEC4")]
		private void ExportLog(byte[] screenshotData, string filename)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE80B54", Offset = "0xE80B54", VA = "0xE80B54")]
		private void EmailOrOpenLog(string filename)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE80F6C", Offset = "0xE80F6C", VA = "0xE80F6C")]
		public DebugConsole()
		{
		}
	}
}
