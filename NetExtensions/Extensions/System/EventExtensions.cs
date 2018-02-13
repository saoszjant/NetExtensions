using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class EventExtensions
    {
        public static void SafeInvoke<T>(this Action<T> @event, T arg, Action<Exception> errorHandler = null)
        {
            if (@event == null)
                return;

            var handlers = @event.GetInvocationList();
            if (handlers == null || handlers.Length == 0)
                return;

            for (int i = 0; i < handlers.Length; ++i)
            {
                try
                {
                    (handlers[i] as Action<T>).Invoke(arg);
                }
                catch (Exception e)
                {
                    try
                    {
                        errorHandler?.Invoke(e);
                    }
                    catch { }
                }
            }
        }

        public static void SafeInvoke<T1, T2>(this Action<T1, T2> @event, T1 arg1, T2 arg2, Action<Exception> errorHandler = null)
        {
            if (@event == null)
                return;

            var handlers = @event.GetInvocationList();
            if (handlers == null || handlers.Length == 0)
                return;

            for (int i = 0; i < handlers.Length; ++i)
            {
                try
                {
                    (handlers[i] as Action<T1, T2>).Invoke(arg1, arg2);
                }
                catch (Exception e)
                {
                    try
                    {
                        errorHandler?.Invoke(e);
                    }
                    catch { }
                }
            }
        }

        public static void SafeInvoke<T1, T2, T3>(this Action<T1, T2, T3> @event, T1 arg1, T2 arg2, T3 arg3, Action<Exception> errorHandler = null)
        {
            if (@event == null)
                return;

            var handlers = @event.GetInvocationList();
            if (handlers == null || handlers.Length == 0)
                return;

            for (int i = 0; i < handlers.Length; ++i)
            {
                try
                {
                    (handlers[i] as Action<T1, T2, T3>).Invoke(arg1, arg2, arg3);
                }
                catch (Exception e)
                {
                    try
                    {
                        errorHandler?.Invoke(e);
                    }
                    catch { }
                }
            }
        }
    }
}
