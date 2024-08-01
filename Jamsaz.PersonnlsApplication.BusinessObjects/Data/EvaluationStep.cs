using FarsiLibrary.Utils;

namespace Jamsaz.PersonnlsApplication.BusinessObjects.Data
{
    public partial class EvaluationStep
    {
        public string PStartDate => PersianDateConverter.ToPersianDate(StartDate).ToWritten();

        public string PEndDate => PersianDateConverter.ToPersianDate(EndDate).ToWritten();

    }
}
