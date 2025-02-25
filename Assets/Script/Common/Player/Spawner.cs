using UnityEngine;

namespace Common.Player
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private GameObject _xrPlayerPrefab;
        private Canvas _canvas;

        private void Start()
        {
            //Spawn player.
            var xrPlayer = Instantiate(_xrPlayerPrefab);

            //Camera setting.
            _canvas = FindFirstObjectByType<Canvas>();
            if (_canvas != null) _canvas.worldCamera = Camera.main;

            //Destroy don't need objects.
            Destroy(this.gameObject);
        }
    }
}
