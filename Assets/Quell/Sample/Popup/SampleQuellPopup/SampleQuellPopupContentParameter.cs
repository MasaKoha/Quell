using System;
using Quell.Core.Interface;

namespace Quell.Sample.Popup.SampleQuellPopup
{
    public class SampleQuellPopupContentParameter : IQuellPopupContentParameter<QuellPopupOpenSampleParameter, QuellPopupCloseSampleParameter>
    {
        public QuellPopupOpenSampleParameter OpenParameter { get; set; }
        public Action<QuellPopupCloseSampleParameter> OnCloseParameter { get; set; }
    }
}