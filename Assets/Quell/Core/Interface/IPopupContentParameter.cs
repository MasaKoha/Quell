using System;

namespace Quell.Core.Interface
{
    public interface IPopupContentParameter<TOpen, TClose>
    {
        TOpen GetOpenParameter { get; set; }
        Action<TClose> OnCloseParameter { get; set; }
    }
}