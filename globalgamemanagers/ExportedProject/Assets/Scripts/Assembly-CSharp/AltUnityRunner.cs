using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200005F")]
public class AltUnityRunner : MonoBehaviour, AltIClientSocketHandlerDelegate
{
	[Token(Token = "0x2000600")]
	private enum FindOption
	{
		[Token(Token = "0x4001D34")]
		Name = 0,
		[Token(Token = "0x4001D35")]
		ContainName = 1,
		[Token(Token = "0x4001D36")]
		Component = 2
	}

	[Token(Token = "0x2000601")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8202F8", Offset = "0x8202F8")]
	private sealed class _003CHighLightSelectedObjectCorutine_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AltUnityRunner _003C_003E4__this;

		[Token(Token = "0x4001D3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject;

		[Token(Token = "0x4001D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color color;

		[Token(Token = "0x4001D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float width;

		[Token(Token = "0x4001D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector2 size;

		[Token(Token = "0x4001D3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AltClientSocketHandler handler;

		[Token(Token = "0x4001D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Renderer _003Crenderer_003E5__2;

		[Token(Token = "0x4001D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Shader> _003CoriginalShaders_003E5__3;

		[Token(Token = "0x4001D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _003CpanelHighlight_003E5__4;

		[Token(Token = "0x170007AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0xC1643C", Offset = "0xC1643C", VA = "0xC1643C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0xC164AC", Offset = "0xC164AC", VA = "0xC164AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C57")]
		[Address(RVA = "0xC153E0", Offset = "0xC153E0", VA = "0xC153E0")]
		[DebuggerHidden]
		public _003CHighLightSelectedObjectCorutine_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C58")]
		[Address(RVA = "0xC15E78", Offset = "0xC15E78", VA = "0xC15E78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C59")]
		[Address(RVA = "0xC15E7C", Offset = "0xC15E7C", VA = "0xC15E7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0xC16444", Offset = "0xC16444", VA = "0xC16444", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000602")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820308", Offset = "0x820308")]
	private sealed class _003CTakeTexturedScreenshot_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 size;

		[Token(Token = "0x4001D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AltClientSocketHandler handler;

		[Token(Token = "0x170007AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C60")]
			[Address(RVA = "0xC16748", Offset = "0xC16748", VA = "0xC16748", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0xC167B8", Offset = "0xC167B8", VA = "0xC167B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C5D")]
		[Address(RVA = "0xC154AC", Offset = "0xC154AC", VA = "0xC154AC")]
		[DebuggerHidden]
		public _003CTakeTexturedScreenshot_003Ed__60(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C5E")]
		[Address(RVA = "0xC16628", Offset = "0xC16628", VA = "0xC16628", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C5F")]
		[Address(RVA = "0xC1662C", Offset = "0xC1662C", VA = "0xC1662C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C61")]
		[Address(RVA = "0xC16750", Offset = "0xC16750", VA = "0xC16750", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000603")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x820318", Offset = "0x820318")]
	private sealed class _003CTakeScreenshot_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AltClientSocketHandler handler;

		[Token(Token = "0x170007AE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0xC165B0", Offset = "0xC165B0", VA = "0xC165B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007AF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0xC16620", Offset = "0xC16620", VA = "0xC16620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002C63")]
		[Address(RVA = "0xC1554C", Offset = "0xC1554C", VA = "0xC1554C")]
		[DebuggerHidden]
		public _003CTakeScreenshot_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C64")]
		[Address(RVA = "0xC164B4", Offset = "0xC164B4", VA = "0xC164B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C65")]
		[Address(RVA = "0xC164B8", Offset = "0xC164B8", VA = "0xC164B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002C67")]
		[Address(RVA = "0xC165B8", Offset = "0xC165B8", VA = "0xC165B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AltUnityRunner _altUnityRunner;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject AltUnityPopUp;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image AltUnityIcon;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text AltUnityPopUpText;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool AltUnityIconPressed;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 _position;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AltSocketServer _socketServer;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string logMessage;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool logEnabled;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string myPathFile;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static StreamWriter FileWriter;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string VERSION;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public readonly string errorNotFoundMessage;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public readonly string errorPropertyNotFoundMessage;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public readonly string errorMethodNotFoundMessage;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public readonly string errorComponentNotFoundMessage;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public readonly string errorCouldNotPerformOperationMessage;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public readonly string errorCouldNotParseJsonString;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public readonly string errorIncorrectNumberOfParameters;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public readonly string errorFailedToParseArguments;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public readonly string errorObjectWasNotFound;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public readonly string errorPropertyNotSet;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public readonly string errorNullRefferenceMessage;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public readonly string errorUnknownError;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public readonly string errorFormatException;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public readonly string errorCameraNotFound;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public JsonSerializerSettings _jsonSettings;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8217F8", Offset = "0x8217F8")]
	[SerializeField]
	private bool _showInputs;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private AltUnityInputsVisualiser _inputsVisualiser;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x821840", Offset = "0x821840")]
	public bool showPopUp;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private GameObject AltUnityPopUpCanvas;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool destroyHightlight;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public int SocketPortNumber;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool DebugBuildNeeded;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Shader outlineShader;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject panelHightlightPrefab;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public string requestSeparatorString;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public string requestEndingString;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static AltResponseQueue _responseQueue;

	[Token(Token = "0x17000008")]
	public bool ShowInputs
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xC0EC48", Offset = "0xC0EC48", VA = "0xC0EC48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xC0EC50", Offset = "0xC0EC50", VA = "0xC0EC50")]
		set
		{
		}
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xC0EC5C", Offset = "0xC0EC5C", VA = "0xC0EC5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xC0EDF4", Offset = "0xC0EDF4", VA = "0xC0EDF4")]
	private void Start()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xC0F324", Offset = "0xC0F324", VA = "0xC0F324")]
	private void Update()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xC0F52C", Offset = "0xC0F52C", VA = "0xC0F52C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xC0F5E8", Offset = "0xC0F5E8", VA = "0xC0F5E8")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xC0EF8C", Offset = "0xC0EF8C", VA = "0xC0EF8C")]
	public void StartSocketServer()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xC0F674", Offset = "0xC0F674", VA = "0xC0F674")]
	private Vector3 getObjectScreePosition(GameObject gameObject, Camera camera)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xC0FB84", Offset = "0xC0FB84", VA = "0xC0FB84")]
	public AltUnityObject GameObjectToAltUnityObject(GameObject altGameObject, [Optional] Camera camera)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xC10264", Offset = "0xC10264", VA = "0xC10264", Slot = "4")]
	public void ClientSocketHandlerDidReadMessage(AltClientSocketHandler handler, string message)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xC14A60", Offset = "0xC14A60", VA = "0xC14A60")]
	public void LogMessage(string logMessage)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xC14D74", Offset = "0xC14D74", VA = "0xC14D74")]
	public static GameObject[] GetDontDestroyOnLoadObjects()
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xC14F0C", Offset = "0xC14F0C", VA = "0xC14F0C")]
	public void ServerRestartPressed()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xC14F6C", Offset = "0xC14F6C", VA = "0xC14F6C")]
	public void IconPressed()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xC14FEC", Offset = "0xC14FEC", VA = "0xC14FEC")]
	public static GameObject GetGameObject(AltUnityObject altUnityObject)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xC15110", Offset = "0xC15110", VA = "0xC15110")]
	public static GameObject GetGameObject(int objectId)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xC15214", Offset = "0xC15214", VA = "0xC15214")]
	public Camera FoundCameraById(int id)
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xC152B4", Offset = "0xC152B4", VA = "0xC152B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8335BC", Offset = "0x8335BC")]
	public IEnumerator HighLightSelectedObjectCorutine(GameObject gameObject, Color color, float width, Vector2 size, AltClientSocketHandler handler)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xC1540C", Offset = "0xC1540C", VA = "0xC1540C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x833620", Offset = "0x833620")]
	public IEnumerator TakeTexturedScreenshot(Vector2 size, AltClientSocketHandler handler)
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xC154D8", Offset = "0xC154D8", VA = "0xC154D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x833684", Offset = "0x833684")]
	public IEnumerator TakeScreenshot(AltClientSocketHandler handler)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xC15578", Offset = "0xC15578", VA = "0xC15578")]
	public void ShowClick(Vector2 position)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xC15638", Offset = "0xC15638", VA = "0xC15638")]
	public int ShowInput(Vector2 position, int markId = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xC15710", Offset = "0xC15710", VA = "0xC15710")]
	public static void CopyTo(Stream src, Stream dest)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xC157F0", Offset = "0xC157F0", VA = "0xC157F0")]
	public static byte[] CompressScreenshot(byte[] screenshotSerialized)
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xC15BE4", Offset = "0xC15BE4", VA = "0xC15BE4")]
	private static bool ByteArrayCompare(byte[] a1, byte[] a2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xC15CB0", Offset = "0xC15CB0", VA = "0xC15CB0")]
	public AltUnityRunner()
	{
	}
}
