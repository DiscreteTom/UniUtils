using UnityEngine;

namespace DT.UniUtils {
  public static class LayerMaskExtension {
    public static bool Contains(this LayerMask mask, int target) {
      return (mask.value & (1 << target)) != 0;
    }
  }
}
