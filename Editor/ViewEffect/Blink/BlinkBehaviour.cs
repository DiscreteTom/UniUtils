using UnityEngine;

namespace DT.UniUtils.View {
  public class BlinkBehaviour<T> : MonoBehaviour where T : Component {
    [Min(0)]
    public float speed = 1f;
    public bool blinking { get; private set; } = true;
    protected T component;

    void Start() {
      this.component = this.GetComponent<T>();
    }

    protected float GetAlpha() {
      return Mathf.PingPong(Time.time * this.speed, 1);
    }

    public virtual void StartBlink() {
      this.blinking = true;
    }

    public virtual void StopBlink() {
      this.blinking = false;
    }
  }
}