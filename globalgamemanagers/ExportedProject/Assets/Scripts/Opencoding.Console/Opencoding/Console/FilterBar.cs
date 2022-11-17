using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200000A")]
	internal class FilterBar
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		private bool _isVisible;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x11")]
		private bool _justMadeVisible;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x18")]
		private readonly LogHistoryView _logHistoryView;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x20")]
		private readonly FilteredLogHistoryViewModel _filteredLogHistoryViewModel;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x28")]
		private readonly TouchScreenKeyboardInput _filterInputField;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private readonly TouchScreenKeyboardInput _searchInputField;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private readonly LogSearch _logSearch;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x40")]
		private bool _hideNextFrame;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x44")]
		private int MINIMUM_WIDTH_FOR_SINGLE_LINE;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x48")]
		private DebugConsole _debugConsole;

		[Token(Token = "0x1700001B")]
		public bool IsVisible
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0xE7D8FC", Offset = "0xE7D8FC", VA = "0xE7D8FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xE7B954", Offset = "0xE7B954", VA = "0xE7B954")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float Height
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0xE7D904", Offset = "0xE7D904", VA = "0xE7D904")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE7ABA8", Offset = "0xE7ABA8", VA = "0xE7ABA8")]
		public FilterBar(DebugConsole debugConsole, FilteredLogHistoryViewModel filteredLogHistoryViewModel, LogSearch logSearch, LogHistoryView logHistoryView)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE7F2F0", Offset = "0xE7F2F0", VA = "0xE7F2F0")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE7B4C0", Offset = "0xE7B4C0", VA = "0xE7B4C0")]
		public void Update()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE81484", Offset = "0xE81484", VA = "0xE81484")]
		private void DrawFilterLine()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE81714", Offset = "0xE81714", VA = "0xE81714")]
		private void DrawSearchLine()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE82444", Offset = "0xE82444", VA = "0xE82444")]
		private void SelectCurrentSearchResultBasedOnLogScroll()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE81EC0", Offset = "0xE81EC0", VA = "0xE81EC0")]
		private void TouchFriendlyTextField(TouchScreenKeyboardInput touchScreenKeyboardInput, GUIStyle style)
		{
		}
	}
}
