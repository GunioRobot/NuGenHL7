using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a MDM_T09 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: EVN (EVN - event type segment) <b></b><br>
	/// 2: PID (PID - patient identification segment) <b></b><br>
	/// 3: PV1 (PV1 - patient visit segment-) <b></b><br>
	/// 4: TXA (Document notification segment) <b></b><br>
	/// </summary>
	[Serializable]
	public class MDM_T09:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EVN (EVN - event type segment) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PV1 (PV1 - patient visit segment-) - creates it if necessary</summary>
		virtual public PV1 PV1
		{
			get
			{
				PV1 ret = null;
				try
				{
					ret = (PV1) this.get_Renamed("PV1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns TXA (Document notification segment) - creates it if necessary</summary>
		virtual public TXA TXA
		{
			get
			{
				TXA ret = null;
				try
				{
					ret = (TXA) this.get_Renamed("TXA");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a new MDM_T09 Group with custom ModelClassFactory.</summary>
		public MDM_T09(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new MDM_T09 Group with DefaultModelClassFactory. </summary>
		public MDM_T09():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PV1), true, false);
				this.add(typeof(TXA), true, false);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}