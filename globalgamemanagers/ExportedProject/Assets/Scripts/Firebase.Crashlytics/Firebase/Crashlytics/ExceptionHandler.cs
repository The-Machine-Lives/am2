using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Firebase.Crashlytics
{
	[Token(Token = "0x2000011")]
	internal class ExceptionHandler
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x10")]
		private bool isRegistered;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x17A31C8", Offset = "0x17A31C8", VA = "0x17A31C8")]
		public ExceptionHandler()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x17A327C", Offset = "0x17A327C", VA = "0x17A327C")]
		internal void Register()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x17A7C20", Offset = "0x17A7C20", VA = "0x17A7C20")]
		internal void HandleException(object sender, UnhandledExceptionEventArgs eArgs)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x17A7D1C", Offset = "0x17A7D1C", VA = "0x17A7D1C")]
		internal void HandleLog(string message, string stackTraceString, LogType type)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x17A7E18", Offset = "0x17A7E18", VA = "0x17A7E18")]
		private string[] getMessageParts(string message)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x17A818C", Offset = "0x17A818C", VA = "0x17A818C", Slot = "4")]
		internal virtual void LogException(LoggedException e)
		{
		}
	}
}
