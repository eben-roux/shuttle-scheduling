﻿using Shuttle.Core.Data;

namespace Shuttle.Esb.Scheduling
{
	public interface IScheduleQueryFactory
	{
		IQuery All();
		IQuery HasScheduleStructures();
		IQuery Remove(string name);
		IQuery Contains(string name);
		IQuery Register(Schedule schedule);
		IQuery SaveNextNotification(Schedule schedule);
	}
}