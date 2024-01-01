using System.Collections;
using Quell.Core.Interface;

namespace Quell.Sample.Popup
{
    public class SampleQuellQuellPopupContent : IQuellPopupContent
    {
        public void Initialize<TOpen, TClose>(IQuellPopupContentParameter<TOpen, TClose> quellPopupContentParameter)
            where TOpen : IQuellPopupOpenParameter where TClose : IQuellPopupCloseParameter
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