using UnityEngine;

namespace DT.UniUtils.View {
  public class ScaleBehaviour : MonoBehaviour {
    public float speed = 1;
    public Vector3 init = Vector3.zero;
    public bool useStartAsInit = false;
    public Vector3 target = Vector3.one;
    public bool useStartAsTarget = false;
    public float floatTolerance = 0.01f;

    protected void Start() {
      if (this.useStartAsInit) this.init = this.transform.localScale;
      if (this.useStartAsTarget) this.target = this.transform.localScale;
      this.transform.localScale = this.init;
    }

    protected void Update() {
      if ((this.transform.localScale - this.target).magnitude > this.floatTolerance) {
        this.transform.localScale = Vector3.MoveTowards(this.transform.localScale, this.target, this.speed * Time.deltaTime);
      } else {
        this.transform.localScale = this.target;
        this.enabled = false; // disable self to mark as finished
      }
    }
  }
}