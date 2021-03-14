using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        void Add(string Key, object value, int duration);
        T Get<T>(string key);
        object Get(string key); // Bu şeklilde de kullanılabilir.
        bool IsAdd(string key); //Cachede var mı yok mu
        void Remove(string key);
        void RemoveByPattern(string pattern); //Ör şu kategoridekiler uçur
    }
}
