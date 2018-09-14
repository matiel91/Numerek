namespace Numerek.Core
{
    /// <summary>
    /// Constructor implement IDataSource type. It can be ZomDataFileSource or ZomWebFileSource which implements IDataSource interface.
    /// Strategy desing pattern
    /// </summary>
    public class NumerekFlow
    {
        private readonly IDataSource dataSource;

        public NumerekFlow(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public Kolejki Execute(int zomNumber)
        {
            return dataSource.GetData(zomNumber);
        }
    }
}
