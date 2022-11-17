using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace Opencoding.Console
{
	[Token(Token = "0x200000F")]
	internal class KeyboardInputField : InputField
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		private string _commandInput;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		private Rect _commandInputRect;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x48")]
		private TextEditor _commandInputBoxTextEditor;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x50")]
		private readonly ImageFilesContainer _imageFiles;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x58")]
		private readonly InputHistory _inputHistory;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x60")]
		private int _tabIndex;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x64")]
		private bool _moveCursorToEndNextRepaint;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x68")]
		private string _inputFieldName;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x70")]
		private FieldInfo _unityBefore53ContentField;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x78")]
		private PropertyInfo _unityAfter53TextProperty;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x80")]
		private bool _isOnUnityBefore53;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x88")]
		private readonly LogHistoryView _logHistoryView;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x90")]
		private readonly HelpOverlay _helpOverlay;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x98")]
		private readonly PropertyInfo _cursorIndexProperty;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xA0")]
		private readonly PropertyInfo _selectIndexProperty;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xA8")]
		private readonly FieldInfo _cursorIndexField;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xB0")]
		private readonly FieldInfo _selectIndexField;

		[Token(Token = "0x17000025")]
		public override string Input
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xE8948C", Offset = "0xE8948C", VA = "0xE8948C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE89494", Offset = "0xE89494", VA = "0xE89494", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public override bool HasFocus
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xE89728", Offset = "0xE89728", VA = "0xE89728", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public override Rect TextFieldRect
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xE89798", Offset = "0xE89798", VA = "0xE89798", Slot = "7")]
			get
			{
				return default(Rect);
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE7A7B4", Offset = "0xE7A7B4", VA = "0xE7A7B4")]
		public KeyboardInputField(ImageFilesContainer imageFiles, InputHistory inputHistory, LogHistoryView logHistoryView, HelpOverlay helpOverlay)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE897A4", Offset = "0xE897A4", VA = "0xE897A4", Slot = "8")]
		public override void OnGUI(Rect containingRect)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE8A214", Offset = "0xE8A214", VA = "0xE8A214", Slot = "11")]
		public override void ClearInput()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE8A170", Offset = "0xE8A170", VA = "0xE8A170")]
		private void HandleKeyDownEvent()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE8A264", Offset = "0xE8A264", VA = "0xE8A264")]
		private void HandleReturnKeyPressed()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE8A66C", Offset = "0xE8A66C", VA = "0xE8A66C")]
		private void HandleUpKeyPressed()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE8A6EC", Offset = "0xE8A6EC", VA = "0xE8A6EC")]
		private void HandleDownKeyPressed()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE8A358", Offset = "0xE8A358", VA = "0xE8A358")]
		private void HandleTabKeyPressed()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE89524", Offset = "0xE89524", VA = "0xE89524")]
		private void SetTextEditorTextWithReflection()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE8A76C", Offset = "0xE8A76C", VA = "0xE8A76C", Slot = "9")]
		public override void LoseFocus()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xE8A774", Offset = "0xE8A774", VA = "0xE8A774", Slot = "10")]
		public override void Focus()
		{
		}
	}
}
