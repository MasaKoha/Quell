using System.Collections;
using Quell.Core.Interface;
using UnityEngine;

namespace Quell.Core
{
    public class QuellPopupManager : MonoBehaviour
    {
        public static QuellPopupManager Instance { get; private set; }
        private Transform _quellPopupManagerRoot;
        private readonly Stack _popupStack = new();

        private void Awake()
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        public IEnumerator ShowPopup(IQuellPopupContent quellPopup)
        {
            yield return null;
        }
    }
}