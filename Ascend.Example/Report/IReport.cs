namespace Ascend.Example.Report
{
    public interface IReport<T>
    {
        ReportDataBase<T> ReportItems { get; set; }

        void Render();
    }
}