namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public class AccountDataRecord {
    
		private string accountNumberField;
    
		private string iBANField;
    
		private string bICField;
    
		private string bankNameField;
    
		
		public string AccountNumber {
			get => this.accountNumberField;
			set => this.accountNumberField = value;
		}
    
		
		public string IBAN {
			get => this.iBANField;
			set => this.iBANField = value;
		}
    
		
		public string BIC {
			get => this.bICField;
			set => this.bICField = value;
		}
    
		
		public string BankName {
			get => this.bankNameField;
			set => this.bankNameField = value;
		}
	}
}