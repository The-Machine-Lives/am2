using System.Collections.Generic;
using Il2CppDummyDll;
using Uken.Framework.Casual.View;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20001CD")]
public class FeedbackPopup : PopupView
{
	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x90")]
	public InputField nameInputField;

	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x98")]
	public InputField emailInputField;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0xA0")]
	public InputField feedbackInputField;

	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0xA8")]
	public Dropdown categoryDropDown;

	[Token(Token = "0x4000A98")]
	private const string EmailRegex = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,8}$";

	[Token(Token = "0x4000A99")]
	private const string FeedbackUrl = "/questions";

	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0xB0")]
	public List<int> feedbackCategoryIDs;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0xB8")]
	public List<string> feedbackCategoryNames;

	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0xC0")]
	public bool sendingFeedback;

	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x0")]
	public static string FeedbackPopupPrefab;

	[Token(Token = "0x6000C4F")]
	[Address(RVA = "0x9C9EE0", Offset = "0x9C9EE0", VA = "0x9C9EE0")]
	public static FeedbackPopup Create(CasualViewController controller, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6000C50")]
	[Address(RVA = "0x9C9FF0", Offset = "0x9C9FF0", VA = "0x9C9FF0")]
	public void Setup()
	{
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0x9CA328", Offset = "0x9CA328", VA = "0x9CA328", Slot = "13")]
	public virtual void OnCancelButtonPressed()
	{
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x9CA330", Offset = "0x9CA330", VA = "0x9CA330")]
	public void SendFeedback(string name, string email, string feedback, string category)
	{
	}

	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x9CA7B4", Offset = "0x9CA7B4", VA = "0x9CA7B4")]
	public void OnSubmitClicked()
	{
	}

	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x9CA708", Offset = "0x9CA708", VA = "0x9CA708")]
	private void ShowPrompt(string prompt)
	{
	}

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x9C9FF4", Offset = "0x9C9FF4", VA = "0x9C9FF4")]
	private void initializeCategoryComboBox()
	{
	}

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x9CA950", Offset = "0x9CA950", VA = "0x9CA950")]
	public FeedbackPopup()
	{
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x9CAA44", Offset = "0x9CAA44", VA = "0x9CAA44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x834ADC", Offset = "0x834ADC")]
	private void _003CSendFeedback_003Eb__13_0(bool error, string responseText)
	{
	}
}
