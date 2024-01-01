using Quell.Core.Interface;

namespace Quell.Sample.Popup
{
    public class QuellPopupOpenSampleParameter : IQuellPopupOpenParameter
    {
        public string ShowText;
        public int Count;
    }

    public class QuellPopupCloseSampleParameter : IQuellPopupCloseParameter
    {
        public bool IsSuccess;
    }
}