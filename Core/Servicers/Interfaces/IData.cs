﻿using Core.Models;
using Core.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Servicers.Interfaces
{
    public interface IData
    {

        /// <summary>
        /// 设置进程数据
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="processDescription"></param>
        /// <param name="file"></param>
        /// <param name="seconds"></param>
        void Set(string processName, string processDescription, string file, int seconds, DateTime? time = null);

        /// <summary>
        /// 获取今天的数据
        /// </summary>
        /// <returns></returns>
        List<DailyLogModel> GetTodaylogList();
        /// <summary>
        /// 查询指定范围数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        IEnumerable<DailyLogModel> GetDateRangelogList(DateTime start, DateTime end, int take = -1);

        /// <summary>
        /// 获取本周的数据
        /// </summary>
        /// <returns></returns>
        IEnumerable<DailyLogModel> GetThisWeeklogList();
        /// <summary>
        /// 获取上周的数据
        /// </summary>
        /// <returns></returns>
        IEnumerable<DailyLogModel> GetLastWeeklogList();
        /// <summary>
        /// 设置进程数据（仅通过进程名可能会出现重复的问题
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="seconds"></param>
        void Set(string processName, int seconds, DateTime? time = null);

        /// <summary>
        /// 获取指定进程某个月的数据
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        List<DailyLogModel> GetProcessMonthLogList(int appID, DateTime month);


        /// <summary>
        /// 清空指定进程某月的数据
        /// </summary>
        /// <param name="processName"></param>
        void Clear(int appID, DateTime month);

        /// <summary>
        /// 获取指定进程某天的数据
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        DailyLogModel GetProcess(int appID, DateTime day);

        /// <summary>
        /// 获取指定日期所有分类时段统计数据
        /// </summary>
        /// <returns></returns>
        List<ColumnDataModel> GetCategoryHoursData(DateTime date);
        /// <summary>
        /// 获取指定日期范围所有分类按天统计数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        List<ColumnDataModel> GetCategoryRangeData(DateTime start, DateTime end);
        /// <summary>
        /// 获取指定年份所有分类按月份统计数据
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        List<ColumnDataModel> GetCategoryYearData(DateTime date);

        List<ColumnDataModel> GetAppDayData(int appID, DateTime date);
        List<ColumnDataModel> GetAppRangeData(int appID, DateTime start, DateTime end);
        List<ColumnDataModel> GetAppYearData(int appID, DateTime date);
        /// <summary>
        /// 清空指定时间范围数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        void ClearRange(DateTime start, DateTime end);

    }
}
