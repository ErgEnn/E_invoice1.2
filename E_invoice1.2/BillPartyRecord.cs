namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public  class BillPartyRecord {
    
		private string gLNField;
    
		private string uniqueCodeField;
    
		private string nameField;
    
		private string depIdField;
    
		private string regNumberField;
    
		private string vATRegNumberField;
    
		private ContactDataRecord contactDataField;
    
		private AccountDataRecord[] accountInfoField;
    
		private ExtensionRecord[] extensionField;
    
		
		public string GLN {
			get => this.gLNField;
			set => this.gLNField = value;
		}
    
		
		public string UniqueCode {
			get => this.uniqueCodeField;
			set => this.uniqueCodeField = value;
		}
    
		
		public string Name {
			get => this.nameField;
			set => this.nameField = value;
		}
    
		
		public string DepId {
			get => this.depIdField;
			set => this.depIdField = value;
		}
    
		
		public string RegNumber {
			get => this.regNumberField;
			set => this.regNumberField = value;
		}
    
		
		public string VATRegNumber {
			get => this.vATRegNumberField;
			set => this.vATRegNumberField = value;
		}
    
		
		public ContactDataRecord ContactData {
			get => this.contactDataField;
			set => this.contactDataField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("AccountInfo")]
		public AccountDataRecord[] AccountInfo {
			get => this.accountInfoField;
			set => this.accountInfoField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Extension")]
		public ExtensionRecord[] Extension {
			get => this.extensionField;
			set => this.extensionField = value;
		}
	}
}