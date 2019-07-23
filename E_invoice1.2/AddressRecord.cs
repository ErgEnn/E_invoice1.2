namespace E_invoice1._2 {
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	public class AddressRecord {
    
		private string postalAddress1Field;
    
		private string postalAddress2Field;
    
		private string cityField;
    
		private string postalCodeField;
    
		private string countryField;
    
		private ExtensionRecord[] extensionField;
    
		
		public string PostalAddress1 {
			get => this.postalAddress1Field;
			set => this.postalAddress1Field = value;
		}
    
		
		public string PostalAddress2 {
			get => this.postalAddress2Field;
			set => this.postalAddress2Field = value;
		}
    
		
		public string City {
			get => this.cityField;
			set => this.cityField = value;
		}
    
		
		public string PostalCode {
			get => this.postalCodeField;
			set => this.postalCodeField = value;
		}
    
		
		public string Country {
			get => this.countryField;
			set => this.countryField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Extension")]
		public ExtensionRecord[] Extension {
			get => this.extensionField;
			set => this.extensionField = value;
		}
	}
}