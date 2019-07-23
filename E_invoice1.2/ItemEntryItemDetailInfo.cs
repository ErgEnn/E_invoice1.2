namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	public  class ItemEntryItemDetailInfo {
    
		private string itemUnitField;
    
		private decimal itemAmountField;
    
		private bool itemAmountFieldSpecified;
    
		private decimal itemPriceField;
    
		private bool itemPriceFieldSpecified;
    
		
		public string ItemUnit {
			get => this.itemUnitField;
			set => this.itemUnitField = value;
		}
    
		
		public decimal ItemAmount {
			get => this.itemAmountField;
			set => this.itemAmountField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ItemAmountSpecified {
			get => this.itemAmountFieldSpecified;
			set => this.itemAmountFieldSpecified = value;
		}
    
		
		public decimal ItemPrice {
			get => this.itemPriceField;
			set => this.itemPriceField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ItemPriceSpecified {
			get => this.itemPriceFieldSpecified;
			set => this.itemPriceFieldSpecified = value;
		}
	}
}