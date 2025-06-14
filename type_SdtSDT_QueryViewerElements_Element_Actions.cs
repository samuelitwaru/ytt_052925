/*
				   File: type_SdtSDT_QueryViewerElements_Element_Actions
			Description: Actions
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
	[XmlRoot(ElementName="SDT_QueryViewerElements.Element.Actions")]
	[XmlType(TypeName="SDT_QueryViewerElements.Element.Actions" , Namespace="GeneXus.Reporting" )]
	[Serializable]
	public class SdtSDT_QueryViewerElements_Element_Actions : GxUserType
	{
		public SdtSDT_QueryViewerElements_Element_Actions( )
		{
			/* Constructor for serialization */
		}

		public SdtSDT_QueryViewerElements_Element_Actions(IGxContext context)
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
			AddObjectProperty("RaiseItemClick", gxTpr_Raiseitemclick, false);

			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="RaiseItemClick")]
		[XmlElement(ElementName="RaiseItemClick")]
		public bool gxTpr_Raiseitemclick
		{
			get {
				return gxTv_SdtSDT_QueryViewerElements_Element_Actions_Raiseitemclick; 
			}
			set {
				gxTv_SdtSDT_QueryViewerElements_Element_Actions_Raiseitemclick = value;
				SetDirty("Raiseitemclick");
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
			gxTv_SdtSDT_QueryViewerElements_Element_Actions_Raiseitemclick = true;
			return  ;
		}



		#endregion

		#region Declaration

		protected bool gxTv_SdtSDT_QueryViewerElements_Element_Actions_Raiseitemclick;
		 


		#endregion
	}
	#region Rest interface
	[GxJsonSerialization("default")]
	[DataContract(Name=@"SDT_QueryViewerElements.Element.Actions", Namespace="GeneXus.Reporting")]
	public class SdtSDT_QueryViewerElements_Element_Actions_RESTInterface : GxGenericCollectionItem<SdtSDT_QueryViewerElements_Element_Actions>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtSDT_QueryViewerElements_Element_Actions_RESTInterface( ) : base()
		{	
		}

		public SdtSDT_QueryViewerElements_Element_Actions_RESTInterface( SdtSDT_QueryViewerElements_Element_Actions psdt ) : base(psdt)
		{	
		}

		#region Rest Properties
		[DataMember(Name="RaiseItemClick", Order=0)]
		public bool gxTpr_Raiseitemclick
		{
			get { 
				return sdt.gxTpr_Raiseitemclick;

			}
			set { 
				sdt.gxTpr_Raiseitemclick = value;
			}
		}


		#endregion

		public SdtSDT_QueryViewerElements_Element_Actions sdt
		{
			get { 
				return (SdtSDT_QueryViewerElements_Element_Actions)Sdt;
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
				sdt = new SdtSDT_QueryViewerElements_Element_Actions() ;
			}
		}
	}
	#endregion
}