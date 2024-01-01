using System.Collections;
using UnityEngine;

namespace Quell.Core.Interface
{
    public interface IQuellPopupContent
    {
        GameObject PopupGameObject { get; }
        void Initialize(IQuellPopupOpenParameter openParameter, IQuellPopupCloseParameter closeParameter);
        IEnumerator ShowAsync();
        IEnumerator HideAsync();
    }
}