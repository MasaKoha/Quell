using System.Collections;
using Quell.Core.Interface;

namespace Quell.Sample
{
    public class SampleQuellPopupContent : IQuellPopupContent
    {
        public void Initialize<TOpenParameter, TCloseParameter>(IQuellPopupContentParameter<TOpenParameter, TCloseParameter> quellPopupContentParameter)
            where TOpenParameter : IQuellPopupOpenParameter where TCloseParameter : IQuellPopupCloseParameter
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator ShowAsync()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator HideAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}