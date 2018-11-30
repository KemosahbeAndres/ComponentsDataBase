using System.ServiceProcess;

namespace ComponentsDBService
{
    public partial class ServiceCDB : ServiceBase
    {
        private DBApplication mApplication;

        public ServiceCDB()
        {
            InitializeComponent();

            try
            {
                mApplication = new DBApplication();
            }
            catch { }

        }

        protected override void OnStart(string[] args)
        {
            try
            {
                mApplication.Run();
            }
            catch
            {
                
            }
            
        }

        protected override void OnStop()
        {

        }
    }
}
