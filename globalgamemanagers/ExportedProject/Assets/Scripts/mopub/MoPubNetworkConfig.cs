using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000D")]
public abstract class MoPubNetworkConfig : MonoBehaviour
{
	[Token(Token = "0x200000E")]
	public abstract class Wrapper
	{
		[Token(Token = "0x1700000F")]
		public abstract object value
		{
			[Token(Token = "0x600003F")]
			get;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1765234", Offset = "0x1765234", VA = "0x1765234", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x200000F")]
	public abstract class SettingAttribute : PropertyAttribute
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public string name;
	}

	[Token(Token = "0x2000010")]
	public abstract class Config : SettingAttribute
	{
		[Token(Token = "0x2000011")]
		public class Optional : Config
		{
		}
	}

	[Token(Token = "0x2000012")]
	public abstract class Mediation : SettingAttribute
	{
		[Token(Token = "0x2000013")]
		public class Optional : Mediation
		{
		}
	}

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	protected List<string> enabledOptions;

	[Token(Token = "0x1700000C")]
	public abstract string AdapterConfigurationClassName
	{
		[Token(Token = "0x600003A")]
		get;
	}

	[Token(Token = "0x1700000D")]
	public virtual string MediationSettingsClassName
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1764C9C", Offset = "0x1764C9C", VA = "0x1764C9C", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual MoPubBase.MediatedNetwork NetworkOptions
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1764CA4", Offset = "0x1764CA4", VA = "0x1764CA4", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1764C98", Offset = "0x1764C98", VA = "0x1764C98")]
	private void Start()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1764DF4", Offset = "0x1764DF4", VA = "0x1764DF4")]
	protected void FillInMarkedFields(MoPubBase.MediatedNetwork options)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x176522C", Offset = "0x176522C", VA = "0x176522C")]
	protected MoPubNetworkConfig()
	{
	}
}
