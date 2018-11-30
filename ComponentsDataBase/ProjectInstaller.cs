using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace ComponentsDBService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        ServiceController controller;
        public ProjectInstaller()
        {
            InitializeComponent();
            controller = new ServiceController(serviceInstaller.ServiceName);
        }

        private void ProjectInstaller_Committed(object sender, InstallEventArgs e)
        {
            if(controller.Status == ServiceControllerStatus.Stopped)
            {
                controller.Start();
                controller.WaitForStatus(ServiceControllerStatus.Running, System.TimeSpan.FromSeconds(10));
            }
        }

        private void ProjectInstaller_BeforeUninstall(object sender, InstallEventArgs e)
        {
            if(controller.Status == ServiceControllerStatus.Running)
            {
                controller.Stop();
                controller.WaitForStatus(ServiceControllerStatus.Stopped, System.TimeSpan.FromSeconds(10));
            }
        }
    }
}
