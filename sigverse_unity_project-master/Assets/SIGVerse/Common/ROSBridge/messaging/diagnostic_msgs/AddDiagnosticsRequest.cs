// Generated by gencs from diagnostic_msgs/AddDiagnostics.srv
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;


namespace SIGVerse.RosBridge 
{
	namespace diagnostic_msgs 
	{
		[System.Serializable]
		public class AddDiagnosticsRequest : ServiceArgs
		{
			public string load_namespace;


			public AddDiagnosticsRequest()
			{
				this.load_namespace = "";
			}

			public AddDiagnosticsRequest(string load_namespace)
			{
				this.load_namespace = load_namespace;
			}

			new public static string GetMessageType()
			{
				return "diagnostic_msgs/AddDiagnosticsRequest";
			}

			new public static string GetMD5Hash()
			{
				return "c26cf6e164288fbc6050d74f838bcdf0";
			}
		} // class AddDiagnosticsRequest
	} // namespace diagnostic_msgs
} // namespace SIGVerse.ROSBridge

