using Il2CppDummyDll;
using Uken.Framework.Casual;
using UnityEngine;

[Token(Token = "0x200008A")]
public class QuestSceneView : ActionSceneView
{
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private AM2Text m_questText;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0xB8")]
	private ActionController m_actionController;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0xC0")]
	private QuestSceneController m_sceneController;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x9E9824", Offset = "0x9E9824", VA = "0x9E9824")]
	public void Initialize(QuestSceneController sceneController, ZoneView zoneView)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x9E9A14", Offset = "0x9E9A14", VA = "0x9E9A14")]
	public QuestSceneView()
	{
	}
}
