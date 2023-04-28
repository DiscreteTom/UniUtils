using UnityEngine;

namespace DT.UniUtils.View {
  public class BlinkBehaviour<T> : MonoBehaviour where T : Component {
    [Min(0)]
    public float speed = 1f;
    [Range(0, 1)]
    public float minAlpha = 0f;
    [Range(0, 1)]
    public float maxAlpha = 1f;
    public bool startAlphaAsMax = true;

    protected T component;

    protected void Start() {
      this.component = this.GetComponent<T>();
    }

    protected float GetAlpha() {
      return Mathf.PingPong(Time.time * this.speed, this.maxAlpha - this.minAlpha) + this.minAlpha;
    }
  }
}