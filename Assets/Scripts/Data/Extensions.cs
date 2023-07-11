using System.Collections;
using UnityEngine;

  public static class Extensions
    {
        public static string ToJson(this object obj) => JsonUtility.ToJson(obj);

        public static T ToDesirialize<T>(this string json) =>
            JsonUtility.FromJson<T>(json);
    }
