using System.Collections;
using Quell.Core.Interface;
using UnityEngine;

namespace Quell.Sample
{
    public class SampleQuellPopupContent : MonoBehaviour, IQuellPopupContent
    {
        public GameObject PopupGameObject => this.gameObject;
        public IQuellPopupContent Content => this;

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