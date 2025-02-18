using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;    // 矢のプレハブ
    [SerializeField] private Transform shootPoint;      // 矢を発射する位置（弓の前の位置）
    [SerializeField] private float shootForce = 20f;    // 矢にかける力
    [SerializeField] private InputActionReference shoot;

    void Update()
    {
        if (shoot.action.WasPressedThisFrame())
        {
            Debug.Log("apple");
            ShootArrow();  // 矢を発射する
        }
    }

    public void ShootArrow()
    {
        // 矢のプレハブと射出位置が指定されているか確認
        if (arrowPrefab != null && shootPoint != null)
        {
            // 矢を射出位置でインスタンス化
            GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, shootPoint.rotation);

            // 矢にRigidbodyを取得し、力を加えて発射
            Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();
            if (arrowRb != null)
            {
                // 発射方向を水平にするために、shootPointの向きに力を加える
                arrowRb.AddForce(shootPoint.right * shootForce, ForceMode.Impulse);
            }
        }
    }
}
