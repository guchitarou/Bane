using UnityEngine;

public class Bane : MonoBehaviour
{
    public GameObject target,anchor;
    float k=50,S=6;
    Vector3 dee,dee2,f;
    Rigidbody2D rb;
    void Start()
    {
        rb = target.GetComponent<Rigidbody2D>();  // rigidbodyを取得
    }
    void Update()
    {
        dee = (anchor.transform.position - target.transform.position)*k;
        dee2 = (dee - (f - dee)*S);// 力を設定
        f = dee;
        Vector3 force = dee2;    
        rb.AddForce(force);  // 力を加える
    }
}
