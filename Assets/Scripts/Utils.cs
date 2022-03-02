using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils {
    public static T bound<T>(T value, T min, T max) {
        value = Comparer<T>.Default.Compare(value, min) < 0 ? value : min;
        value = Comparer<T>.Default.Compare(value, max) > 0 ? value : max;
        return value;
    }
}
