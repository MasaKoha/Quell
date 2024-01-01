using System;

namespace Quell.Core.Interface
{
    public interface IQuellPopupContentParameter<TOpen, TClose>
        where TOpen : IQuellPopupOpenParameter where TClose : IQuellPopupCloseParameter
    {
        TOpen OpenParameter { get; set; }
        Action<TClose> OnCloseParameter { get; set; }
    }
}