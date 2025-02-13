using UnityEngine;
using UnityEngine.InputSystem;

public class shoot : MonoBehaviour
{
    [SerializeField] public InputActionReference shootButton;
    public GameObject arrowPrefab; // 矢のPrefabをインスペクターで設定
    public Transform shootPoint;   // 射出位置（もし必要であれば設定）
    public float shootForce = 10f; // 矢を射出する力

    // 矢を射出する方向をインスペクターで調整可能にするための変数
    [SerializeField] private Vector3 shootDirection = Vector3.forward;

    private void Update()
    {
        if (shootButton.action.WasPerformedThisFrame())
        {
            ShootArrow();
        }
    }

    void ShootArrow()
    {
        // 矢を射出位置から生成
        GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);

        // 矢にRigidbodyがあれば力を加える
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // shootDirectionを使って矢を射出
            rb.AddForce(shootDirection.normalized * shootForce, ForceMode.Impulse);  // 向きを調整
        }
    }

    // インスペクターで方向を設定しやすくするためにget, setを提供（オプション）
    public Vector3 ShootDirection
    {
        get { return shootDirection; }
        set { shootDirection = value; }
    }
}
