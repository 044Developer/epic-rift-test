namespace EpicRiftTest.Modules.Core.Infrastructure.Data
{
    public interface ISpendable
    {
        bool IsTransactionValid(int value);
        void ApplyTransaction(int value);
    }
}