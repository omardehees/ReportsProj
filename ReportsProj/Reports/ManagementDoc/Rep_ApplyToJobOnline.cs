using System;
using DevExpress.XtraReports.UI;

namespace ReportsProj.Reports.ManagementDoc
{
    public partial class Rep_ApplyToJobOnline
    {
        public Rep_ApplyToJobOnline()
        {
            InitializeComponent();
        }

        private void label80_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XRLabel xrl = (DevExpress.XtraReports.UI.XRLabel)sender;
            xrl.Text = xrl.Text.Replace("|", Environment.NewLine);
        }

        private void label85_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XRLabel xrl = (DevExpress.XtraReports.UI.XRLabel)sender;
            xrl.Text = xrl.Text.Replace("|", Environment.NewLine);
        }

        private void label61_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XRLabel xrl = (DevExpress.XtraReports.UI.XRLabel)sender;
            xrl.Text = xrl.Text.Replace("|", Environment.NewLine);
        }

        private void label28_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XRLabel xrl = (DevExpress.XtraReports.UI.XRLabel)sender;
            xrl.Text = xrl.Text.Replace("|", Environment.NewLine);
        }
    }
}
