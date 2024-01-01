using System;
using System.Collections;
using System.Collections.Generic;
using Quell.Core.Interface;
using UnityEngine;

namespace Quell.Core
{
    public class QuellPopupManager : MonoBehaviour
    {
        public static QuellPopupManager Instance { get; private set; }
        private readonly Stack<IQuellPopupContent> _popupStack = new();
        private readonly Queue<IQuellPopupContent> _stack = new();

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        public IEnumerator ShowPopupAsync(IQuellPopupContent quellPopup, IQuellPopupOpenParameter openParameter, IQuellPopupCloseParameter closeParameter)
        {
            var instance = Instantiate(quellPopup.PopupGameObject, this.transform);
            var content = instance.GetComponent<IQuellPopupContent>();
            content.Initialize(openParameter, closeParameter);
            _popupStack.Push(content);
            yield return content.ShowAsync();
        }

        public IEnumerator HidePopupAsync()
        {
            var targetHidePopup = _popupStack.Pop();
            yield return targetHidePopup.HideAsync();
        }
    }
}