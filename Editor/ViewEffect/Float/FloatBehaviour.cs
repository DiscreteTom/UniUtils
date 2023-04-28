using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatBehaviour : MonoBehaviour {
    [Min(0)]
    public float range = 1;
    [Min(0)]
    public float speed = 1;
    public float phase = 0;
    [Tooltip("If true, will randomize the phase between -range and range")]
    public bool randomPhase = false;
    public float offset = 0;
    [Tooltip("If true, will use the current offset of the component as the offset")]
    public bool useStartOffset = true;

    protected virtual void Start() {
      if (this.randomPhase) this.phase = Random.Range(-this.range, this.range);
    }
  }
}