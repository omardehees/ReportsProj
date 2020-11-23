using System;
using DevExpress.Compatibility.System.Web;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace ReportsProj.Reports
{
    public partial class MyInvoices : XtraReport
    {
        public MyInvoices()
        {
            InitializeComponent();

            //MyInvoices myInvoices = new MyInvoices();
            //XtraReport report = new XtraReport();
            //Parameter param1 = new Parameter();
            //param1.Name = "MyID";
            //report.FilterString = "[ID] = 240";
            //report.RequestParameters = false;
            //myInvoices.FilterString = "[ID] = 240";

        }

        //int parameter;

        //private void XtraReport1_ParametersRequestSubmit(object sender,
        //    ParametersRequestEventArgs e)
        //{
        //    if ((int)e.ParametersInformation[0].Parameter.Value > 10 ||
        //        (int)e.ParametersInformation[0].Parameter.Value < 0)
        //    {
        //        e.ParametersInformation[0].Parameter.Value = parameter;
        //        //e.ParametersInformation[0].Editor.Text = parameter.ToString();
        //    }
        //}

        //private void XtraReport1_ParametersRequestValueChanged(object sender,
        //    ParametersRequestValueChangedEventArgs e)
        //{
        //    parameter = (int)e.ChangedParameterInfo.Parameter.Value;
        //}



    }
}
