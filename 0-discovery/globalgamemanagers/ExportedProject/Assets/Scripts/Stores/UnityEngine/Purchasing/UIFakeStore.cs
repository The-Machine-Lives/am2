using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UnityEngine.Purchasing
{
	[Token(Token = "0x2000029")]
	internal class UIFakeStore : FakeStore
	{
		[Token(Token = "0x200002A")]
		protected class DialogRequest
		{
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x10")]
			public string QueryText;

			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x18")]
			public string OkayButtonText;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x20")]
			public string CancelButtonText;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x28")]
			public List<string> Options;

			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x30")]
			public Action<bool, int> Callback;

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x1789E84", Offset = "0x1789E84", VA = "0x1789E84")]
			public DialogRequest()
			{
			}
		}

		[Token(Token = "0x200002B")]
		protected class LifecycleNotifier : MonoBehaviour
		{
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x18")]
			public Action OnDestroyCallback;

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x178B0B8", Offset = "0x178B0B8", VA = "0x178B0B8")]
			public LifecycleNotifier()
			{
			}

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x178B0C0", Offset = "0x178B0C0", VA = "0x178B0C0")]
			private void OnDestroy()
			{
			}
		}

		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81869C", Offset = "0x81869C")]
		private sealed class _003CStartUI_003Ec__AnonStorey0<T>
		{
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x0")]
			internal Action<bool, T> callback;

			[Token(Token = "0x600007F")]
			public _003CStartUI_003Ec__AnonStorey0()
			{
			}

			[Token(Token = "0x6000080")]
			internal void _003C_003Em__0(bool result, int codeValue)
			{
			}
		}

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x38")]
		private DialogRequest m_CurrentDialog;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x40")]
		private int m_LastSelectedDropdownIndex;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x48")]
		private GameObject UIFakeStoreCanvasPrefab;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_EventSystem;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x60")]
		private string m_ParentGameObjectPath;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x818818", Offset = "0x818818")]
		private static Func<ProductDefinition, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1789D38", Offset = "0x1789D38", VA = "0x1789D38")]
		public UIFakeStore()
		{
		}

		[Token(Token = "0x6000066")]
		protected override bool StartUI<T>(object model, DialogType dialogType, Action<bool, T> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1789D70", Offset = "0x1789D70", VA = "0x1789D70")]
		private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, List<string> options, Action<bool, int> callback)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1789E8C", Offset = "0x1789E8C", VA = "0x1789E8C")]
		private void InstantiateDialog()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x178AB18", Offset = "0x178AB18", VA = "0x178AB18")]
		private string CreatePurchaseQuestion(ProductDefinition definition)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x178AB94", Offset = "0x178AB94", VA = "0x178AB94")]
		private string CreateRetrieveProductsQuestion(ReadOnlyCollection<ProductDefinition> definitions)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x178A920", Offset = "0x178A920", VA = "0x178A920")]
		private Button GetOkayButton()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x178A99C", Offset = "0x178A99C", VA = "0x178A99C")]
		private Button GetCancelButton()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x178AABC", Offset = "0x178AABC", VA = "0x178AABC")]
		private GameObject GetCancelButtonGameObject()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x178A764", Offset = "0x178A764", VA = "0x178A764")]
		private Text GetOkayButtonText()
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x178A7E0", Offset = "0x178A7E0", VA = "0x178A7E0")]
		private Text GetCancelButtonText()
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x178A85C", Offset = "0x178A85C", VA = "0x178A85C")]
		private Dropdown GetDropdown()
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x178AA60", Offset = "0x178AA60", VA = "0x178AA60")]
		private GameObject GetDropdownContainerGameObject()
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x178AD1C", Offset = "0x178AD1C", VA = "0x178AD1C")]
		private void OkayButtonClicked()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x178AFAC", Offset = "0x178AFAC", VA = "0x178AFAC")]
		private void CancelButtonClicked()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x178B06C", Offset = "0x178B06C", VA = "0x178B06C")]
		private void DropdownValueChanged(int selectedItem)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x178ADF8", Offset = "0x178ADF8", VA = "0x178ADF8")]
		private void CloseDialog()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1789E74", Offset = "0x1789E74", VA = "0x1789E74")]
		public bool IsShowingDialog()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x178B074", Offset = "0x178B074", VA = "0x178B074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81892C", Offset = "0x81892C")]
		private void _003CInstantiateDialog_003Em__0()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x178B07C", Offset = "0x178B07C", VA = "0x178B07C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81893C", Offset = "0x81893C")]
		private void _003CInstantiateDialog_003Em__1()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x178B080", Offset = "0x178B080", VA = "0x178B080")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81894C", Offset = "0x81894C")]
		private void _003CInstantiateDialog_003Em__2()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x178B084", Offset = "0x178B084", VA = "0x178B084")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81895C", Offset = "0x81895C")]
		private void _003CInstantiateDialog_003Em__3(int selectedItem)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x178B08C", Offset = "0x178B08C", VA = "0x178B08C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x81896C", Offset = "0x81896C")]
		private static string _003CCreateRetrieveProductsQuestion_003Em__4(ProductDefinition pid)
		{
			return null;
		}
	}
}
