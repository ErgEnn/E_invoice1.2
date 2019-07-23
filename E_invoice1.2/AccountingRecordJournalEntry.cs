namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public class AccountingRecordJournalEntry {
    
		private string generalLedgerField;
    
		private string generalLedgerDetailField;
    
		private string costObjectiveField;
    
		private decimal sumField;
    
		private bool sumFieldSpecified;
    
		private decimal vatSumField;
    
		private bool vatSumFieldSpecified;
    
		private decimal vatRateField;
    
		private bool vatRateFieldSpecified;
    
		
		public string GeneralLedger {
			get => this.generalLedgerField;
			set => this.generalLedgerField = value;
		}
    
		
		public string GeneralLedgerDetail {
			get => this.generalLedgerDetailField;
			set => this.generalLedgerDetailField = value;
		}
    
		
		public string CostObjective {
			get => this.costObjectiveField;
			set => this.costObjectiveField = value;
		}
    
		
		public decimal Sum {
			get => this.sumField;
			set => this.sumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool SumSpecified {
			get => this.sumFieldSpecified;
			set => this.sumFieldSpecified = value;
		}
    
		
		public decimal VatSum {
			get => this.vatSumField;
			set => this.vatSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool VatSumSpecified {
			get => this.vatSumFieldSpecified;
			set => this.vatSumFieldSpecified = value;
		}
    
		
		public decimal VatRate {
			get => this.vatRateField;
			set => this.vatRateField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool VatRateSpecified {
			get => this.vatRateFieldSpecified;
			set => this.vatRateFieldSpecified = value;
		}
	}
}