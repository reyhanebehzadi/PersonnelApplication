using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class PerformancEvaluationDetail
    {
        public string Title
        {
            get
            {
                if (this.EvaluationIndex != null)

                    return EvaluationIndex.Title;
                return string.Empty;
            }
        }

        public string CategoryTitle
        {
            get
            {
                if (this.EvalutionIndexID != null)

                    return this.EvaluationIndex.CategoriesIndexEvaluation.Title;
                return string.Empty;
            }
        }

        public string ValuatorTitle => Valuator == null ? string.Empty : Valuator.Title;

        public int ValuatorScore => Valuator?.Code ?? 0;
    }
}
