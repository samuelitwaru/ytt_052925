/*
				   File: type_SdtQueryViewerElements_Element_Filter
			Description: Filter
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
	[XmlRoot(ElementName="QueryViewerElements.Element.Filter")]
	[XmlType(TypeName="QueryViewerElements.Element.Filter" , Namespace="GeneXus.Reporting" )]
	[Serializable]
	public class SdtQueryViewerElements_Element_Filter : GxUserType
	{
		public SdtQueryViewerElements_Element_Filter( )
		{
			/* Constructor for serialization */
		}

		public SdtQueryViewerElements_Element_Filter(IGxContext context)
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

			if (gxTv_SdtQueryViewerElements_Element_Filter_Values != null)
			{
				AddObjectProperty("Values", gxTv_SdtQueryViewerElements_Element_Filter_Values, false);
			}
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Type")]
		[XmlElement(ElementName="Type")]
		public short gxTpr_Type
		{
			get {
				return gxTv_SdtQueryViewerElements_Element_Filter_Type; 
			}
			set {
				gxTv_SdtQueryViewerElements_Element_Filter_Type = value;
				SetDirty("Type");
			}
		}




		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Value" , IsNullable=false )]
		public GxSimpleCollection<string> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtQueryViewerElements_Element_Filter_Values == null )
				{
					gxTv_SdtQueryViewerElements_Element_Filter_Values = new GxSimpleCollection<string>( );
				}
				return gxTv_SdtQueryViewerElements_Element_Filter_Values;
			}
			set {
				gxTv_SdtQueryViewerElements_Element_Filter_Values_N = false;
				gxTv_SdtQueryViewerElements_Element_Filter_Values = value;
			}
		}

		[XmlIgnore]
		public GxSimpleCollection<string> gxTpr_Values
		{
			get {
				if ( gxTv_SdtQueryViewerElements_Element_Filter_Values == null )
				{
					gxTv_SdtQueryViewerElements_Element_Filter_Values = new GxSimpleCollection<string>();
				}
				gxTv_SdtQueryViewerElements_Element_Filter_Values_N = false;
				return gxTv_SdtQueryViewerElements_Element_Filter_Values ;
			}
			set {
				gxTv_SdtQueryViewerElements_Element_Filter_Values_N = false;
				gxTv_SdtQueryViewerElements_Element_Filter_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtQueryViewerElements_Element_Filter_Values_SetNull()
		{
			gxTv_SdtQueryViewerElements_Element_Filter_Values_N = true;
			gxTv_SdtQueryViewerElements_Element_Filter_Values = null;
		}

		public bool gxTv_SdtQueryViewerElements_Element_Filter_Values_IsNull()
		{
			return gxTv_SdtQueryViewerElements_Element_Filter_Values == null;
		}
		public bool ShouldSerializegxTpr_Values_GxSimpleCollection_Json()
		{
			return gxTv_SdtQueryViewerElements_Element_Filter_Values != null && gxTv_SdtQueryViewerElements_Element_Filter_Values.Count > 0;

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
			gxTv_SdtQueryViewerElements_Element_Filter_Values_N = true;

			return  ;
		}



		#endregion

		#region Declaration

		protected short gxTv_SdtQueryViewerElements_Element_Filter_Type;
		 
		protected bool gxTv_SdtQueryViewerElements_Element_Filter_Values_N;
		protected GxSimpleCollection<string> gxTv_SdtQueryViewerElements_Element_Filter_Values = null;  


		#endregion
	}
	#region Rest interface
	[GxJsonSerialization("default")]
	[DataContract(Name=@"QueryViewerElements.Element.Filter", Namespace="GeneXus.Reporting")]
	public class SdtQueryViewerElements_Element_Filter_RESTInterface : GxGenericCollectionItem<SdtQueryViewerElements_Element_Filter>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtQueryViewerElements_Element_Filter_RESTInterface( ) : base()
		{	
		}

		public SdtQueryViewerElements_Element_Filter_RESTInterface( SdtQueryViewerElements_Element_Filter psdt ) : base(psdt)
		{	
		}

		#region Rest Properties
		[DataMember(Name="Type", Order=0)]
		public short gxTpr_Type
		{
			get { 
				return sdt.gxTpr_Type;

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

		public SdtQueryViewerElements_Element_Filter sdt
		{
			get { 
				return (SdtQueryViewerElements_Element_Filter)Sdt;
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
				sdt = new SdtQueryViewerElements_Element_Filter() ;
			}
		}
	}
	#endregion
}