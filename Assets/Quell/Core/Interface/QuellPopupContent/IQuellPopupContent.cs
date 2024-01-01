using System.Collections;

namespace Quell.Core.Interface
{
    public interface IQuellPopupContent
    {
        void Initialize<TOpenParameter, TCloseParameter>(IQuellPopupContentParameter<TOpenParameter, TCloseParameter> parameter)
            where TOpenParameter : IQuellPopupOpenParameter where TCloseParameter : IQuellPopupCloseParameter;

        IEnumerator ShowAsync();
        IEnumerator HideAsync();
    }
}