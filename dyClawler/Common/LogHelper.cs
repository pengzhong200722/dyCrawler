﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dyClawler.Common
{
    public static class LogHelper
    {
        //private static Logger Logger = LogManager.GetCurrentClassLogger();


        public static void Info(string message)
        {
           // Logger.Info(message);
        }

        public static void Error(string message, Exception ex, object oj = null)
        {
          //  Logger.Error(message + ex.ToString(), ex, oj);
        }

        public static void Error(string message, Exception ex, string info)
        {
          //  Logger.Error(message + ex.ToString() + "Info:" + info, ex, info);
        }
    }
}