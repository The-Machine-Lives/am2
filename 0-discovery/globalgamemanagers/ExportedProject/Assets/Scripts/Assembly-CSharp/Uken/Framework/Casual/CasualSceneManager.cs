using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Uken.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Uken.Framework.Casual
{
	[Token(Token = "0x20004DE")]
	public class CasualSceneManager : UkenController
	{
		[Token(Token = "0x4001707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x82F0EC", Offset = "0x82F0EC")]
		private CasualSceneController _003Cm_ActiveSceneController_003Ek__BackingField;

		[Token(Token = "0x4001708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AsyncOperation m_PendingSceneOperation;

		[Token(Token = "0x4001709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_PendingSceneName;

		[Token(Token = "0x400170A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GameObject> m_PendingRootObjects;

		[Token(Token = "0x400170B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Scene m_ActiveScene;

		[Token(Token = "0x400170C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Sprite m_previousBackgroundSprite;

		[Token(Token = "0x400170D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CasualGame m_parentGame;

		[Token(Token = "0x400170E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, object> m_sceneParameters;

		[Token(Token = "0x1700063D")]
		public CasualSceneController m_ActiveSceneController
		{
			[Token(Token = "0x6002574")]
			[Address(RVA = "0xA56480", Offset = "0xA56480", VA = "0xA56480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E7C", Offset = "0x839E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002575")]
			[Address(RVA = "0xA564FC", Offset = "0xA564FC", VA = "0xA564FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839E8C", Offset = "0x839E8C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6002572")]
		[Address(RVA = "0xA56388", Offset = "0xA56388", VA = "0xA56388")]
		public static Canvas GetCanvas()
		{
			return null;
		}

		[Token(Token = "0x6002573")]
		[Address(RVA = "0xA56488", Offset = "0xA56488", VA = "0xA56488")]
		public static RectTransform GetCanvasTransform()
		{
			return null;
		}

		[Token(Token = "0x6002576")]
		[Address(RVA = "0xA56504", Offset = "0xA56504", VA = "0xA56504")]
		public void SetParentGame(CasualGame game)
		{
		}

		[Token(Token = "0x6002577")]
		[Address(RVA = "0xA5622C", Offset = "0xA5622C", VA = "0xA5622C")]
		public bool LoadScene(string sceneName, [Optional] Sprite previousBackground, [Optional] Dictionary<string, object> parameters)
		{
			return default(bool);
		}

		[Token(Token = "0x6002578")]
		[Address(RVA = "0xA5650C", Offset = "0xA5650C", VA = "0xA5650C")]
		public float GetSceneLoadingProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6002579")]
		[Address(RVA = "0xA56524", Offset = "0xA56524", VA = "0xA56524")]
		public bool IsSceneLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x600257A")]
		[Address(RVA = "0xA56534", Offset = "0xA56534", VA = "0xA56534")]
		public bool IsSceneLoadingComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x600257B")]
		[Address(RVA = "0xA5654C", Offset = "0xA5654C", VA = "0xA5654C", Slot = "10")]
		protected virtual bool OnSceneLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x600257C")]
		[Address(RVA = "0xA5692C", Offset = "0xA5692C", VA = "0xA5692C")]
		private CasualSceneController GetSceneController(Scene loadedScene)
		{
			return null;
		}

		[Token(Token = "0x600257D")]
		[Address(RVA = "0xA56AB0", Offset = "0xA56AB0", VA = "0xA56AB0")]
		private void CleanupSceneLoading()
		{
		}

		[Token(Token = "0x600257E")]
		[Address(RVA = "0xA56B24", Offset = "0xA56B24", VA = "0xA56B24", Slot = "7")]
		public override void Update(float deltaTime)
		{
		}

		[Token(Token = "0x600257F")]
		[Address(RVA = "0xA56B7C", Offset = "0xA56B7C", VA = "0xA56B7C", Slot = "8")]
		public override void Cleanup()
		{
		}

		[Token(Token = "0x6002580")]
		[Address(RVA = "0xA56B84", Offset = "0xA56B84", VA = "0xA56B84")]
		public CasualSceneManager()
		{
		}
	}
}
