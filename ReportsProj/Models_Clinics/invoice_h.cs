using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Models_Clinics
{
	public class invoice_h
	{
		public int id { get; set; }
		public short? branch { get; set; }
		public short? type { get; set; }
		public int? code { get; set; }
		public string inv_dt { get; set; }
		public int? inv_dt_fmt { get; set; }
		public int? inv_chk_dt { get; set; }
		public string inv_tm { get; set; }
		public int? pt_id { get; set; }
		public byte? null_pt { get; set; }
		public string pt_name { get; set; }
		public int? doc_id { get; set; }
		public short? contType { get; set; }
		public int? cln_id { get; set; }
		public int? company { get; set; }
		public string policy_no { get; set; }
		public int? insurance { get; set; }
		public string ins_card { get; set; }
		public int? @class { get; set; }
		public string visit_id { get; set; }
		public byte? visit_tp { get; set; }
		public short? vperiod { get; set; }
		public decimal? pat_share { get; set; }
		public decimal? co_share { get; set; }
		public decimal? srvc_disc { get; set; }
		public decimal? amount { get; set; }
		public decimal? inv_disc { get; set; }
		public decimal? net_amnt { get; set; }
		public decimal? cash { get; set; }
		public decimal? span { get; set; }
		public decimal? pt_check { get; set; }
		public decimal? balance { get; set; }
		public decimal? visa { get; set; }
		public decimal? m_card { get; set; }
		public decimal? ins_credit { get; set; }
		public decimal? pt_credit { get; set; }
		public decimal? tot_paid { get; set; }
		public decimal? CP { get; set; }
		public decimal? doc_comm { get; set; }
		public decimal? cln_comm { get; set; }
		public byte? status { get; set; }
		public int? reception { get; set; }
		public short? prnt { get; set; }
		public byte? Post { get; set; }
		public string note { get; set; }
		public byte? ovr_tm { get; set; }
		public decimal? cost { get; set; }
		public int? usr_id { get; set; }
		public DateTime? trans_dt { get; set; }
		public int? chg_usr_id { get; set; }
		public DateTime? chg_trans_dt { get; set; }
		public int? rmv_usr_id { get; set; }
		public DateTime? rmv_trans_dt { get; set; }
		public Single? fixed_deduct { get; set; }
		public string review_dt { get; set; }
		public int? review_dt_fmt { get; set; }
		public byte? Inv_Tp2 { get; set; }
		public int? invent_id { get; set; }
		public int? prog_id { get; set; }
		public byte? card_tp { get; set; }
		public byte? cheq_tp { get; set; }
		public decimal? adjust_amnt { get; set; }
		public byte? DiscPoint { get; set; }
		public byte? sent { get; set; }
		public string ELIGREFNO { get; set; }
		public string APPREFNO { get; set; }
		public int? quat_id { get; set; }
		public string Class_Desc { get; set; }
		public int? inv_id { get; set; }
		public int? quat_no { get; set; }
		public string Approval_no { get; set; }
		public int? seqno { get; set; }
		public int? assitant_id { get; set; }
		public Single? VATPrecent { get; set; }
		public Single? VATAmnt { get; set; }
		public Single? PtVat { get; set; }
		public Single? CoVat { get; set; }
		public Single? neqaty { get; set; }
		public int? QuatRowno { get; set; }
		public short? SendEinvoice { get; set; }
		public DateTime? SeneEinvDt { get; set; }
		public short? Approved { get; set; }
		public string Pt_Out { get; set; }
	}
}
