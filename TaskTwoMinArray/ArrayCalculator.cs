using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskTwoMinArray
{
    public static class ArrayCalculator
    {
        /// <summary>
        /// Функция принимает IEnumerable из структур, которые реализуют интерфейсы IComparable, IConvertible.        ///
        /// </summary>
        /// <typeparam name="T">Структура реализующая IComparable, IConvertible</typeparam>
        /// <param name="collection">Коллекция элементов</param>
        /// <returns>Возвращает сумму двух минимальных элементов переданной коллекции</returns>
        /// <exception cref="ArgumentException">
        /// </exception>
        public static T GetMinTwoAndSum<T>(IEnumerable<T> collection) where T : struct, IComparable, IConvertible
        {
            if (collection.Count() < 2)
                throw new ArgumentException("The array must consist of two or more elements. Was " + collection.Count());

            var pair = collection
                .OrderBy(x => x)
                .Take(2);

            return (dynamic)pair.ElementAt(0) + (dynamic)pair.ElementAt(1);
        }
    }
}
