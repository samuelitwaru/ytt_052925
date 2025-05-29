/*
				   File: type_SdtSDT_QueryViewerElements_Element_Analytics
			Description: Analytics
				 Author: Nemo 🐠 for C# (.NET) version 18.0.10.184260
		   Program type: Callable routine
			  Main DBMS: 
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace GeneXus.Programs
{
	[XmlRoot(ElementName="SDT_QueryViewerElements.Element.Analytics")]
	[XmlType(TypeName="SDT_QueryViewerElements.Element.Analytics" , Namespace="GeneXus.Reporting" )]
	[Serializable]
	public class SdtSDT_QueryViewerElements_Element_Analytics : GxUserType
	{
		public SdtSDT_QueryViewerElements_Element_Analytics( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showvaluesas = "";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaveragetype = "";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Differencefrom = "";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showaspercentage = "";

		}

		public SdtSDT_QueryViewerElements_Element_Analytics(IGxContext context)
		{
			this.context = context;	
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override string JsonMap(string value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (string)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("ShowValuesAs", gxTpr_Showvaluesas, false);


			AddObjectProperty("RollingAverageType", gxTpr_Rollingaveragetype, false);


			AddObjectProperty("RollingAverageTerms", gxTpr_Rollingaverageterms, false);


			AddObjectProperty("DifferenceFrom", gxTpr_Differencefrom, false);


			AddObjectProperty("ShowAsPercentage", gxTpr_Showaspercentage, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="ShowValuesAs")]
		[XmlElement(ElementName="ShowValuesAs")]
		public string gxTpr_Showvaluesas
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showvaluesas; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showvaluesas = value;
				SetDirty("Showvaluesas");
			}
		}




		[SoapElement(ElementName="RollingAverageType")]
		[XmlElement(ElementName="RollingAverageType")]
		public string gxTpr_Rollingaveragetype
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaveragetype; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaveragetype = value;
				SetDirty("Rollingaveragetype");
			}
		}




		[SoapElement(ElementName="RollingAverageTerms")]
		[XmlElement(ElementName="RollingAverageTerms")]
		public short gxTpr_Rollingaverageterms
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaverageterms; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaverageterms = value;
				SetDirty("Rollingaverageterms");
			}
		}




		[SoapElement(ElementName="DifferenceFrom")]
		[XmlElement(ElementName="DifferenceFrom")]
		public string gxTpr_Differencefrom
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Differencefrom; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Differencefrom = value;
				SetDirty("Differencefrom");
			}
		}




		[SoapElement(ElementName="ShowAsPercentage")]
		[XmlElement(ElementName="ShowAsPercentage")]
		public string gxTpr_Showaspercentage
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showaspercentage; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showaspercentage = value;
				SetDirty("Showaspercentage");
			}
		}



		public override bool ShouldSerializeSdtJson()
		{
			return true;
		}



		#endregion

		#region Static Type Properties

		[XmlIgnore]
		private static GXTypeInfo _typeProps;
		protected override GXTypeInfo TypeInfo { get { return _typeProps; } set { _typeProps = value; } }

		#endregion

		#region Initialization

		public void initialize( )
		{
			init_Showvaluesas();
			init_Rollingaveragetype();

			init_Differencefrom();
			init_Showaspercentage();
			return  ;
		}

		private void init_Showvaluesas()
		{
			string gxeval;
			gxeval = "NoCalculation";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showvaluesas = gxeval;
		}

		private void init_Rollingaveragetype()
		{
			string gxeval;
			gxeval = "Simple";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaveragetype = gxeval;
		}

		private void init_Differencefrom()
		{
			string gxeval;
			gxeval = "PreviousValue";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Differencefrom = gxeval;
		}

		private void init_Showaspercentage()
		{
			string gxeval;
			gxeval = "No";

			gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showaspercentage = gxeval;
		}



		#endregion

		#region Declaration

		protected string gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showvaluesas;
		 

		protected string gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaveragetype;
		 

		protected short gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Rollingaverageterms;
		 

		protected string gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Differencefrom;
		 

		protected string gxTv_SdtSDT_QueryViewerElements_Element_Analytics_Showaspercentage;
		 


		#endregion
	}
	#region Rest interface
	[GxJsonSerialization("default")]
	[DataContract(Name=@"SDT_QueryViewerElements.Element.Analytics", Namespace="GeneXus.Reporting")]
	public class SdtSDT_QueryViewerElements_Element_Analytics_RESTInterface : GxGenericCollectionItem<SdtSDT_QueryViewerElements_Element_Analytics>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_QueryViewerElements_Element_Analytics_RESTInterface( ) : base()
		{	
		}

		public SdtSDT_QueryViewerElements_Element_Analytics_RESTInterface( SdtSDT_QueryViewerElements_Element_Analytics psdt ) : base(psdt)
		{	
		}

		#region Rest Properties
		[DataMember(Name="ShowValuesAs", Order=0)]
		public  string gxTpr_Showvaluesas
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Showvaluesas);

			}
			set { 
				 sdt.gxTpr_Showvaluesas = value;
			}
		}

		[DataMember(Name="RollingAverageType", Order=1)]
		public  string gxTpr_Rollingaveragetype
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Rollingaveragetype);

			}
			set { 
				 sdt.gxTpr_Rollingaveragetype = value;
			}
		}

		[DataMember(Name="RollingAverageTerms", Order=2)]
		public short gxTpr_Rollingaverageterms
		{
			get { 
				return sdt.gxTpr_Rollingaverageterms;

			}
			set { 
				sdt.gxTpr_Rollingaverageterms = value;
			}
		}

		[DataMember(Name="DifferenceFrom", Order=3)]
		public  string gxTpr_Differencefrom
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Differencefrom);

			}
			set { 
				 sdt.gxTpr_Differencefrom = value;
			}
		}

		[DataMember(Name="ShowAsPercentage", Order=4)]
		public  string gxTpr_Showaspercentage
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Showaspercentage);

			}
			set { 
				 sdt.gxTpr_Showaspercentage = value;
			}
		}


		#endregion

		public SdtSDT_QueryViewerElements_Element_Analytics sdt
		{
			get { 
				return (SdtSDT_QueryViewerElements_Element_Analytics)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtSDT_QueryViewerElements_Element_Analytics() ;
			}
		}
	}
	#endregion
}