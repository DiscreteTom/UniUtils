using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatBehaviour : MonoBehaviour {
    [Min(0)]
    public float range = 1;
    [Min(0)]
    public float speed = 1;
    public float timeOffset = 0;
    public float offset = 0;
    [SerializeField] protected bool useInitPosition = true;
  }
}