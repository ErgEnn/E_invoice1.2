namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public  class ContactDataRecord {
    
		private string contactNameField;
    
		private string contactPersonCodeField;
    
		private string phoneNumberField;
    
		private string faxNumberField;
    
		private string uRLField;
    
		private string emailAddressField;
    
		private AddressRecord legalAddressField;
    
		private AddressRecord mailAddressField;
    
		private ExtensionRecord[] contactInformationField;
    
		
		public string ContactName {
			get => this.contactNameField;
			set => this.contactNameField = value;
		}
    
		
		public string ContactPersonCode {
			get => this.contactPersonCodeField;
			set => this.contactPersonCodeField = value;
		}
    
		
		public string PhoneNumber {
			get => this.phoneNumberField;
			set => this.phoneNumberField = value;
		}
    
		
		public string FaxNumber {
			get => this.faxNumberField;
			set => this.faxNumberField = value;
		}
    
		
		public string URL {
			get => this.uRLField;
			set => this.uRLField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("E-mailAddress")]
		public string EmailAddress {
			get => this.emailAddressField;
			set => this.emailAddressField = value;
		}
    
		
		public AddressRecord LegalAddress {
			get => this.legalAddressField;
			set => this.legalAddressField = value;
		}
    
		
		public AddressRecord MailAddress {
			get => this.mailAddressField;
			set => this.mailAddressField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("ContactInformation")]
		public ExtensionRecord[] ContactInformation {
			get => this.contactInformationField;
			set => this.contactInformationField = value;
		}
	}
}