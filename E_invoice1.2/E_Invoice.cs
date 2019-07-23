namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public class E_Invoice {
    
		private Header headerField;
    
		private Invoice[] invoiceField;
    
		private Footer footerField;
    
		
		public Header Header {
			get => this.headerField;
			set => this.headerField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Invoice")]
		public Invoice[] Invoice {
			get => this.invoiceField;
			set => this.invoiceField = value;
		}
    
		
		public Footer Footer {
			get => this.footerField;
			set => this.footerField = value;
		}
	}
}