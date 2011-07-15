using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a ADT_A43 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: EVN (EVN - event type segment) <b></b><br>
	/// 2: ADT_A43_PIDPD1MRG (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class ADT_A43:AbstractMessage
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
		/// <summary> Returns the number of existing repetitions of ADT_A43_PIDPD1MRG </summary>
		virtual public int PIDPD1MRGReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PIDPD1MRG").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new ADT_A43 Group with custom ModelClassFactory.</summary>
		public ADT_A43(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new ADT_A43 Group with DefaultModelClassFactory. </summary>
		public ADT_A43():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(ADT_A43_PIDPD1MRG), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of ADT_A43_PIDPD1MRG (a Group object) - creates it if necessary</summary>
		public virtual ADT_A43_PIDPD1MRG getPIDPD1MRG()
		{
			ADT_A43_PIDPD1MRG ret = null;
			try
			{
				ret = (ADT_A43_PIDPD1MRG) this.get_Renamed("PIDPD1MRG");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of ADT_A43_PIDPD1MRG
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual ADT_A43_PIDPD1MRG getPIDPD1MRG(int rep)
		{
			return (ADT_A43_PIDPD1MRG) this.get_Renamed("PIDPD1MRG", rep);
		}
	}
}