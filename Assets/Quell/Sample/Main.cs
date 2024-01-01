using System.Collections;
using Quell.Core;
using Quell.Sample.Popup;
using UnityEngine;

namespace Quell.Sample
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private SampleQuellPopupContent _popup;

        private void Start()
        {
            StartCoroutine(ShowPopupAsync());
        }

        private IEnumerator ShowPopupAsync()
        {
            var open = new QuellPopupOpenSampleParameter()
            {
                Count = 14,
                ShowText = "Popup Test",
            };

            var close = new QuellPopupCloseSampleParameter()
            {
                IsSuccess = true,
            };
            yield return QuellPopupManager.Instance.ShowPopupAsync(_popup, open, close);
        }
    }
}