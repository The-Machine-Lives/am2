using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Assets.AltUnityTester.AltUnityDriver.UnityStruct;
using Il2CppDummyDll;

[Token(Token = "0x2000010")]
public class AltUnityDriver
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TcpClient Socket;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SocketSettings socketSettings;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string VERSION;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string requestSeparatorString;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string requestEndingString;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xAD7B88", Offset = "0xAD7B88", VA = "0xAD7B88")]
	public AltUnityDriver(string tcp_ip = "127.0.0.1", int tcp_port = 13000, string requestSeparator = ";", string requestEnding = "&", bool logFlag = false)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xAD81A8", Offset = "0xAD81A8", VA = "0xAD81A8")]
	public string CheckServerVersion()
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xAD822C", Offset = "0xAD822C", VA = "0xAD822C")]
	private void EnableLogging()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xAD82B0", Offset = "0xAD82B0", VA = "0xAD82B0")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xAD85B4", Offset = "0xAD85B4", VA = "0xAD85B4")]
	public void LoadScene(string scene)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xAD88E4", Offset = "0xAD88E4", VA = "0xAD88E4")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8332FC", Offset = "0x8332FC")]
	public List<AltUnityObject> FindObjects(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xAD8CE8", Offset = "0xAD8CE8", VA = "0xAD8CE8")]
	public List<AltUnityObject> FindObjects(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xAD8DB8", Offset = "0xAD8DB8", VA = "0xAD8DB8")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83330C", Offset = "0x83330C")]
	public List<AltUnityObject> FindObjectsWhichContain(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xAD91BC", Offset = "0xAD91BC", VA = "0xAD91BC")]
	public List<AltUnityObject> FindObjectsWhichContain(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xAD928C", Offset = "0xAD928C", VA = "0xAD928C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83331C", Offset = "0x83331C")]
	public AltUnityObject FindObject(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xAD974C", Offset = "0xAD974C", VA = "0xAD974C")]
	public AltUnityObject FindObject(By by, string value, By cameraBy = By.NAME, string cameraValue = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xAD981C", Offset = "0xAD981C", VA = "0xAD981C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83332C", Offset = "0x83332C")]
	public AltUnityObject FindObjectWhichContains(By by, string value, string cameraName, bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xAD9C20", Offset = "0xAD9C20", VA = "0xAD9C20")]
	public AltUnityObject FindObjectWhichContains(By by, string value, By cameraBy = By.NAME, string cameraValue = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xAD9CF0", Offset = "0xAD9CF0", VA = "0xAD9CF0")]
	public void SetTimeScale(float timeScale)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xAD9D90", Offset = "0xAD9D90", VA = "0xAD9D90")]
	public float GetTimeScale()
	{
		return default(float);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xADA068", Offset = "0xADA068", VA = "0xADA068")]
	public string CallStaticMethods(string typeName, string methodName, string parameters, string typeOfParameters = "", string assemblyName = "")
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xADA120", Offset = "0xADA120", VA = "0xADA120")]
	public void DeletePlayerPref()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xADA1A4", Offset = "0xADA1A4", VA = "0xADA1A4")]
	public void DeleteKeyPlayerPref(string keyName)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xADA238", Offset = "0xADA238", VA = "0xADA238")]
	public void SetKeyPlayerPref(string keyName, int valueName)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xADA2E0", Offset = "0xADA2E0", VA = "0xADA2E0")]
	public void SetKeyPlayerPref(string keyName, float valueName)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xADA390", Offset = "0xADA390", VA = "0xADA390")]
	public void SetKeyPlayerPref(string keyName, string valueName)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xADA438", Offset = "0xADA438", VA = "0xADA438")]
	public int GetIntKeyPlayerPref(string keyName)
	{
		return default(int);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xADA7EC", Offset = "0xADA7EC", VA = "0xADA7EC")]
	public float GetFloatKeyPlayerPref(string keyName)
	{
		return default(float);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xADABA0", Offset = "0xADABA0", VA = "0xADABA0")]
	public string GetStringKeyPlayerPref(string keyName)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xADAF48", Offset = "0xADAF48", VA = "0xADAF48")]
	public string GetCurrentScene()
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xADB228", Offset = "0xADB228", VA = "0xADB228")]
	public void Swipe(AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xADB2F8", Offset = "0xADB2F8", VA = "0xADB2F8")]
	public void SwipeAndWait(AltUnityVector2 start, AltUnityVector2 end, float duration)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xADB3C8", Offset = "0xADB3C8", VA = "0xADB3C8")]
	public void MultipointSwipe(AltUnityVector2[] positions, float duration)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xADB478", Offset = "0xADB478", VA = "0xADB478")]
	public void MultipointSwipeAndWait(AltUnityVector2[] positions, float duration)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xADB528", Offset = "0xADB528", VA = "0xADB528")]
	public void HoldButton(AltUnityVector2 position, float duration)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xADB538", Offset = "0xADB538", VA = "0xADB538")]
	public void HoldButtonAndWait(AltUnityVector2 position, float duration)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xADB548", Offset = "0xADB548", VA = "0xADB548")]
	public void PressKey(AltUnityKeyCode keyCode, float power = 1f, float duration = 1f)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xADB600", Offset = "0xADB600", VA = "0xADB600")]
	public void PressKeyAndWait(AltUnityKeyCode keyCode, float power = 1f, float duration = 1f)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xADB6B8", Offset = "0xADB6B8", VA = "0xADB6B8")]
	public void MoveMouse(AltUnityVector2 location, float duration = 0f)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xADBA5C", Offset = "0xADBA5C", VA = "0xADBA5C")]
	public void MoveMouseAndWait(AltUnityVector2 location, float duration = 0f)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xADBE0C", Offset = "0xADBE0C", VA = "0xADBE0C")]
	public void ScrollMouse(float speed, float duration = 0f)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xADBEB4", Offset = "0xADBEB4", VA = "0xADBEB4")]
	public void ScrollMouseAndWait(float speed, float duration = 0f)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xADBF5C", Offset = "0xADBF5C", VA = "0xADBF5C")]
	public AltUnityObject TapScreen(float x, float y)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xADC004", Offset = "0xADC004", VA = "0xADC004")]
	public void TapCustom(float x, float y, int count, float interval = 0.1f)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xADC0CC", Offset = "0xADC0CC", VA = "0xADC0CC")]
	public void Tilt(AltUnityVector3 acceleration, float duration = 0f)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xADC18C", Offset = "0xADC18C", VA = "0xADC18C")]
	public void TiltAndWait(AltUnityVector3 acceleration, float duration = 0f)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xADC24C", Offset = "0xADC24C", VA = "0xADC24C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83333C", Offset = "0x83333C")]
	public AltUnityObject FindElementWhereNameContains(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xADC560", Offset = "0xADC560", VA = "0xADC560")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833374", Offset = "0x833374")]
	public List<AltUnityObject> GetAllElements(string cameraName, bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xADC9C0", Offset = "0xADC9C0", VA = "0xADC9C0")]
	public List<AltUnityObject> GetAllElements(By cameraBy = By.NAME, string cameraPath = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xADCA78", Offset = "0xADCA78", VA = "0xADCA78")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833384", Offset = "0x833384")]
	public AltUnityObject FindElement(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xADCD8C", Offset = "0xADCD8C", VA = "0xADCD8C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8333BC", Offset = "0x8333BC")]
	public List<AltUnityObject> FindElements(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xADD0A0", Offset = "0xADD0A0", VA = "0xADD0A0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8333F4", Offset = "0x8333F4")]
	public List<AltUnityObject> FindElementsWhereNameContains(string name, string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xADD3B4", Offset = "0xADD3B4", VA = "0xADD3B4")]
	public string WaitForCurrentSceneToBe(string sceneName, double timeout = 10.0, double interval = 1.0)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xADD46C", Offset = "0xADD46C", VA = "0xADD46C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83342C", Offset = "0x83342C")]
	public AltUnityObject WaitForElementWhereNameContains(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xADD53C", Offset = "0xADD53C", VA = "0xADD53C")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833464", Offset = "0x833464")]
	public AltUnityObject WaitForObject(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xADD618", Offset = "0xADD618", VA = "0xADD618")]
	public AltUnityObject WaitForObject(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xADD700", Offset = "0xADD700", VA = "0xADD700")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833474", Offset = "0x833474")]
	public void WaitForObjectNotBePresent(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xADD7DC", Offset = "0xADD7DC", VA = "0xADD7DC")]
	public void WaitForObjectNotBePresent(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xADD8C4", Offset = "0xADD8C4", VA = "0xADD8C4")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833484", Offset = "0x833484")]
	public AltUnityObject WaitForObjectWhichContains(By by, string value, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xADD9A0", Offset = "0xADD9A0", VA = "0xADD9A0")]
	public AltUnityObject WaitForObjectWhichContains(By by, string value, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xADDA88", Offset = "0xADDA88", VA = "0xADDA88")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833494", Offset = "0x833494")]
	public void WaitForElementToNotBePresent(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xADDB58", Offset = "0xADDB58", VA = "0xADDB58")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x8334CC", Offset = "0x8334CC")]
	public AltUnityObject WaitForElement(string name, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xADDC28", Offset = "0xADDC28", VA = "0xADDC28")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833504", Offset = "0x833504")]
	public AltUnityObject WaitForElementWithText(string name, string text, string cameraName = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xADDD00", Offset = "0xADDD00", VA = "0xADDD00")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83353C", Offset = "0x83353C")]
	public AltUnityObject WaitForObjectWithText(By by, string value, string text, string cameraName, bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xADDDEC", Offset = "0xADDDEC", VA = "0xADDDEC")]
	public AltUnityObject WaitForObjectWithText(By by, string value, string text, By cameraBy = By.NAME, string cameraPath = "", bool enabled = true, double timeout = 20.0, double interval = 0.5)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xADDEDC", Offset = "0xADDEDC", VA = "0xADDEDC")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x83354C", Offset = "0x83354C")]
	public AltUnityObject FindElementByComponent(string componentName, string assemblyName = "", string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xADE254", Offset = "0xADE254", VA = "0xADE254")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x833584", Offset = "0x833584")]
	public List<AltUnityObject> FindElementsByComponent(string componentName, string assemblyName = "", string cameraName = "", bool enabled = true)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xADE5CC", Offset = "0xADE5CC", VA = "0xADE5CC")]
	public List<string> GetAllScenes()
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xADE89C", Offset = "0xADE89C", VA = "0xADE89C")]
	public List<AltUnityObject> GetAllCameras()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xADEA6C", Offset = "0xADEA6C", VA = "0xADEA6C")]
	public AltUnityTextureInformation GetScreenshot([Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xADEBC4", Offset = "0xADEBC4", VA = "0xADEBC4")]
	public AltUnityTextureInformation GetScreenshot(int id, AltUnityColor color, float width, [Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xADED54", Offset = "0xADED54", VA = "0xADED54")]
	public AltUnityTextureInformation GetScreenshot(AltUnityVector2 coordinates, AltUnityColor color, float width, out AltUnityObject selectedObject, [Optional] AltUnityVector2 size)
	{
		return default(AltUnityTextureInformation);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xADEF14", Offset = "0xADEF14", VA = "0xADEF14")]
	public void GetPNGScreenshot(string path)
	{
	}
}
