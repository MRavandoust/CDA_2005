using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ExerciceInterfaceUtilisateur
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

            var connectionStringSection = config.GetSection("connectionStrings") as ConnectionStringsSection;
            if (connectionStringSection != null && !connectionStringSection.SectionInformation.IsProtected)
            {
                connectionStringSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.Save();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDemandeurDEmploi());
            //Application.Run(new FormDiplome());
        }
    }
}
