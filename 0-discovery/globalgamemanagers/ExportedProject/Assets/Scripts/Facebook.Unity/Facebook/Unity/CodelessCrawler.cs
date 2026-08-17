using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Facebook.Unity
{
	[Token(Token = "0x2000060")]
	public class CodelessCrawler : MonoBehaviour
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x816110", Offset = "0x816110")]
		private sealed class _003CGenSnapshot_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000068")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0xCD0CA4", Offset = "0xCD0CA4", VA = "0xCD0CA4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000069")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0xCD0D14", Offset = "0xCD0D14", VA = "0xCD0D14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xCCF3C0", Offset = "0xCCF3C0", VA = "0xCCF3C0")]
			[DebuggerHidden]
			public _003CGenSnapshot_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0xCD0A30", Offset = "0xCD0A30", VA = "0xCD0A30", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0xCD0A34", Offset = "0xCD0A34", VA = "0xCD0A34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xCD0CAC", Offset = "0xCD0CAC", VA = "0xCD0CAC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x0")]
		private static bool isGeneratingSnapshot;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x8")]
		private static Camera mainCamera;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCCF154", Offset = "0xCCF154", VA = "0xCCF154")]
		public void Awake()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCCF1D0", Offset = "0xCCF1D0", VA = "0xCCF1D0")]
		public void CaptureViewHierarchy(string message)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCCF360", Offset = "0xCCF360", VA = "0xCCF360")]
		private IEnumerator GenSnapshot()
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCCF3EC", Offset = "0xCCF3EC", VA = "0xCCF3EC")]
		private static void SendAndroid(string json)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xCCF5B0", Offset = "0xCCF5B0", VA = "0xCCF5B0")]
		private static void SendIos(string json)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xCCF5B4", Offset = "0xCCF5B4", VA = "0xCCF5B4")]
		private static string GenBase64Screenshot()
		{
			return null;
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xCCF72C", Offset = "0xCCF72C", VA = "0xCCF72C")]
		private static string GenViewJson()
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xCCFC58", Offset = "0xCCFC58", VA = "0xCCFC58")]
		private static void GenChild(GameObject curObj, StringBuilder builder)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xCD09C8", Offset = "0xCD09C8", VA = "0xCD09C8")]
		private void onActiveSceneChanged(Scene arg0, Scene arg1)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xCCF2E8", Offset = "0xCCF2E8", VA = "0xCCF2E8")]
		private static void updateMainCamera()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xCD0794", Offset = "0xCD0794", VA = "0xCD0794")]
		private static Vector2 getScreenCoordinate(Vector3 position, RenderMode renderMode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xCD08E8", Offset = "0xCD08E8", VA = "0xCD08E8")]
		private static string getClasstypeBitmaskButton()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCD0954", Offset = "0xCD0954", VA = "0xCD0954")]
		private static string getVisibility(GameObject gameObj)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCD0A24", Offset = "0xCD0A24", VA = "0xCD0A24")]
		public CodelessCrawler()
		{
		}
	}
}
