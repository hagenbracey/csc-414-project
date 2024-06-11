// Generated by gencs from sensor_msgs/FluidPressure.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;

namespace SIGVerse.RosBridge 
{
	namespace sensor_msgs 
	{
		[System.Serializable]
		public class FluidPressure : RosMessage
		{
			public std_msgs.Header header;
			public double fluid_pressure;
			public double variance;


			public FluidPressure()
			{
				this.header = new std_msgs.Header();
				this.fluid_pressure = 0.0;
				this.variance = 0.0;
			}

			public FluidPressure(std_msgs.Header header, double fluid_pressure, double variance)
			{
				this.header = header;
				this.fluid_pressure = fluid_pressure;
				this.variance = variance;
			}

			new public static string GetMessageType()
			{
				return "sensor_msgs/FluidPressure";
			}

			new public static string GetMD5Hash()
			{
				return "804dc5cea1c5306d6a2eb80b9833befe";
			}
		} // class FluidPressure
	} // namespace sensor_msgs
} // namespace SIGVerse.ROSBridge

