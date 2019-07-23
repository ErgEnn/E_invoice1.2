namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class InvoiceItemGroup {
    
		private ItemEntry[] itemEntryField;
    
		private GroupEntry groupEntryField;
    
		private string groupIdField;
    
		
		[System.Xml.Serialization.XmlElementAttribute("ItemEntry")]
		public ItemEntry[] ItemEntry {
			get => this.itemEntryField;
			set => this.itemEntryField = value;
		}
    
		
		public GroupEntry GroupEntry {
			get => this.groupEntryField;
			set => this.groupEntryField = value;
		}
    
		
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string groupId {
			get => this.groupIdField;
			set => this.groupIdField = value;
		}
	}
}