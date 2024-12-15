using UnityEngine;

namespace Common.Player
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _xrPlayerPrefab;

        private void Start()
        {
            var xrPlayer = Instantiate(_xrPlayerPrefab);
            Destroy(this.gameObject);
        }
    }
}
