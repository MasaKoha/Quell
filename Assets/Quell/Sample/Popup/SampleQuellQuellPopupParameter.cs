using System;
using Quell.Core.Interface;

namespace Quell.Sample.Popup
{
    public class SampleQuellQuellPopupParameter : IQuellPopupContentParameter<QuellPopupOpenSampleParameter, QuellPopupCloseSampleParameter>
    {
        public QuellPopupOpenSampleParameter OpenParameter { get; set; }
        public Action<QuellPopupCloseSampleParameter> OnCloseParameter { get; set; }
    }
}