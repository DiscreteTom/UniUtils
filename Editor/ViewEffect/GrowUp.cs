using UnityEngine;

namespace DT.UniUtils.View {
  public class GrowUp : MonoBehaviour {
    public float speed = 1;
    public Vector3 targetSize = Vector3.one;
    [SerializeField] bool useInitSize = true;

    void Start() {
      if (this.useInitSize) {
        this.targetSize = this.transform.localScale;
      }
      this.transform.localScale = Vector3.zero;
    }

    void Update() {
      if (this.transform.localScale.x < 1)
        this.transform.localScale += Vector3.one * this.speed * Time.deltaTime;
      else {
        this.transform.localScale = Vector3.one;
        Destroy(this); // remove this component
      }
    }
  }
}