using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v22.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v22.group
{
	/// <summary> <p>Represents the NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: NCK (System Clock) <b>optional </b><br>
	/// 1: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
	/// 2: NST (Statistics) <b>optional </b><br>
	/// 3: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
	/// 4: NSC (STATUS CHANGE) <b>optional </b><br>
	/// 5: NTE (NOTES AND COMMENTS) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT:AbstractGroup
	{
		/// <summary> Returns NCK (System Clock) - creates it if necessary</summary>
		virtual public NCK NCK
		{
			get
			{
				NCK ret = null;
				try
				{
					ret = (NCK) this.get_Renamed("NCK");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE </summary>
		virtual public int NTEReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns NST (Statistics) - creates it if necessary</summary>
		virtual public NST NST
		{
			get
			{
				NST ret = null;
				try
				{
					ret = (NST) this.get_Renamed("NST");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE2 </summary>
		virtual public int NTE2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns NSC (STATUS CHANGE) - creates it if necessary</summary>
		virtual public NSC NSC
		{
			get
			{
				NSC ret = null;
				try
				{
					ret = (NSC) this.get_Renamed("NSC");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of NTE3 </summary>
		virtual public int NTE3Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("NTE3").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT Group.</summary>
		public NMR_N02_CLOCK_AND_STATS_WITH_NOTES_ALT(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(NCK), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(NST), false, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(NSC), false, false);
				this.add(typeof(NTE), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary</summary>
		public virtual NTE getNTE()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE
		/// (NOTES AND COMMENTS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE(int rep)
		{
			return (NTE) this.get_Renamed("NTE", rep);
		}
		
		/// <summary> Returns  first repetition of NTE2 (NOTES AND COMMENTS) - creates it if necessary</summary>
		public virtual NTE getNTE2()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE2
		/// (NOTES AND COMMENTS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE2(int rep)
		{
			return (NTE) this.get_Renamed("NTE2", rep);
		}
		
		/// <summary> Returns  first repetition of NTE3 (NOTES AND COMMENTS) - creates it if necessary</summary>
		public virtual NTE getNTE3()
		{
			NTE ret = null;
			try
			{
				ret = (NTE) this.get_Renamed("NTE3");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of NTE3
		/// (NOTES AND COMMENTS) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual NTE getNTE3(int rep)
		{
			return (NTE) this.get_Renamed("NTE3", rep);
		}
	}
}