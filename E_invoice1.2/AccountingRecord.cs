namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public class AccountingRecord {
    
		private string descriptionField;
    
		private AccountingRecordJournalEntry[] journalEntryField;
    
		private string partnerCodeField;
    
		private string businessCodeField;
    
		private string sourceCodeField;
    
		private string cashFlowCodeField;
    
		private string classificatorCodeField;
    
		
		public string Description {
			get => this.descriptionField;
			set => this.descriptionField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("JournalEntry")]
		public AccountingRecordJournalEntry[] JournalEntry {
			get => this.journalEntryField;
			set => this.journalEntryField = value;
		}
    
		
		public string PartnerCode {
			get => this.partnerCodeField;
			set => this.partnerCodeField = value;
		}
    
		
		public string BusinessCode {
			get => this.businessCodeField;
			set => this.businessCodeField = value;
		}
    
		
		public string SourceCode {
			get => this.sourceCodeField;
			set => this.sourceCodeField = value;
		}
    
		
		public string CashFlowCode {
			get => this.cashFlowCodeField;
			set => this.cashFlowCodeField = value;
		}
    
		
		public string ClassificatorCode {
			get => this.classificatorCodeField;
			set => this.classificatorCodeField = value;
		}
	}
}