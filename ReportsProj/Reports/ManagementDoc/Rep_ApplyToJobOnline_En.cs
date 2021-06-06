using System;
using DevExpress.XtraReports.UI;

namespace ReportsProj.Reports.ManagementDoc
{
    public partial class Rep_ApplyToJobOnline_En
    {
        public Rep_ApplyToJobOnline_En()
        {
            InitializeComponent();
        }

        private void label85_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XRLabel xrl = (DevExpress.XtraReports.UI.XRLabel)sender;
            xrl.Text = xrl.Text.Replace("|", Environment.NewLine);
        }

        private void label80_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
