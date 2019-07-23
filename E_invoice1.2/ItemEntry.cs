namespace E_invoice1._2 {
	
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
	public  class ItemEntry {
    
		private string rowNoField;
    
		private string serialNumberField;
    
		private string sellerProductIdField;
    
		private string buyerProductIdField;
    
		private string taricCodeField;
    
		private AccountingRecord accountingField;
    
		private string customerRefField;
    
		private string descriptionField;
    
		private string eANField;
    
		private string initialReadingField;
    
		private string finalReadingField;
    
		private ExtensionRecord[] itemReserveField;
    
		private ItemEntryItemDetailInfo[] itemDetailInfoField;
    
		private decimal itemSumField;
    
		private bool itemSumFieldSpecified;
    
		private AdditionRecord[] additionField;
    
		private VATRecord vATField;
    
		private decimal itemTotalField;
    
		private bool itemTotalFieldSpecified;
    
		
		public string RowNo {
			get => this.rowNoField;
			set => this.rowNoField = value;
		}
    
		
		public string SerialNumber {
			get => this.serialNumberField;
			set => this.serialNumberField = value;
		}
    
		
		public string SellerProductId {
			get => this.sellerProductIdField;
			set => this.sellerProductIdField = value;
		}
    
		
		public string BuyerProductId {
			get => this.buyerProductIdField;
			set => this.buyerProductIdField = value;
		}
    
		
		public string TaricCode {
			get => this.taricCodeField;
			set => this.taricCodeField = value;
		}
    
		
		public AccountingRecord Accounting {
			get => this.accountingField;
			set => this.accountingField = value;
		}
    
		
		public string CustomerRef {
			get => this.customerRefField;
			set => this.customerRefField = value;
		}
    
		
		public string Description {
			get => this.descriptionField;
			set => this.descriptionField = value;
		}
    
		
		public string EAN {
			get => this.eANField;
			set => this.eANField = value;
		}
    
		
		public string InitialReading {
			get => this.initialReadingField;
			set => this.initialReadingField = value;
		}
    
		
		public string FinalReading {
			get => this.finalReadingField;
			set => this.finalReadingField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("ItemReserve")]
		public ExtensionRecord[] ItemReserve {
			get => this.itemReserveField;
			set => this.itemReserveField = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("ItemDetailInfo")]
		public ItemEntryItemDetailInfo[] ItemDetailInfo {
			get => this.itemDetailInfoField;
			set => this.itemDetailInfoField = value;
		}
    
		
		public decimal ItemSum {
			get => this.itemSumField;
			set => this.itemSumField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ItemSumSpecified {
			get => this.itemSumFieldSpecified;
			set => this.itemSumFieldSpecified = value;
		}
    
		
		[System.Xml.Serialization.XmlElementAttribute("Addition")]
		public AdditionRecord[] Addition {
			get => this.additionField;
			set => this.additionField = value;
		}
    
		
		public VATRecord VAT {
			get => this.vATField;
			set => this.vATField = value;
		}
    
		
		public decimal ItemTotal {
			get => this.itemTotalField;
			set => this.itemTotalField = value;
		}
    
		
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ItemTotalSpecified {
			get => this.itemTotalFieldSpecified;
			set => this.itemTotalFieldSpecified = value;
		}
	}
}