using System.Collections;
using Quell.Core.Interface;
using UnityEngine;

namespace Quell.Sample.Popup
{
    public class SampleQuellQuellPopupContent : MonoBehaviour, IQuellPopupContent
    {
        public GameObject PopupGameObject => this.gameObject;

        public void Initialize(IQuellPopupOpenParameter openParameter, IQuellPopupCloseParameter closeParameter)
        {
        }

        public IEnumerator ShowAsync()
        {
            yield break;
        }

        public IEnumerator HideAsync()
        {
            yield break;
        }
    }
}