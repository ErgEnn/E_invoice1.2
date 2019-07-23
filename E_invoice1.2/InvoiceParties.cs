using System;

namespace E_invoice1._2 {

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.3081.0")]
	[Serializable()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public class InvoiceParties {
		private SellerPartyRecord sellerPartyField;

		private BillPartyRecord buyerPartyField;

		private BillPartyRecord recipientPartyField;

		private BillPartyRecord deliveryPartyField;

		private BillPartyRecord payerPartyField;

		private BillPartyRecord factorPartyField;

		
		public SellerPartyRecord SellerParty
		{
			get => this.sellerPartyField;
			set => this.sellerPartyField = value;
		}

		
		public BillPartyRecord BuyerParty
		{
			get => this.buyerPartyField;
			set => this.buyerPartyField = value;
		}

		
		public BillPartyRecord RecipientParty
		{
			get => this.recipientPartyField;
			set => this.recipientPartyField = value;
		}

		
		public BillPartyRecord DeliveryParty
		{
			get => this.deliveryPartyField;
			set => this.deliveryPartyField = value;
		}

		
		public BillPartyRecord PayerParty
		{
			get => this.payerPartyField;
			set => this.payerPartyField = value;
		}

		
		public BillPartyRecord FactorParty
		{
			get => this.factorPartyField;
			set => this.factorPartyField = value;
		}
	}
}
