using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Uken.Framework.Casual.View
{
	[Token(Token = "0x2000578")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x820230", Offset = "0x820230")]
	public class CasualTabbedView<T> : CasualView where T : MonoBehaviour
	{
		[Token(Token = "0x2000857")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x821528", Offset = "0x821528")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x40023F0")]
			[FieldOffset(Offset = "0x0")]
			public CasualTabbedView<T> _003C_003E4__this;

			[Token(Token = "0x40023F1")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x40023F2")]
			[FieldOffset(Offset = "0x0")]
			public CasualView panelAfter;

			[Token(Token = "0x6003387")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6003388")]
			internal void _003CSwitchPanel_003Eb__0()
			{
			}
		}

		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, CasualView> m_tabbedPanels;

		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, T> m_tabs;

		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x0")]
		private string m_activePanelName;

		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x0")]
		protected bool hideActivePanelOnClose;

		[Token(Token = "0x17000759")]
		protected CasualView m_activePanel
		{
			[Token(Token = "0x60029E3")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029E4")]
		protected virtual void RemovePanel(string name)
		{
		}

		[Token(Token = "0x60029E5")]
		protected virtual void RegisterPanel(string name, CasualView panel, T tab, bool setAsActive = false)
		{
		}

		[Token(Token = "0x60029E6")]
		protected virtual void SwitchPanel(string name)
		{
		}

		[Token(Token = "0x60029E7")]
		private void OnSwitchTab(string before, string after)
		{
		}

		[Token(Token = "0x60029E8")]
		protected virtual void OnSwitchTab(T before, T after)
		{
		}

		[Token(Token = "0x60029E9")]
		protected override void OnInitialized()
		{
		}

		[Token(Token = "0x60029EA")]
		protected override void OnShowFinished(Action onShowComplete)
		{
		}

		[Token(Token = "0x60029EB")]
		protected override void OnHideStart(Action onHideComplete)
		{
		}

		[Token(Token = "0x60029EC")]
		public CasualTabbedView()
		{
		}
	}
}
