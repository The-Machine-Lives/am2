using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;
using Newtonsoft.Json;

[Token(Token = "0x2000009")]
public class AltUnityObject
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int id;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int x;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int y;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int z;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int mobileY;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string type;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool enabled;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float worldX;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float worldY;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float worldZ;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int idCamera;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int parentId;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int transformId;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[JsonIgnore]
	public SocketSettings socketSettings;

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xAE2ED0", Offset = "0xAE2ED0", VA = "0xAE2ED0")]
	public AltUnityObject(string name, int id = 0, int x = 0, int y = 0, int z = 0, int mobileY = 0, string type = "", bool enabled = true, float worldX = 0f, float worldY = 0f, float worldZ = 0f, int idCamera = 0, int parentId = 0, int transformId = 0)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xAE2F9C", Offset = "0xAE2F9C", VA = "0xAE2F9C")]
	public AltUnityVector2 getScreenPosition()
	{
		return default(AltUnityVector2);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xAE2FD4", Offset = "0xAE2FD4", VA = "0xAE2FD4")]
	public AltUnityVector3 getWorldPosition()
	{
		return default(AltUnityVector3);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xAE3010", Offset = "0xAE3010", VA = "0xAE3010")]
	public string GetComponentProperty(string componentName, string propertyName, [Optional] string assemblyName)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xAE30C0", Offset = "0xAE30C0", VA = "0xAE30C0")]
	public string SetComponentProperty(string componentName, string propertyName, string value, [Optional] string assemblyName)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xAE3184", Offset = "0xAE3184", VA = "0xAE3184")]
	public string CallComponentMethod(string componentName, string methodName, string parameters, string typeOfParameters = "", [Optional] string assemblyName)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xAE324C", Offset = "0xAE324C", VA = "0xAE324C")]
	public string GetText()
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xAE32D4", Offset = "0xAE32D4", VA = "0xAE32D4")]
	public AltUnityObject SetText(string text)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xAE3378", Offset = "0xAE3378", VA = "0xAE3378")]
	public AltUnityObject ClickEvent()
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xAE3408", Offset = "0xAE3408", VA = "0xAE3408")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833284", Offset = "0x833284")]
	public AltUnityObject DragObject(AltUnityVector2 position)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xAE34AC", Offset = "0xAE34AC", VA = "0xAE34AC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8332C0", Offset = "0x8332C0")]
	public AltUnityObject DropObject(AltUnityVector2 position)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xAE3550", Offset = "0xAE3550", VA = "0xAE3550")]
	public AltUnityObject PointerUpFromObject()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xAE35E4", Offset = "0xAE35E4", VA = "0xAE35E4")]
	public AltUnityObject PointerDownFromObject()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xAE3678", Offset = "0xAE3678", VA = "0xAE3678")]
	public AltUnityObject PointerEnterObject()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xAE370C", Offset = "0xAE370C", VA = "0xAE370C")]
	public AltUnityObject PointerExitObject()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xAE37A0", Offset = "0xAE37A0", VA = "0xAE37A0")]
	public AltUnityObject Tap()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xAE3838", Offset = "0xAE3838", VA = "0xAE3838")]
	public AltUnityObject DoubleTap()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xAE38D0", Offset = "0xAE38D0", VA = "0xAE38D0")]
	public List<AltUnityComponent> GetAllComponents()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xAE3958", Offset = "0xAE3958", VA = "0xAE3958")]
	public List<AltUnityProperty> GetAllProperties(AltUnityComponent altUnityComponent)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xAE39F8", Offset = "0xAE39F8", VA = "0xAE39F8")]
	public List<string> GetAllMethods(AltUnityComponent altUnityComponent, AltUnityMethodSelection methodSelection = AltUnityMethodSelection.ALLMETHODS)
	{
		return null;
	}
}
