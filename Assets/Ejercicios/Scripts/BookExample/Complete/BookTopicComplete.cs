using System;

[Serializable]
[Flags]
public enum BookTopicComplete
{
	UNKNOWN = 0,	// 0
	KNIGH = 1,		// 1
	NINJAS = 2,		// 1<<1
	SPIRITUAL = 4,	// 1<<2
	BUSSINESS = 8,	// 1<<3
	SPY = 16,		// 1<<4
	DRAMA = 32,		// 1<<5
	ROMANCE = 64,	// 1<<6
}