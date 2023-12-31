using System.Collections;

namespace Quell.Core.Interface
{
    public interface IPopupContent
    {
        void Initialize<TOpen, TClose>(IPopupContentParameter<TOpen, TClose> popupContentParameter);
        IEnumerator ShowAsync();
        IEnumerator HideAsync();
    }
}