namespace EpicRiftTest.Modules.Core.Infrastructure.Data
{
    public interface ISpendable
    {
        void IsTransactionValid(int value);
        void ApplyTransaction(int value);
    }
}