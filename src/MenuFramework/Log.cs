using System;
using System.Diagnostics;

namespace HelperClasses
{
    public static class Log
    {
        public static void Verbose(string message)
        {
            try
            {
                CitizenFX.Core.Debug.WriteLine(message);
                Trace.WriteLine(message);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Debug(string message)
        {
            try
            {
                message = $"DEBUG > {message}";
                CitizenFX.Core.Debug.WriteLine(message);
                Trace.WriteLine(message);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Info(string message)
        {
            try
            {
                message = $"INFO > {message}";
                CitizenFX.Core.Debug.WriteLine(message);
                Trace.WriteLine(message);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Warn(string message)
        {
            try
            {
                message = $"WARN > {message}";
                CitizenFX.Core.Debug.WriteLine(message);
                Trace.WriteLine(message);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Error(string message)
        {
            try
            {
                message = $"ERROR > {message}";
                CitizenFX.Core.Debug.WriteLine(message);
                Trace.WriteLine(message);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}