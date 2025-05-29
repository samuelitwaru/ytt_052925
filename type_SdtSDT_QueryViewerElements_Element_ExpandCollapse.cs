/*
				   File: type_SdtSDT_QueryViewerElements_Element_ExpandCollapse
			Description: ExpandCollapse
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
	[XmlRoot(ElementName="SDT_QueryViewerElements.Element.ExpandCollapse")]
	[XmlType(TypeName="SDT_QueryViewerElements.Element.ExpandCollapse" , Namespace="GeneXus.Reporting" )]
	[Serializable]
	public class SdtSDT_QueryViewerElements_Element_ExpandCollapse : GxUserType
	{
		public SdtSDT_QueryViewerElements_Element_ExpandCollapse( )
		{
			/* Constructor for serialization */
			gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Type = "";

		}

		public SdtSDT_QueryViewerElements_Element_ExpandCollapse(IGxContext context)
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
			AddObjectProperty("Type", gxTpr_Type, false);

			if (gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values != null)
			{
				AddObjectProperty("Values", gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values, false);
			}
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Type")]
		[XmlElement(ElementName="Type")]
		public string gxTpr_Type
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Type; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Type = value;
				SetDirty("Type");
			}
		}




		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Value" , IsNullable=false )]
		public GxSimpleCollection<string> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values == null )
				{
					gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = new GxSimpleCollection<string>( );
				}
				return gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values;
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N = false;
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = value;
			}
		}

		[XmlIgnore]
		public GxSimpleCollection<string> gxTpr_Values
		{
			get {
				if ( gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values == null )
				{
					gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = new GxSimpleCollection<string>();
				}
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N = false;
				return gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values ;
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N = false;
				gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_SetNull()
		{
			gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N = true;
			gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = null;
		}

		public bool gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_IsNull()
		{
			return gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values == null;
		}
		public bool ShouldSerializegxTpr_Values_GxSimpleCollection_Json()
		{
			return gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values != null && gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values.Count > 0;

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
			gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Type = "";

			gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N = true;

			return  ;
		}



		#endregion

		#region Declaration

		protected string gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Type;
		 
		protected bool gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values_N;
		protected GxSimpleCollection<string> gxTv_SdtSDT_QueryViewerElements_Element_ExpandCollapse_Values = null;  


		#endregion
	}
	#region Rest interface
	[GxJsonSerialization("default")]
	[DataContract(Name=@"SDT_QueryViewerElements.Element.ExpandCollapse", Namespace="GeneXus.Reporting")]
	public class SdtSDT_QueryViewerElements_Element_ExpandCollapse_RESTInterface : GxGenericCollectionItem<SdtSDT_QueryViewerElements_Element_ExpandCollapse>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_QueryViewerElements_Element_ExpandCollapse_RESTInterface( ) : base()
		{	
		}

		public SdtSDT_QueryViewerElements_Element_ExpandCollapse_RESTInterface( SdtSDT_QueryViewerElements_Element_ExpandCollapse psdt ) : base(psdt)
		{	
		}

		#region Rest Properties
		[DataMember(Name="Type", Order=0)]
		public  string gxTpr_Type
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Type);

			}
			set { 
				 sdt.gxTpr_Type = value;
			}
		}

		[DataMember(Name="Values", Order=1, EmitDefaultValue=false)]
		public  GxSimpleCollection<string> gxTpr_Values
		{
			get { 
				if (sdt.ShouldSerializegxTpr_Values_GxSimpleCollection_Json())
					return sdt.gxTpr_Values;
				else
					return null;

			}
			set { 
				sdt.gxTpr_Values = value ;
			}
		}


		#endregion

		public SdtSDT_QueryViewerElements_Element_ExpandCollapse sdt
		{
			get { 
				return (SdtSDT_QueryViewerElements_Element_ExpandCollapse)Sdt;
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
				sdt = new SdtSDT_QueryViewerElements_Element_ExpandCollapse() ;
			}
		}
	}
	#endregion
}