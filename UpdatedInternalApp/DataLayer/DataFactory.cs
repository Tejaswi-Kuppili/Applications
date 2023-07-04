namespace DataLayer
{
    public class DataFactory
    {
        public IDALAuthentication GetObj()
        {
            return new DALAuthentication();
        }
    }
}
