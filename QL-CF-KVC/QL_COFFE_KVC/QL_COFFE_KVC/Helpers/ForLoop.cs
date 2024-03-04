using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QL_COFFE_KVC
{
    public static class ForLoop
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (T item in items)
                action?.Invoke(item);
        }

        public static void ForIndex<T>(this IEnumerable<T> items, Action<T, int> action)
        {
            int index = 0;
            foreach (T item in items)
            {
                action?.Invoke(item, index);
                index++;
            }
        }

        //--
        public static async Task ForEach<T>(this IEnumerable<T> items, Func<T, Task> invoke)
        {
            foreach (T item in items) await invoke?.Invoke(item);
        }

        public static async Task ForIndex<T>(this IEnumerable<T> items, Func<T, int, Task> invoke)
        {
            int index = 0;
            foreach (T item in items)
            {
                await invoke?.Invoke(item, index);
                index++;
            }
        }

        //--

        public static async void ForEachAsync<T>(this IEnumerable items, Action<T> invoke)
        {
            var task = new List<Task>();
            foreach (T item in items) task.Add(Task.Run(() => invoke?.Invoke(item)));
            await Task.WhenAll(task).ConfigureAwait(true);
        }

        public static async void ForIndexAsync<T>(this IEnumerable items, Action<T, int> invoke)
        {
            int index = 0;
            var task = new List<Task>();
            foreach (T item in items)
            {
                task.Add(Task.Run(() => invoke?.Invoke(item, index)));
                index++;
            }
            await Task.WhenAll(task).ConfigureAwait(true);
        }

        //--
        public static async Task ForEachAsync<T>(this IEnumerable<T> items, Func<T, Task> invoke)
        {
            foreach (T item in items) await invoke?.Invoke(item);
        }

        public static async Task ForIndexAsync<T>(this IEnumerable<T> items, Func<T, int, Task> invoke)
        {
            int index = 0;
            foreach (T item in items)
            {
                await invoke?.Invoke(item, index);
                index++;
            }
        }

        //--
        public static async void ForAllAsync<T>(this IEnumerable<T> items, Action<T> invoke)
        {
            var task = new List<Task>();
            foreach (T item in items) task.Add(Task.Run(() => invoke?.Invoke(item)));
            await Task.WhenAll(task).ConfigureAwait(true);
        }

        public static async void ForAllAsync<T>(this IEnumerable<T> items, Action<T, int> invoke)
        {
            int index = 0;
            var task = new List<Task>();
            foreach (T item in items)
            {
                task.Add(Task.Run(() => invoke?.Invoke(item, index)));
                index++;
            }
            await Task.WhenAll(task).ConfigureAwait(true);
        }

        //--
        public static async Task ForAllAsync<T>(this IEnumerable<T> items, Func<T, Task> invoke)
        {
            var task = new List<Task>();
            foreach (T item in items) task.Add(invoke?.Invoke(item));
            await Task.WhenAll(task).ConfigureAwait(true);
        }

        public static async Task ForAllAsync<T>(this IEnumerable<T> items, Func<T, int, Task> invoke)
        {
            int index = 0;
            var task = new List<Task>();
            foreach (T item in items)
            {
                task.Add(invoke?.Invoke(item, index));
                index++;
            }
            await Task.WhenAll(task).ConfigureAwait(true);
        }
        //--

        public static void ForEach<T>(this IEnumerable items, Action<T> action)
        {
            foreach (T item in items)
                action?.Invoke(item);
        }

        public static void ForIndex<T>(this IEnumerable items, Action<T, int> action)
        {
            int index = 0;
            foreach (T item in items)
            {
                action?.Invoke(item, index);
                index++;
            }
        }

    }
}
