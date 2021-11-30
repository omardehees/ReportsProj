using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportsProj.Models_Pharmacy
{
	public class journal_h
	{
		public int id { get; set; }
		public int co_id { get; set; }
		public int brnch_id { get; set; }
		public int year_id { get; set; }
		public int code { get; set; }
		public string rcpt_dt { get; set; }
		public int rcpt_dt_fmt { get; set; }
		public string rcpt_tm { get; set; }
		public short type { get; set; }
		public int supp_id { get; set; }
		public int sman_id { get; set; }
		public int store_id { get; set; }
		public string ref_no { get; set; }
		public string ref_dt { get; set; }
		public int currency { get; set; }
		public Single currate { get; set; }
		public string note { get; set; }
		public decimal amount { get; set; }
		public decimal discount { get; set; }
		public decimal net_amnt { get; set; }
		public byte inv_tp { get; set; }
		public byte pay_tp { get; set; }
		public decimal paid { get; set; }
		public decimal rest { get; set; }
		public string description { get; set; }
		public byte post { get; set; }
		public byte prnt { get; set; }
		public int usr_id { get; set; }
		public DateTime trans_dt { get; set; }
		public long dt_srch_fmt_AS_convert { get; set; }
		public string convert { get; set; }
		public Single inv_disc_p { get; set; }
		public decimal inv_disc_v { get; set; }
		public decimal cost_amnt { get; set; }
		public int pt_id { get; set; }
		public int company { get; set; }
		public string policy_no { get; set; }
		public int insurance { get; set; }
		public string ins_card { get; set; }
		public int @class {get;set;}
	public Single ins_perc { get; set; }
	public decimal pat_share { get; set; }
	public decimal co_share { get; set; }
	public byte ins_inv { get; set; }
	public decimal pat_perc { get; set; }
	public string ins_co_desc { get; set; }
	public string insd_co_desc { get; set; }
	public byte Disc_Pt_Detuct { get; set; }
	public string Visit_Dt { get; set; }
	public int rmv_usr_id { get; set; }
	public DateTime rmv_trans_dt { get; set; }
	public int doc_id { get; set; }
	public int cln_id { get; set; }
	public int clnInv_id { get; set; }
	public Single CR_Amnt { get; set; }
	public decimal Sales_Amnt { get; set; }
	public string visit_id { get; set; }
	public int chg_usr_id { get; set; }
	public DateTime chg_trans_dt { get; set; }
	public int Parent_Id { get; set; }
	public short pay_tp2 { get; set; }
	public Single pay_paid { get; set; }
	public Single pay_paid2 { get; set; }
	public Single VATPrecent { get; set; }
	public Single VATAmnt { get; set; }
	public string Verno { get; set; }
}

}
