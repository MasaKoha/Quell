using UnityEngine;
using UnityEngine.UI;

namespace Quell.Core
{
    public class QuellPopupContentBackground : MonoBehaviour
    {
        [SerializeField] private Button _backgroundButton;

        public void SetEnable(bool enable)
        {
            _backgroundButton.enabled = enable;
        }

        public void SetActiveBackground(bool isActive)
        {
            this.gameObject.SetActive(isActive);
        }
    }
}