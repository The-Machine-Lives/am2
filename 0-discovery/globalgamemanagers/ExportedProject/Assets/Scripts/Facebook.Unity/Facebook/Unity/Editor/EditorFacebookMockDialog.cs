using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Editor
{
	[Token(Token = "0x2000075")]
	internal abstract class EditorFacebookMockDialog : MonoBehaviour
	{
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x18")]
		private Rect modalRect;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x28")]
		private GUIStyle modalStyle;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816620", Offset = "0x816620")]
		private Utilities.Callback<ResultContainer> _003CCallback_003Ek__BackingField;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x816630", Offset = "0x816630")]
		private string _003CCallbackID_003Ek__BackingField;

		[Token(Token = "0x17000087")]
		public Utilities.Callback<ResultContainer> Callback
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0xCD2EB4", Offset = "0xCD2EB4", VA = "0xCD2EB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8170D0", Offset = "0x8170D0")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0xCD7038", Offset = "0xCD7038", VA = "0xCD7038")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8170E0", Offset = "0x8170E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public string CallbackID
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0xCD2EAC", Offset = "0xCD2EAC", VA = "0xCD2EAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8170F0", Offset = "0x8170F0")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000271")]
			[Address(RVA = "0xCD7040", Offset = "0xCD7040", VA = "0xCD7040")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x817100", Offset = "0x817100")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		protected abstract string DialogTitle
		{
			[Token(Token = "0x6000272")]
			get;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xCD7048", Offset = "0xCD7048", VA = "0xCD7048")]
		public void Start()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xCD71C8", Offset = "0xCD71C8", VA = "0xCD71C8")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000275")]
		protected abstract void DoGui();

		[Token(Token = "0x6000276")]
		protected abstract void SendSuccessResult();

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xCD72CC", Offset = "0xCD72CC", VA = "0xCD72CC", Slot = "7")]
		protected virtual void SendCancelResult()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xCD7428", Offset = "0xCD7428", VA = "0xCD7428", Slot = "8")]
		protected virtual void SendErrorResult(string errorMessage)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xCD755C", Offset = "0xCD755C", VA = "0xCD755C")]
		private void OnGUIDialog(int windowId)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xCD2EC4", Offset = "0xCD2EC4", VA = "0xCD2EC4")]
		protected EditorFacebookMockDialog()
		{
		}
	}
}
