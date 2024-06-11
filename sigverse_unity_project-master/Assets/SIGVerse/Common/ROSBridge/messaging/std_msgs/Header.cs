// Generated by gencs from std_msgs/Header.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;


namespace SIGVerse.RosBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class Header : RosMessage
		{
			private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

			private static TimeSpan timeGap = TimeSpan.Zero;
			private static object lockTimeGap = new object();

			public System.UInt32 seq;
			public SIGVerse.RosBridge.msg_helpers.Time stamp;
			public string frame_id;


			public Header()
			{
				this.seq = 0;
				this.stamp = new SIGVerse.RosBridge.msg_helpers.Time();
				this.frame_id = "";
			}

			public Header(System.UInt32 seq, SIGVerse.RosBridge.msg_helpers.Time stamp, string frame_id)
			{
				this.seq = seq;
				this.stamp = stamp;
				this.frame_id = frame_id;
			}

			// Added by hand
			public void Update()
			{
				this.seq++;

				if(SIGVerse.Common.ConfigManager.Instance.configInfo.setUpRosTimestamp)
				{
					TimeSpan epochTime = (DateTime.Now.ToUniversalTime() - UnixEpoch);

					lock (lockTimeGap)
					{
						epochTime = epochTime.Subtract(timeGap);
					}

					this.stamp.secs = (int)epochTime.TotalSeconds;
					this.stamp.nsecs = epochTime.Milliseconds * 1000 * 1000;
				}
			}

			// Added by hand
			public static void SetTimeGap(int secs, int millisecs)
			{
				lock (lockTimeGap)
				{
					timeGap = new TimeSpan(0, 0, 0, secs, millisecs);
				}
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Header";
			}

			new public static string GetMD5Hash()
			{
				return "2176decaecbce78abc3b96ef049fabed";
			}
		} // class Header
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge

