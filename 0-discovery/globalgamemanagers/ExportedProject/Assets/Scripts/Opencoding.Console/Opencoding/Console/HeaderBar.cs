using Il2CppDummyDll;
using Opencoding.LogHistory;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200000C")]
	internal class HeaderBar
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		private readonly DebugConsole _debugConsole;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		private readonly FilteredLogHistoryViewModel _logHistoryViewModel;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		private readonly InputField _inputField;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x28")]
		private readonly FilterBar _filterBar;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x30")]
		private readonly SettingsOverlay _settingsOverlay;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x38")]
		private readonly Opencoding.LogHistory.LogHistory _logHistory;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x40")]
		private readonly ImageFilesContainer _imageFiles;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x48")]
		private readonly Settings _settings;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE7ACA0", Offset = "0xE7ACA0", VA = "0xE7ACA0")]
		public HeaderBar(DebugConsole debugConsole, FilteredLogHistoryViewModel filteredLogHistoryViewModel, InputField inputField, FilterBar filterBar, SettingsOverlay settingsOverlay, Opencoding.LogHistory.LogHistory logHistory, Settings settings)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE7E798", Offset = "0xE7E798", VA = "0xE7E798")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE8893C", Offset = "0xE8893C", VA = "0xE8893C")]
		private void HandleButtonHeld(LogType logType)
		{
		}
	}
}
