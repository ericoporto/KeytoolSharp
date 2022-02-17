using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSignTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            AndroidKeystoreData d = new AndroidKeystoreData();

            d.KeystorePath = textboxKeystorePath.Text;
            d.Password = textboxKeystorePassword.Text;
            d.KeyAlias = textboxKeystoreKeyAlias.Text;
            d.KeyPassword = textboxKeystoreKeyPassword.Text;

            d.ValidityInYears = (int)numericValidityYears.Value;

            d.FirstAndLastName = textboxKeystoreCertCN.Text;
            d.OrganizationalUnit = textboxKeystoreCertOU.Text;
            d.OrganizationName = textboxKeystoreCertO.Text;
            d.CityOrLocality = textboxKeystoreCertL.Text;
            d.StateOrProvince = textboxKeystoreCertST.Text;
            d.CountryCode = textboxKeystoreCertC.Text;

            AndroidUtils.RunGenerateKeystore(d);
        }
    }
}
