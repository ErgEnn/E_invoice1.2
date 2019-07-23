namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public  class InvoiceInformationType {
    
		private string sourceInvoiceField;
    
		private string typeField;
    
		
		public string SourceInvoice {
			get => this.sourceInvoiceField;
			set => this.sourceInvoiceField = value;
		}
    
		
		[System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
		public string type {
			get => this.typeField;
			set => this.typeField = value;
		}
	}
}