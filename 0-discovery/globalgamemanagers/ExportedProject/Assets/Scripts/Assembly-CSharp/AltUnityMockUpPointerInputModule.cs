using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x200005E")]
public class AltUnityMockUpPointerInputModule : StandaloneInputModule
{
	[Token(Token = "0x6000128")]
	[Address(RVA = "0xAE2174", Offset = "0xAE2174", VA = "0xAE2174")]
	public PointerEventData ExecuteTouchEvent(Touch touch, [Optional] PointerEventData previousData)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xAE2EC8", Offset = "0xAE2EC8", VA = "0xAE2EC8")]
	public AltUnityMockUpPointerInputModule()
	{
	}
}
