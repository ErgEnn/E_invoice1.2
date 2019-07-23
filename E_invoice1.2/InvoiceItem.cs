namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class InvoiceItem {
    
		private InvoiceTotalGroup invoiceTotalGroupField;
    
		private InvoiceItemGroup[] invoiceItemGroupField;
    
		private InvoiceItemTotalGroup invoiceItemTotalGroupField;
    
		
		public InvoiceTotalGroup InvoiceTotalGroup {
			get => this.invoiceTotalGroupField;
			set => this.invoiceTotalGroupField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("InvoiceItemGroup")]
		public InvoiceItemGroup[] InvoiceItemGroup {
			get => this.invoiceItemGroupField;
			set => this.invoiceItemGroupField = value;
		}
    
		
		public InvoiceItemTotalGroup InvoiceItemTotalGroup {
			get => this.invoiceItemTotalGroupField;
			set => this.invoiceItemTotalGroupField = value;
		}
	}
}