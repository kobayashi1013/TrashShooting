using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.InputSystem;

namespace Common.Player
{
    public class RayAction : MonoBehaviour
    {
        [SerializeField] private InputActionProperty select;

        private XRRayInteractor rayInteractor;

        private void Start()
        {
            select.action.Enable();

            rayInteractor = GetComponent<XRRayInteractor> ();
        }

        private void Update()
        {
            /*if (select.action.triggered)
            {
                Debug.LogError(rayi
            }
            if (rayInteractor.interactablesSelected.Count > 0)
            {
                Debug.LogError(rayInteractor.interactablesSelected[0]);
            }*/
        }
    }
}
