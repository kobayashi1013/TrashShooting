using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.InputSystem;

namespace Common.Player
{
    public class RayAction : MonoBehaviour
    {
        [SerializeField] private InputActionProperty select;

        private UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor rayInteractor;

        private void Start()
        {
            rayInteractor = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRRayInteractor> ();
        }

        private void Update()
        {
            if (select.action.WasPressedThisFrame())
            {
                Debug.Log("***************");
            }
        }
    }
}
