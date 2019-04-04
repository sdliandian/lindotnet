﻿using System;
using System.Runtime.InteropServices;

namespace lindotnet.Classes.Wrapper.Implementation
{
	internal static class LinphoneDelegates
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LinphoneCoreRegistrationStateChanged(IntPtr lc, IntPtr cfg, LinphoneRegistrationState cstate, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LinphoneCoreCallStateChanged(IntPtr lc, IntPtr call, LinphoneCallState cstate, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LogEventCb(string domain, OrtpLogLevel lev, string fmt, IntPtr args);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void LinphoneCoreCbsMessageReceived(IntPtr lc, IntPtr room, IntPtr message);
	}
}
