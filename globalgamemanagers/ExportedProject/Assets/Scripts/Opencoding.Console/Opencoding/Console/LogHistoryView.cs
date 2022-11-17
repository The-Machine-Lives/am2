using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Opencoding.LogHistory;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x2000010")]
	internal class LogHistoryView : IDisposable
	{
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81CF98", Offset = "0x81CF98")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x81CF98", Offset = "0x81CF98")]
		private LogHistoryItem _003CItemInMiddleOfScreen_003Ek__BackingField;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x18")]
		private bool _autoScrolling;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x20")]
		private readonly DebugConsole _debugConsole;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		private readonly FilteredLogHistoryViewModel _viewModel;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		private readonly LogSearch _logSearch;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x38")]
		private readonly LogItemPopupMenu _logItemPopupMenu;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x40")]
		private int _expandedLogHistoryItemIndex;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x44")]
		private int _expandedItemHeight;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x48")]
		private string _expandedItemStacktrace;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x50")]
		private bool _isDragging;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x54")]
		private float _totalDragDelta;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 _scrollPosition;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x60")]
		private float _listHeight;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x64")]
		private float _scollingViewTopInWindowCoords;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 _clickDownPosition;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x70")]
		private float _clickDownTime;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x74")]
		private int PADDING_BETWEEN_MESSAGE_AND_STACKTRACE;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		private static Regex _stackTraceFormattingRegex;

		[Token(Token = "0x17000028")]
		public LogHistoryItem ItemInMiddleOfScreen
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xE82888", Offset = "0xE82888", VA = "0xE82888")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCE8", Offset = "0x81DCE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0xE8C9C4", Offset = "0xE8C9C4", VA = "0xE8C9C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81DCF8", Offset = "0x81DCF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool AutoScrolling
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xE8C9CC", Offset = "0xE8C9CC", VA = "0xE8C9CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE7B8D4", Offset = "0xE7B8D4", VA = "0xE7B8D4")]
			set
			{
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xE7A480", Offset = "0xE7A480", VA = "0xE7A480")]
		public LogHistoryView(FilteredLogHistoryViewModel viewModel, LogItemPopupMenu logItemPopupMenu, DebugConsole debugConsole, LogSearch logSearch)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xE8CA2C", Offset = "0xE8CA2C", VA = "0xE8CA2C")]
		private void DecrementExpandedItemIndex(LogHistoryItem obj)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE8CA40", Offset = "0xE8CA40", VA = "0xE8CA40")]
		private void CollapseExpandedItem()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE7B4D8", Offset = "0xE7B4D8", VA = "0xE7B4D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE7F6B8", Offset = "0xE7F6B8", VA = "0xE7F6B8")]
		public void OnGUI(bool inFocus)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE8CFE0", Offset = "0xE8CFE0", VA = "0xE8CFE0")]
		private void HandleTouchDrag(Rect listRect)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE8273C", Offset = "0xE8273C", VA = "0xE8273C")]
		public void JumpToCurrentSearchResult()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE8D590", Offset = "0xE8D590", VA = "0xE8D590")]
		private void ExpandItem(int index, Rect itemRect)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE8D958", Offset = "0xE8D958", VA = "0xE8D958")]
		private static string TrimLogMessageIfNecessary(string message)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE8D9FC", Offset = "0xE8D9FC", VA = "0xE8D9FC")]
		private string FormatStackTrace(string stackTrace)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE8D3A4", Offset = "0xE8D3A4", VA = "0xE8D3A4")]
		private void ScrollToShowItem(LogHistoryItem item)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE8CA4C", Offset = "0xE8CA4C", VA = "0xE8CA4C")]
		private void DrawConsoleItemList(bool inFocus)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE8D1F4", Offset = "0xE8D1F4", VA = "0xE8D1F4")]
		private int CalculateListHeight()
		{
			return default(int);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE8DAAC", Offset = "0xE8DAAC", VA = "0xE8DAAC")]
		private int GetItemTop(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE8DB70", Offset = "0xE8DB70", VA = "0xE8DB70")]
		private int GetItemHeight(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE8D8B0", Offset = "0xE8D8B0", VA = "0xE8D8B0")]
		private int CalculateRowTextSpaceAvailable(Rect itemRect)
		{
			return default(int);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE8DBFC", Offset = "0xE8DBFC", VA = "0xE8DBFC")]
		private void DrawConsoleItem(Rect itemRect, LogHistoryItem historyItem, int index, bool inFocus)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE8E1E4", Offset = "0xE8E1E4", VA = "0xE8E1E4")]
		private void HandleMouseDownOnItem(int controlId)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE8E89C", Offset = "0xE8E89C", VA = "0xE8E89C")]
		private void HandleMobileTouchBeginOnItem()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE8DF4C", Offset = "0xE8DF4C", VA = "0xE8DF4C")]
		private void HandleMouseUpOnItem(Rect itemRect, LogHistoryItem historyItem, int index, int controlId)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE8E938", Offset = "0xE8E938", VA = "0xE8E938")]
		private void ShowItemPopup(LogHistoryItem historyItem)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE8E674", Offset = "0xE8E674", VA = "0xE8E674")]
		private void DrawCollapsedItemContent(Rect itemRect, LogHistoryItem historyItem)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE8E288", Offset = "0xE8E288", VA = "0xE8E288")]
		private void DrawExpandedItemContent(Rect itemRect, LogHistoryItem historyItem)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE7AF0C", Offset = "0xE7AF0C", VA = "0xE7AF0C", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
